using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijskiOkvir {
	public class Rezident : Osoba{
		private DateTime datumUseljenja;
		private DateTime datumIseljenja;
		List<string> listaZahtjeva;
        public static List<Rezident> DohvatiListuRezidenata()
        {
            List<Rezident> listaRezidenata= new List<Rezident>();
            string upit = "SELECT * FROM Rezident";
            SqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Rezident njeg = new Rezident(dr);
                    listaRezidenata.Add(njeg);
                }
            }
            return listaRezidenata;
        }

        public Rezident()
        {

        }

        public Rezident(SqlDataReader dr)
        {
            this.Ime = dr["ime"].ToString();
            this.Prezime = dr["prezime"].ToString();
            this.Id = int.Parse(dr["rezidentId"].ToString());
            this.KorisnickoIme = dr["korisnickoIme"].ToString();
        }
    }
}
