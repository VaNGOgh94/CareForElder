using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacijskiOkvir;
namespace CareForElder
{
    public partial class VlastitiProfil : Form
    {
        List<Njegovatelj> listaNjegovatelja;
        List<Rezident> listaRezidenata;
        public VlastitiProfil()
        {
            InitializeComponent();
            listaNjegovatelja = Njegovatelj.DohvatiListuNjegovatelja();
            dgvNjegovatelji.DataSource = listaNjegovatelja;
            listaRezidenata = Rezident.DohvatiListuRezidenata();
            dgvRezidenti.DataSource = listaRezidenata;
        }
    }
}
