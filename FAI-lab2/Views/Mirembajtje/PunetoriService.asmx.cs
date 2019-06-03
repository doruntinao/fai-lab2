using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FAI_lab2.Views.Mirembajtje
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Wenn der Aufruf dieses Webdiensts aus einem Skript zulässig sein soll, heben Sie mithilfe von ASP.NET AJAX die Kommentarmarkierung für die folgende Zeile auf. 
    [System.Web.Script.Services.ScriptService]
    public class PunetoriService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<string> GetPunetoriNames(string emriMbiemri)
        {
            List<string> PunetoriNames = new List<string>();
            string cs = ConfigurationManager.ConnectionStrings["FAI_Connection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("GetPunetoriNames", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@emriMbiemri", emriMbiemri);
                cmd.Parameters.Add(parameter);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    PunetoriNames.Add(rdr["Emri"].ToString()+" "+ rdr["Mbiemri"].ToString());
                }
            }
            return PunetoriNames;  
        }
    }
}