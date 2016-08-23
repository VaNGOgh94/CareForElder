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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void OcistiStariProzor()
        {

        }

        private void mojProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            //obj.
            //MessageBox.Show(sender.ToString());
            VlastitiProfil forma = new VlastitiProfil();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            OcistiStariProzor();

        }
    }
}
