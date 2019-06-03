using System;
using BLL;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace FAI_lab2.Views.Punetorii
{
    public partial class Edit : System.Web.UI.Page
    {
        
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                placeShenimet();
              
                }
            }
        private void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;
            PunetoriiDLL();


            BLL.Punetori ex = new BLL.Punetori();
            PunetoriMapper em = new PunetoriMapper(ex);
            em.SelectedID(ID);
        }


        private void PunetoriiDLL()
            {
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
                }
            else if (MbiemriTextBox.Text.Length == 0)
            {
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
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                    BLL.Punetori obj = new BLL.Punetori();
                PunetoriMapper objm = new PunetoriMapper(obj);
                    objm.SelectedID(ID);



                obj.Emri = EmriTextBox.Text;
                    obj.Mbiemri = MbiemriTextBox.Text;
                    obj.Gjinia = GjiniaTextBox.Text;
                    obj.RoliID = Int32.Parse(RoliDropDownList.SelectedItem.Value);

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
