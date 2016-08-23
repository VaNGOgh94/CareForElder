using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijskiOkvir {
	class Korisnik : Osoba {
		private static Korisnik instance;

		public static Korisnik Instance {
			get {
				if (instance == null) {
					instance = new Korisnik();
				}
				return instance;
			}
		}
		
		private Korisnik() {

		}
	}
}
