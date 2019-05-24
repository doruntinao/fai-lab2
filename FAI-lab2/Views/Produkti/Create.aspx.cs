using DAL;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data.SqlClient;

namespace FAI_lab2.Views.Produkti
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GrupiDLL();
            }
        }

        private void GrupiDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select GrupiID, Grupi from Grupi", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                GrupiDropDownList.DataTextField = "Grupi";
                GrupiDropDownList.DataValueField = "GrupiID";
                GrupiDropDownList.DataSource = rdr;
                GrupiDropDownList.DataBind();
                GrupiDropDownList.Items.Insert(0, "Selekto Grupin");
            }
            finally
            {
                con.Close();
            }
        }


        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (EmriTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                EmriTextBox.Focus();
                return;
            }
            else if (PershkrimiTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                PershkrimiTextBox.Focus();
                return;
            }
            else if (ProdhuesiTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                ProdhuesiTextBox.Focus();
                return;
            }
            else if (ModeliTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                ModeliTextBox.Focus();
                return;
            }
            else if (JetegjatesiaTextBox.Text.Length <= 0)
            {
                lblError.Visible = true;

                JetegjatesiaTextBox.Focus();
                return;
            }
            else if (SasiaTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                SasiaTextBox.Focus();
                return;
            }
            else if (salvageValueTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                salvageValueTextBox.Focus();
                return;
            }
            else
            {
                BLL.Produkti obj = new BLL.Produkti();
                obj.Emri = EmriTextBox.Text;
                obj.Pershkrimi = PershkrimiTextBox.Text;
                obj.Prodhuesi = ProdhuesiTextBox.Text;
                obj.Modeli = ModeliTextBox.Text;
                obj.Jetegjatesia = Int32.Parse(JetegjatesiaTextBox.Text);
                obj.Asset = AssetCheckBox.Checked;
                obj.Sasia = Int32.Parse(SasiaTextBox.Text);
                obj.Grupi = Int32.Parse(GrupiDropDownList.SelectedItem.Value);
                obj.Statusi = StatusiCheckBox.Checked;
                obj.salvageValue = Int32.Parse(salvageValueTextBox.Text);
                ProduktiMapper objm = new ProduktiMapper(obj);
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
