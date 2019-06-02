using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LloiHapsiraveMappers
    {
        private List<LlojiHapsires> mLLojiHapsirave;

        public LloiHapsiraveMappers(List<LlojiHapsires> o)
        {
            mLLojiHapsirave = o;
        }

        public void SelectAllLlojiHapsirave()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("LLojiHapsiresSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LlojiHapsires o = new LlojiHapsires();
                    o.LlojiID = (int)rdr["LlojiID"];
                    if (rdr["Lloji"] != DBNull.Value)
                        o.Lloji = (string)rdr["Lloji"];
                    mLLojiHapsirave.Add(o);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}


