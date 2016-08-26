using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijskiOkvir {
	public class Njegovatelj : Osoba {
		private string email;
		private string radnoVrijeme; //od toliko do toliko
		private DateTime datumZaposlenja;
		private DateTime datumOtpustanja;
		
        public static List<Njegovatelj> DohvatiListuNjegovatelja()
        {
            List<Njegovatelj> listaNjegovatelja = new List<Njegovatelj>();
            string upit = "SELECT * FROM Njegovatelji";
            SqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);
            if (dr.HasRows) { 
                while (dr.Read())
                {
                    Njegovatelj njeg = new Njegovatelj(dr);
                    listaNjegovatelja.Add(njeg);
                }
            }
            //dr.Close();
            return listaNjegovatelja;
        }

        public Njegovatelj()
        {

        }

        public Njegovatelj(SqlDataReader dr)
        {

            this.Ime = dr["ime"].ToString();
            this.Prezime = dr["prezime"].ToString();
            this.Id = int.Parse(dr["njegovateljId"].ToString());
            this.KorisnickoIme = dr["korisnickoIme"].ToString();
        }

	}
}
