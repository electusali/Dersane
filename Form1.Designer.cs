namespace DersaneDeneme
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbxSifre = new System.Windows.Forms.TextBox();
			this.lblKadi = new System.Windows.Forms.Label();
			this.tbxKadi = new System.Windows.Forms.TextBox();
			this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(33, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 19);
			this.label1.TabIndex = 15;
			this.label1.Text = "Kullanici Şifre";
			// 
			// tbxSifre
			// 
			this.tbxSifre.Location = new System.Drawing.Point(165, 220);
			this.tbxSifre.Name = "tbxSifre";
			this.tbxSifre.Size = new System.Drawing.Size(169, 20);
			this.tbxSifre.TabIndex = 14;
			// 
			// lblKadi
			// 
			this.lblKadi.AutoSize = true;
			this.lblKadi.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lblKadi.Location = new System.Drawing.Point(41, 136);
			this.lblKadi.Name = "lblKadi";
			this.lblKadi.Size = new System.Drawing.Size(96, 19);
			this.lblKadi.TabIndex = 13;
			this.lblKadi.Text = "Kullanici Adi";
			// 
			// tbxKadi
			// 
			this.tbxKadi.Location = new System.Drawing.Point(165, 138);
			this.tbxKadi.Name = "tbxKadi";
			this.tbxKadi.Size = new System.Drawing.Size(169, 20);
			this.tbxKadi.TabIndex = 12;
			// 
			// btnGiris
			// 
			this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.btnGiris.Appearance.Options.UseFont = true;
			this.btnGiris.Location = new System.Drawing.Point(190, 283);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(89, 40);
			this.btnGiris.TabIndex = 11;
			this.btnGiris.Text = "GİRİŞ";
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 443);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxSifre);
			this.Controls.Add(this.lblKadi);
			this.Controls.Add(this.tbxKadi);
			this.Controls.Add(this.btnGiris);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxSifre;
		private System.Windows.Forms.Label lblKadi;
		private System.Windows.Forms.TextBox tbxKadi;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
	}
}

