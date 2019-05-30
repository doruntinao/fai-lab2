using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Punetorii
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PunetoriiDLL();
            }
        }
        private void PunetoriiDLL (){
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select RoliID, Roli from Roli", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                RoliDropDownList.DataTextField = "Roli";
                RoliDropDownList.DataValueField = "RoliID";
                RoliDropDownList.DataSource = rdr;
                RoliDropDownList.DataBind();
                RoliDropDownList.Items.Insert(0, "Selekto Rolin");
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
            }else if (MbiemriTextBox.Text.Length==0){
                lblError.Visible = true;

                MbiemriTextBox.Focus();
                return;
            }
            else if (GjiniaTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                GjiniaTextBox.Focus();
                return;
            }
            else
            {
                BLL.Punetori obj = new BLL.Punetori();
                obj.Emri = EmriTextBox.Text;
                obj.Mbiemri = MbiemriTextBox.Text;
                obj.Gjinia = GjiniaTextBox.Text;
                obj.RoliID = Int32.Parse(RoliDropDownList.SelectedItem.Value);

                PunetoriMapper objm = new PunetoriMapper(obj);
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