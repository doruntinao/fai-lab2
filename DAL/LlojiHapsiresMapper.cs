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
    public class LLojiHapsiresMapper
    {
        private LlojiHapsires mLLojiHapsires;


        public LLojiHapsiresMapper(LlojiHapsires o)
        {
            mLLojiHapsires = o;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("LLojiHapsiresDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LLojiID",mLLojiHapsires.LlojiID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Insert()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("LLojiHapsiresInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Lloji", mLLojiHapsires.Lloji);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Update()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("LLojiHapsiresUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LLlojiID", mLLojiHapsires.LlojiID);
                cmd.Parameters.AddWithValue("@Lloji", mLLojiHapsires.Lloji);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int LlojiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("LLojiHapsiresSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LlojiID", LlojiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mLLojiHapsires.LlojiID = (int)rdr["LLojiID"];

                    if (rdr["Lloji"] != DBNull.Value)
                        mLLojiHapsires.Lloji = (string)rdr["Lloji"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}

