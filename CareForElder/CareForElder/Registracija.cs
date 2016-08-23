using AplikacijskiOkvir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareForElder
{
    public partial class Registracija : Form
    {
        Login frmLogin;
        public Registracija(Login frmLoginUlaz)
        {
            InitializeComponent();
            frmLogin = frmLoginUlaz;
            cbxTipKorisnika.DataSource = Enum.GetValues(typeof(TipKorisnika));
        }

        private void Registracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
