using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Produkti
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                placeShenimet();
        }


        private void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;

            BLL.Produkti ex = new BLL.Produkti();
            ProduktiMapper em = new ProduktiMapper(ex);
            em.SelectedID(ID);

            EmriTextBox.Text = ex.Emri;
            PershkrimiTextBox.Text = ex.Pershkrimi;
            ProdhuesiTextBox.Text = ex.Prodhuesi;
            ModeliTextBox.Text = ex.Modeli;
            JetegjatesiaTextBox.Text = ex.Jetegjatesia.ToString();
            AssetCheckBox.Checked = ex.Asset;
            SasiaTextBox.Text = ex.Sasia.ToString();
            GrupiDropDownList.SelectedValue = ex.Grupi.ToString();
            StatusiCheckBox.Checked = ex.Statusi;
            salvageValueTextBox.Text = ex.salvageValue.ToString();
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
            else if (JetegjatesiaTextBox.Text.Length == 0)
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
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                BLL.Produkti ex = new BLL.Produkti();
                ProduktiMapper em = new ProduktiMapper(ex);
                em.SelectedID(ID);


                ex.Emri = EmriTextBox.Text;
                ex.Pershkrimi = PershkrimiTextBox.Text;
                ex.Prodhuesi = ProdhuesiTextBox.Text;
                ex.Modeli = ModeliTextBox.Text;
                ex.Jetegjatesia = Int32.Parse(JetegjatesiaTextBox.Text);
                ex.Asset = AssetCheckBox.Checked;
                ex.Sasia = Int32.Parse(SasiaTextBox.Text);
                ex.Grupi = Int32.Parse(GrupiDropDownList.DataValueField);
                ex.Statusi = StatusiCheckBox.Checked;
                ex.salvageValue = Int32.Parse(salvageValueTextBox.Text);

                em.Update();
                Response.Redirect("Index.aspx");
            }
        }


        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}