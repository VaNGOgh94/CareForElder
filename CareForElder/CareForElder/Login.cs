using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using AplikacijskiOkvir;
namespace CareForElder {
	public partial class Login : Form {
        List<Njegovatelj> listaNjegovatelja = new List<Njegovatelj>();
		public Login() {
			InitializeComponent();
        }

        private bool ProvjeriKorisnickePodatke()
        {
            //implementirat provjeru kor_imena i lozinke
            return true;
        }

        private void OtvoriGlavniProzor()
        {
            frmGlavna glavnaForma = new frmGlavna();
            glavnaForma.Show();
            this.Hide();
        }

		private void btnPrijava_Click(object sender, EventArgs e) {
            if(ProvjeriKorisnickePodatke() == true)
            {
                //udi u aplikaciju:
                OtvoriGlavniProzor();
            }
		}

        private void label3_Click(object sender, EventArgs e)
        {
            Registracija frmRegistracija = new Registracija(this);
            //frmRegistracija.ShowDialog();
            frmRegistracija.Show();
            //ako stavim samo show onda mogu prozor za registraciju upalit mnogo puta HEHE
            this.Hide();
        }
    }
}
