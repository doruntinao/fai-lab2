using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace FAI_lab2.Views.Grupet
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                KategoriaDLL();
            }
        }

        private void KategoriaDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select KategoriaID, VleraKategorise from Kategoria", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                KategoriaDropDownList.DataTextField = "VleraKategorise";
                KategoriaDropDownList.DataValueField = "KategoriaID";
                KategoriaDropDownList.DataSource = rdr;
                KategoriaDropDownList.DataBind();
                KategoriaDropDownList.Items.Insert(0, "Selekto Kategorin");
            }
            finally
            {
                con.Close();
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (GrupiTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                GrupiTextBox.Focus();
                return;
            }
            else
            {
                Grupi obj = new Grupi();
                obj.emriGrupit = GrupiTextBox.Text;
                obj.KategoriaID = Int32.Parse(KategoriaDropDownList.SelectedItem.Value);

                GrupiMapper objm = new GrupiMapper(obj);
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