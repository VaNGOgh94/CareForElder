using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijskiOkvir {
	public class Osoba {
        private string korisnickoIme;
		private int id;
		private string ime;
		private string prezime;
		private TipKorisnika tipKorisnika;
		private DateTime datumRodenja;
		private bool online;
        public static List<Osoba> listaOsoba;
        public int Id {
			get {
				return id;
			}

			set {
				id = value;
			}
		}

        public string Ime {
			get {
				return ime;
			}

			set {
				ime = value;
			}
		}

        public string Prezime {
			get {
				return prezime;
			}

			set {
				prezime = value;
			}
		}

        public TipKorisnika TipKorisnika {
			get {
				return tipKorisnika;
			}

			set {
				tipKorisnika = value;
			}
		}

		public DateTime DatumRodenja {
			get {
				return datumRodenja;
			}

			set {
				datumRodenja = value;
			}
		}

		public bool Online {
			get {
				return online;
			}

			set {
				online = value;
			}
		}

        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }

            set
            {
                korisnickoIme = value;
            }
        }
    }
}
