using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FAI_lab2.Views.Mirembajtje
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                placeShenimet();
            }
        }
        public int PunetoriID(String emriMbiemri)
        {
            int p = 0;
            string q = "SELECT * FROM Punetori WHERE Emri + ' ' + Mbiemri ="+" '"+emriMbiemri+"'";
            string cs = ConfigurationManager.ConnectionStrings["FAI_Connection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                        p = (int)rdr["PunetoriID"];
                }
            }
            return p;
        }

        public void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            Session.Add("ID", form.SelectedID);
            ViewState["SelectedID"] = ID;
            List<Produkti> ex = new List<Produkti>();
            ProduktetMappers em = new ProduktetMappers(ex);
            em.SelectedID(ID);

            ListGridView.DataSource = ex;
            ListGridView.DataBind();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (ContactTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                ContactTextBox.Focus();
                return;
            }
            else if (MessageTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                MessageTextBox.Focus();
                return;
            }
            else
            {
                Mirembajtja obj = new Mirembajtja();
                int id = (int)Session["ID"];

                obj.DataMirembajtjes = DateTime.Now;
                obj.Pershkrimi = MessageTextBox.Text;
                obj.ProduktiID = id;
                obj.PunetoriID = PunetoriID(ContactTextBox.Text);

                MirembajtjaMapper objm = new MirembajtjaMapper(obj);
                objm.Insert();
                Response.Redirect("Index.aspx");

            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}