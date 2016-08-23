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

namespace CareForElder {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();
			//SqlConnection konekcija = new SqlConnection();
			//konekcija.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CareForElderDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			//konekcija.Open();
		}

		private void btnPrijava_Click(object sender, EventArgs e) {

		}
	}
}
