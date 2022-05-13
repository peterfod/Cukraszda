
namespace Cukraszda
{
	partial class frmCukraszda
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mnuMenusor = new System.Windows.Forms.MenuStrip();
			this.mnuFajl = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMegnyitas = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuKilepes = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSutemenyek = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNevjegy = new System.Windows.Forms.ToolStripMenuItem();
			this.picDesszert = new System.Windows.Forms.PictureBox();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.mnuMenusor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picDesszert)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMenusor
			// 
			this.mnuMenusor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFajl,
            this.mnuSutemenyek,
            this.mnuNevjegy});
			this.mnuMenusor.Location = new System.Drawing.Point(0, 0);
			this.mnuMenusor.Name = "mnuMenusor";
			this.mnuMenusor.Size = new System.Drawing.Size(440, 24);
			this.mnuMenusor.TabIndex = 0;
			this.mnuMenusor.Text = "menuStrip1";
			// 
			// mnuFajl
			// 
			this.mnuFajl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMegnyitas,
            this.mnuKilepes});
			this.mnuFajl.Name = "mnuFajl";
			this.mnuFajl.Size = new System.Drawing.Size(37, 20);
			this.mnuFajl.Text = "Fájl";
			// 
			// mnuMegnyitas
			// 
			this.mnuMegnyitas.Name = "mnuMegnyitas";
			this.mnuMegnyitas.Size = new System.Drawing.Size(138, 22);
			this.mnuMegnyitas.Text = "Megnyitás...";
			this.mnuMegnyitas.Click += new System.EventHandler(this.mnuMegnyitas_Click);
			// 
			// mnuKilepes
			// 
			this.mnuKilepes.Name = "mnuKilepes";
			this.mnuKilepes.Size = new System.Drawing.Size(138, 22);
			this.mnuKilepes.Text = "Kilépés";
			this.mnuKilepes.Click += new System.EventHandler(this.mnuKilepes_Click);
			// 
			// mnuSutemenyek
			// 
			this.mnuSutemenyek.Enabled = false;
			this.mnuSutemenyek.Name = "mnuSutemenyek";
			this.mnuSutemenyek.Size = new System.Drawing.Size(84, 20);
			this.mnuSutemenyek.Text = "Sütemények";
			this.mnuSutemenyek.Click += new System.EventHandler(this.mnuSutemenyek_Click);
			// 
			// mnuNevjegy
			// 
			this.mnuNevjegy.Name = "mnuNevjegy";
			this.mnuNevjegy.Size = new System.Drawing.Size(62, 20);
			this.mnuNevjegy.Text = "Névjegy";
			this.mnuNevjegy.Click += new System.EventHandler(this.mnuNevjegy_Click);
			// 
			// picDesszert
			// 
			this.picDesszert.Location = new System.Drawing.Point(70, 47);
			this.picDesszert.Name = "picDesszert";
			this.picDesszert.Size = new System.Drawing.Size(300, 300);
			this.picDesszert.TabIndex = 1;
			this.picDesszert.TabStop = false;
			// 
			// ofd
			// 
			this.ofd.FileName = "openFileDialog1";
			// 
			// frmCukraszda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 383);
			this.Controls.Add(this.picDesszert);
			this.Controls.Add(this.mnuMenusor);
			this.MainMenuStrip = this.mnuMenusor;
			this.Name = "frmCukraszda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cukrászda";
			this.Load += new System.EventHandler(this.Cukraszda_Load);
			this.mnuMenusor.ResumeLayout(false);
			this.mnuMenusor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picDesszert)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMenusor;
		private System.Windows.Forms.ToolStripMenuItem mnuFajl;
		private System.Windows.Forms.ToolStripMenuItem mnuMegnyitas;
		private System.Windows.Forms.ToolStripMenuItem mnuKilepes;
		private System.Windows.Forms.ToolStripMenuItem mnuSutemenyek;
		private System.Windows.Forms.ToolStripMenuItem mnuNevjegy;
		private System.Windows.Forms.PictureBox picDesszert;
		private System.Windows.Forms.OpenFileDialog ofd;
	}
}

