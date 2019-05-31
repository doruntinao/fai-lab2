using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Objekti
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (LokacioniTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                LokacioniTextBox.Focus();
                return;
            }
            else
            {
                BLL.Objekti obj = new BLL.Objekti();
                obj.Lokacioni = LokacioniTextBox.Text;

                ObjektiMapper objm = new ObjektiMapper(obj);
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