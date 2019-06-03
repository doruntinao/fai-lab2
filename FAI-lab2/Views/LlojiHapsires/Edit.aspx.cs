using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.LlojiHapsires
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                placeShenimet();
        }

        public void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;

            BLL.LlojiHapsires ex = new BLL.LlojiHapsires();
            LLojiHapsiresMapper em = new LLojiHapsiresMapper(ex);
            em.SelectedID(ID);

            LlojiTextBox.Text = ex.Lloji;
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
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                BLL.LlojiHapsires ex = new BLL.LlojiHapsires();
                LlojiHapsiresMapper em = new LlojiHapsiresMapper(ex);
                em.SelectedID(ID);
                ex.Lloji = LlojiTextBox.Text;

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