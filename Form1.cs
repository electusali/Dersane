using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DersaneDeneme
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U2RCCIRO;Initial Catalog=ApartmanYonetici;Integrated Security=True");
		private void btnGiris_Click(object sender, EventArgs e)
		{
			try
			{
				if (baglanti.State==ConnectionState.Closed)
				{
					baglanti.Open();
				}
				string sql = "Select * from Yonetim where KullaniciAdi=@kadi AND KullaniciSifre=@Sifre";
				SqlParameter prm1 = new SqlParameter("kadi", tbxKadi.Text);
				SqlParameter prm2 = new SqlParameter("Sifre", tbxSifre.Text);
				SqlCommand command = new SqlCommand(sql, baglanti);
				command.Parameters.Add(prm1);
				command.Parameters.Add(prm2);

				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
				sqlDataAdapter.Fill(dataTable);

				if (dataTable.Rows.Count>0)
				{
					AnaModul anaModulcs = new AnaModul();
					anaModulcs.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Hayır");
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}
	}
}
