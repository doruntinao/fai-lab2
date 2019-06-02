using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.LlojiHapsires
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = true;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Session["DeletedID"].ToString());
            string page = Convert.ToString(Session["PreviousPageName"]);

            try
            {
                DeleteForm(id, page);

            }
            catch (SqlException ex)
            {
                if (ex.Errors.Count > 0)
                {
                    if (ex.Errors[0].Number == 547)
                    {
                        lblError.Text = "Ky entitet nuk mund të fshihet sepse është i ndërlidhur me entitete tjera!";
                        lblError.Visible = true;
                        return;

                    }
                }

            }
            Response.Redirect(page);
        }

        private void DeleteForm(int ID, string page)
        {
            if (page == "/Views/LlojiHapsires/Index.aspx")
            {
                BLL.LlojiHapsires obj = new BLL.LlojiHapsires();
                obj.LlojiID = ID;
                LlojiHapsiresMapper objm = new LlojiHapsiresMapper(obj);
                objm.Delete();
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {

            string page = Convert.ToString(Session["PreviousPageName"]);
            Response.Redirect(page);

        }
    }
}