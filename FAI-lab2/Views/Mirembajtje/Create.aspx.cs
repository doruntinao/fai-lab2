using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAI_lab2.Controllers;
using FAI_lab2.Models;

namespace FAI_lab2.Views.Mirembajtje
{
    public partial class Create : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                placeShenimet();
            }
        }

        public void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            id = form.SelectedID;
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
                obj.DataMirembajtjes = DateTime.Now;
                obj.Pershkrimi = MessageTextBox.Text;
                obj.ProduktiID = id;
               // obj.PunetoriID = ps.punetoriID;
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}