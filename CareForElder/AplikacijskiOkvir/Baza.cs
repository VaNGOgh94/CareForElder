using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijskiOkvir {
	public class Baza {
		private string connectionString;
		private SqlConnection veza;
		private static Baza instanca; 
		public SqlConnection Veza {
			get {
				return veza;
			}

			set {
				veza = value;
			}
		}

		public static Baza Instanca {
			get {
				if (instanca == null) {
					instanca = new Baza();
				}
				return instanca;
			}
			set {
				instanca = value;
			}
		}

		public SqlDataReader DohvatiDataReader(string sqlUpit) {
			SqlCommand naredba = new SqlCommand(sqlUpit, veza);
			return naredba.ExecuteReader();
		}

		public int IzvrsiUpit(string sqlUpit) {
			SqlCommand naredba = new SqlCommand(sqlUpit, veza);
			return naredba.ExecuteNonQuery();
		}

		public object DohvatiSkalar(string sqlUpit) {
			SqlCommand naredba = new SqlCommand(sqlUpit, veza);
			return naredba.ExecuteScalar();
		}

		public void SpojiSe() {
			veza.ConnectionString = connectionString;
			veza.Open();
		}

		private Baza() {
			connectionString = "Data Source = mssql4.gear.host; Initial Catalog = careforelderdb; Integrated Security = False; User ID = careforelderdb; Password=Vg65HW5!-q0N;Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			veza = new SqlConnection(connectionString);
			veza.Open();
		}
		~Baza() {
			if(veza.State != ConnectionState.Closed)
			veza.Close();
			veza = null;
		}
	}
}
