using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Vendori
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                BLL.Vendori obj = new BLL.Vendori();
                obj.Emri = EmriTextBox.Text;
                obj.Lokacioni = LokacioniTextBox.Text;
                obj.NrKontaktues = int.Parse(NrKontaktuesTextBox.Text);
                obj.BankAccount = int.Parse(BankAccountTextBox.Text);


                VendoriMapper objm = new VendoriMapper(obj);
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