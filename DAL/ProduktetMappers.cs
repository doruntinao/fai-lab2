using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class ProduktetMappers
    {
        private List<Produkti> mProduktet;

        public ProduktetMappers(List<Produkti> p)
        {
            mProduktet = p;
        }

        public void SelectAllProduktet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Produkti p = new Produkti();
                    p.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["Emri"] != DBNull.Value)
                        p.Emri = (string)rdr["Emri"];
                    if (rdr["Pershkrimi"] != DBNull.Value)
                        p.Pershkrimi = (string)rdr["Pershkrimi"];
                    if (rdr["Prodhuesi"] != DBNull.Value)
                        p.Prodhuesi = (string)rdr["Prodhuesi"];
                    if (rdr["Modeli"] != DBNull.Value)
                        p.Modeli = (string)rdr["Modeli"];
                    if (rdr["Jetegjatesia"] != DBNull.Value)
                        p.Jetegjatesia = (int)rdr["Jetegjatesia"];
                    if (rdr["Sasia"] != DBNull.Value)
                        p.Sasia = (int)rdr["Sasia"];
                    if (rdr["GrupiID"] != DBNull.Value)
                        p.Grupi = (int)rdr["GrupiID"]; 
                    if (rdr["salvageValue"] != DBNull.Value)
                        p.salvageValue = (int)rdr["salvageValue"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
