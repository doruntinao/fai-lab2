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
    class GrupetMappers
    {
        private List<Grupi> mGrupet;

        public GrupetMappers(List<Grupi> g)
        {
            mGrupet = g;
        }

        public void SelectAllGrupet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("GrupiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Grupi g = new Grupi();
                    g.GrupiID = (int)rdr["GrupiID"];
                    if (rdr["Grupi"] != DBNull.Value)
                        g.emriGrupit = (string)rdr["Grupi"];
                    if (rdr["Kategoria"] != DBNull.Value)
                        g.Kategoria = (List<Kategoria>)rdr["Kategoria"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
