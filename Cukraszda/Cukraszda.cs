using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cukraszda
{
	public partial class frmCukraszda : Form
	{
		public static string fajlnev { get; set; }

		public frmCukraszda()
		{
			InitializeComponent();
		}

		private void mnuKilepes_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Cukraszda_Load(object sender, EventArgs e)
		{
			picDesszert.ImageLocation = "../../pohardesszert.jpg";
		}

		private void mnuMegnyitas_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				fajlnev = ofd.FileName;
				mnuSutemenyek.Enabled = true;
			}		
		}

		private void mnuSutemenyek_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmArlista ar = new frmArlista();
			ar.ShowDialog();
			ar.Dispose();
			this.Show();
		}

		private void mnuNevjegy_Click(object sender, EventArgs e)
		{
			frmNevjegy box = new frmNevjegy();
			box.ShowDialog();
		}
	}
}
