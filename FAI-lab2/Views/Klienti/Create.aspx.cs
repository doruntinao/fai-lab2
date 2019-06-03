using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Klienti
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
            else if (MbiemriTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                MbiemriTextBox.Focus();
                return;
            }
            else if (NumriTelefonitTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                NumriTelefonitTextBox.Focus();
                return;
            }
            else if (EmailTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                EmailTextBox.Focus();
                return;
            }

            else
            {
                BLL.Klienti obj = new BLL.Klienti();
                obj.Emri = EmriTextBox.Text;
                obj.Mbiemri = MbiemriTextBox.Text;
                obj.NumriTelefonit = int.Parse(NumriTelefonitTextBox.Text);
                obj.Email = EmailTextBox.Text;
            

                KlientiMapper objm = new KlientiMapper(obj);
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