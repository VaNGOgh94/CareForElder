using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacijskiOkvir;

namespace CareForElder {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            Osoba.listaOsoba = new List<Osoba>();
            Application.Run(new Login());

        }
	}
}
