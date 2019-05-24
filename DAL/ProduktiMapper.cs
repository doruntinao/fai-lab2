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
    public class ProduktiMapper
    {
        private Produkti mProdukti;

        public ProduktiMapper(Produkti p)
        {
            mProdukti = p;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", mProdukti.ProduktiID);
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
                SqlCommand cmd = new SqlCommand("ProduktiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emri", mProdukti.Emri);
                cmd.Parameters.AddWithValue("@Pershkrimi", mProdukti.Pershkrimi);
                cmd.Parameters.AddWithValue("@Prodhuesi", mProdukti.Prodhuesi);
                cmd.Parameters.AddWithValue("@Modeli", mProdukti.Modeli);
                cmd.Parameters.AddWithValue("@Jetegjatesia", mProdukti.Jetegjatesia);
                cmd.Parameters.AddWithValue("@Asset", mProdukti.Asset);
                cmd.Parameters.AddWithValue("@Sasia", mProdukti.Sasia);
                cmd.Parameters.AddWithValue("@GrupiID", mProdukti.Grupi);
                cmd.Parameters.AddWithValue("@Statusi", mProdukti.Statusi);
                cmd.Parameters.AddWithValue("@salvageValue", mProdukti.salvageValue);
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
                SqlCommand cmd = new SqlCommand("ProduktiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emri", mProdukti.Emri);
                cmd.Parameters.AddWithValue("@Pershkrimi", mProdukti.Pershkrimi);
                cmd.Parameters.AddWithValue("@Prodhuesi", mProdukti.Prodhuesi);
                cmd.Parameters.AddWithValue("@Modeli", mProdukti.Modeli);
                cmd.Parameters.AddWithValue("@Jetegjatesia", mProdukti.Jetegjatesia);
                cmd.Parameters.AddWithValue("@Asset", mProdukti.Asset);
                cmd.Parameters.AddWithValue("@Sasia", mProdukti.Sasia);
                cmd.Parameters.AddWithValue("@GrupiID", mProdukti.Grupi);
                cmd.Parameters.AddWithValue("@Statusi", mProdukti.Statusi);
                cmd.Parameters.AddWithValue("@salvageValue", mProdukti.salvageValue);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int ProduktiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", ProduktiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mProdukti.ProduktiID = (int)rdr["ProduktiID"];

                    if (rdr["Emri"] != DBNull.Value)
                        mProdukti.Emri = (string)rdr["Emri"];
                    if (rdr["Pershkrimi"] != DBNull.Value)
                        mProdukti.Pershkrimi = (string)rdr["Pershkrimi"];
                    if (rdr["Prodhuesi"] != DBNull.Value)
                        mProdukti.Prodhuesi = (string)rdr["Prodhuesi"];
                    if (rdr["Modeli"] != DBNull.Value)
                        mProdukti.Modeli = (string)rdr["Modeli"];
                    if (rdr["Jetegjatesia"] != DBNull.Value)
                        mProdukti.Jetegjatesia = (int)rdr["Jetegjatesia"];
                    if (rdr["Asset"] != DBNull.Value)
                        mProdukti.Asset = (Boolean)rdr["Asset"];
                    if (rdr["Sasia"] != DBNull.Value)
                        mProdukti.Sasia = (int)rdr["Sasia"];
                    if (rdr["GrupiID"] != DBNull.Value)
                        mProdukti.Grupi = (int)rdr["GrupiID"];
                    if (rdr["Statusi"] != DBNull.Value)
                        mProdukti.Statusi = (Boolean)rdr["Statusi"];
                 if (rdr["salvageValue"] != DBNull.Value)
                        mProdukti.salvageValue = (int)rdr["salvageValue"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
