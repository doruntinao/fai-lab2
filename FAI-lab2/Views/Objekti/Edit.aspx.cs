using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace FAI_lab2.Views.Objekti
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

            BLL.Objekti ex = new BLL.Objekti();
            ObjektiMapper em = new ObjektiMapper(ex);
            em.SelectedID(ID);

            LokacioniTextBox.Text = ex.Lokacioni;
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
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                BLL.Objekti ex = new BLL.Objekti();
                ObjektiMapper em = new ObjektiMapper(ex);
                em.SelectedID(ID);
                ex.Lokacioni = LokacioniTextBox.Text;

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