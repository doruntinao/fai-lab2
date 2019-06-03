using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.LlojiHapsires
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (LlojiTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                LlojiTextBox.Focus();
                return;
            }
            else
            {
                BLL.LlojiHapsires obj = new BLL.LlojiHapsires();
                obj.Lloji = LlojiTextBox.Text;

                LLojiHapsiresMapper objm = new LLojiHapsiresMapper(obj);
                objm.Insert();
                Response.Redirect("Index.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void LlojiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}