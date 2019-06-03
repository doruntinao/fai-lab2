using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Vendori
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;
                
            BLL.Vendori ex = new BLL.Vendori();
            VendoriMapper em = new VendoriMapper(ex);
            em.SelectedID(ID);
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {

            if (EmriTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                EmriTextBox.Focus();
                return;
            }
            else if (LokacioniTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                LokacioniTextBox.Focus();
                return;
            }
            else if (NrKontaktuesTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                NrKontaktuesTextBox.Focus();
                return;
            }
            else if (BankAccountTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                BankAccountTextBox.Focus();
                return;
            }
            else
            {
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                BLL.Vendori obj = new BLL.Vendori();
                VendoriMapper objm = new VendoriMapper(obj);
                objm.SelectedID(ID);
                obj.Emri = EmriTextBox.Text;
                obj.Lokacioni = LokacioniTextBox.Text;
                obj.NrKontaktues = int.Parse(NrKontaktuesTextBox.Text);
                obj.BankAccount = int.Parse(BankAccountTextBox.Text);

             
                
                objm.Update();
                Response.Redirect("Index.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");

        }
    }
}