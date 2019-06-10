using System;
using FAI_lab2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace FAI_lab2.Controllers
{
    public class MirembajtjaMapper
    {
        private Mirembajtja mMirembajtja;

        public MirembajtjaMapper(Mirembajtja m)
        {
            mMirembajtja = m;
        }

        //public void Delete()
        //{
        //    SqlConnection con = Generals.GetNewConnection();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("MirembajtjaDeleteRow", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@MirembajtjaID", mMirembajtja.MirembajtjaID);
        //        cmd.ExecuteNonQuery();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        public void Insert()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("MirembajtjaInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", mMirembajtja.ProduktiID);
                cmd.Parameters.AddWithValue("@DataMirembajtjes", mMirembajtja.DataMirembajtjes);
                cmd.Parameters.AddWithValue("@Pershkrimi", mMirembajtja.Pershkrimi);
                cmd.Parameters.AddWithValue("@PunetoriID", mMirembajtja.PunetoriID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        //public void Update()
        //{
        //    SqlConnection con = Generals.GetNewConnection();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("MirembajtjaUpdateRow", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@ProduktiID", mMirembajtja.ProduktiID);
        //        cmd.Parameters.AddWithValue("@DataMirembajtjes", mMirembajtja.DataMirembajtjes);
        //        cmd.Parameters.AddWithValue("@Pershkrimi", mMirembajtja.Pershkrimi);
        //        cmd.Parameters.AddWithValue("@PunetoriID", mMirembajtja.PunetoriID);
        //        cmd.ExecuteNonQuery();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        //public void SelectedID(int GrupiID)
        //{
        //    SqlConnection con = Generals.GetNewConnection();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("MirembajtjaSelectRow", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@GrupiID", GrupiID);

        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            mGrupi.GrupiID = (int)rdr["GrupiID"];

        //            if (rdr["Grupi"] != DBNull.Value)
        //                mGrupi.emriGrupit = (string)rdr["Grupi"];
        //            if (rdr["KategoriaID"] != DBNull.Value)
        //                mGrupi.KategoriaID = (int)rdr["KategoriaID"];
        //        }
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}