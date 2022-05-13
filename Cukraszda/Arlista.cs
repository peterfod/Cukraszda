using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cukraszda
{
	public partial class frmArlista : Form
	{
		private static List<Sutemenyek> lista = new List<Sutemenyek>();

		public frmArlista()
		{
			InitializeComponent();
		}

		private void frmArlista_Load(object sender, EventArgs e)
		{
			StreamReader sr = new StreamReader(frmCukraszda.fajlnev);
			while (!sr.EndOfStream)
			{
				Sutemenyek sor = new Sutemenyek(sr.ReadLine());
				lista.Add(sor);
			}
			sr.Close();
			
			chb1.Text = lista[0].nev + " (" + lista[0].ar + " Ft)";
			chb2.Text = lista[1].nev + " (" + lista[1].ar + " Ft)";
			chb3.Text = lista[2].nev + " (" + lista[2].ar + " Ft)";
			chb4.Text = lista[3].nev + " (" + lista[3].ar + " Ft)";
			chb5.Text = lista[4].nev + " (" + lista[4].ar + " Ft)";
		}

		private void btnRendel_Click(object sender, EventArgs e)
		{
			if (chb1.Checked || chb2.Checked || chb3.Checked || chb4.Checked || chb5.Checked)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show($"Rendeljél valamit!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void mnuSzamla_Click(object sender, EventArgs e)
		{
			int vegosszeg = 0;
			rtbSzamla.Visible = true;
			if (chb1.Checked)
			{
				int osszeg = Convert.ToInt32(txb1.Text) * lista[0].ar;
				rtbSzamla.Text += $"\n   {chb1.Text}     {osszeg} Ft";
				vegosszeg += osszeg;
			}
			if (chb2.Checked)
			{
				int osszeg = Convert.ToInt32(txb2.Text) * lista[1].ar;
				rtbSzamla.Text += $"\n   {chb2.Text}     {osszeg} Ft";
				vegosszeg += osszeg;
			}
			if (chb3.Checked)
			{
				int osszeg = Convert.ToInt32(txb3.Text) * lista[2].ar;
				rtbSzamla.Text += $"\n   {chb3.Text}     {osszeg} Ft";
				vegosszeg += osszeg;
			}
			if (chb4.Checked)
			{
				int osszeg = Convert.ToInt32(txb4.Text) * lista[3].ar;
				rtbSzamla.Text += $"\n   {chb4.Text}     {osszeg} Ft";
				vegosszeg += osszeg;
			}
			if (chb5.Checked)
			{
				int osszeg = Convert.ToInt32(txb5.Text) * lista[4].ar;
				rtbSzamla.Text += $"\n   {chb5.Text}     {osszeg} Ft";
				vegosszeg += osszeg;
			}
			rtbSzamla.Text += $"\n\nÖsszesen:                  {vegosszeg} Ft";
		}

		private void chb1_CheckedChanged(object sender, EventArgs e)
		{
			if (chb1.Checked) { txb1.Text = "1"; } else { txb1.Text = ""; }
		}

		private void chb2_CheckedChanged(object sender, EventArgs e)
		{
			string result = chb2.Checked ? txb2.Text = "1" : txb2.Text = "";
		}

		private void chb3_CheckedChanged(object sender, EventArgs e)
		{
			var result = chb3.Checked ? txb3.Text = "1" : txb3.Text = "";
		}

		private void chb4_CheckedChanged(object sender, EventArgs e)
		{
			var result = chb4.Checked ? txb4.Text = "1" : txb4.Text = "";
		}

		private void chb5_CheckedChanged(object sender, EventArgs e)
		{
			var result = chb5.Checked ? txb5.Text = "1" : txb5.Text = "";
		}
	}
}
