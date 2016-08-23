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

        private bool ProvjeriKorisnickoIme()
        {
            //implementacija veze sa bazom - ukoliko postoji isto korisnicko ime da ne da registrirat
            return true;
        }

        private void EvidentirajKorisnikaUBazu()
        {
            Osoba noviKorisnik = new Osoba();
            noviKorisnik.DatumRodenja = DateTime.Parse(tbxDatumRođenja.Text);
            noviKorisnik.KorisnickoIme = tbxKorisnickoIme.Text;
            noviKorisnik.Ime = tbxIme.Text;
            noviKorisnik.Prezime = tbxPrezime.Text;
            Osoba.listaOsoba.Add(noviKorisnik);
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            if(ProvjeriKorisnickoIme() == true)
            {
                EvidentirajKorisnikaUBazu();
                this.Close();
            }
            
        }
    }
}
