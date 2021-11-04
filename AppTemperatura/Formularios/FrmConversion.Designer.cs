
namespace AppTemperatura.Formularios
{
	partial class FrmConversion
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConversion));
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.pbTempC = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pbTemp = new System.Windows.Forms.PictureBox();
			this.lblConversion = new System.Windows.Forms.Label();
			this.llbNumero = new System.Windows.Forms.Label();
			this.btnConvertir = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)(this.pbTempC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTemp)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 20;
			this.guna2BorderlessForm1.ContainerControl = this;
			// 
			// pbTempC
			// 
			this.pbTempC.Location = new System.Drawing.Point(169, 43);
			this.pbTempC.Name = "pbTempC";
			this.pbTempC.Size = new System.Drawing.Size(78, 82);
			this.pbTempC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTempC.TabIndex = 2;
			this.pbTempC.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(95, 43);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(60, 82);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pbTemp
			// 
			this.pbTemp.Location = new System.Drawing.Point(3, 43);
			this.pbTemp.Name = "pbTemp";
			this.pbTemp.Size = new System.Drawing.Size(78, 82);
			this.pbTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTemp.TabIndex = 0;
			this.pbTemp.TabStop = false;
			// 
			// lblConversion
			// 
			this.lblConversion.AutoSize = true;
			this.lblConversion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConversion.ForeColor = System.Drawing.Color.Gray;
			this.lblConversion.Location = new System.Drawing.Point(67, 169);
			this.lblConversion.Name = "lblConversion";
			this.lblConversion.Size = new System.Drawing.Size(111, 25);
			this.lblConversion.TabIndex = 3;
			this.lblConversion.Text = "Conversión:";
			// 
			// llbNumero
			// 
			this.llbNumero.AutoSize = true;
			this.llbNumero.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llbNumero.ForeColor = System.Drawing.Color.Gray;
			this.llbNumero.Location = new System.Drawing.Point(55, 222);
			this.llbNumero.Name = "llbNumero";
			this.llbNumero.Size = new System.Drawing.Size(156, 37);
			this.llbNumero.TabIndex = 4;
			this.llbNumero.Text = "Conversión:";
			this.llbNumero.Click += new System.EventHandler(this.llbNumero_Click);
			// 
			// btnConvertir
			// 
			this.btnConvertir.BorderRadius = 20;
			this.btnConvertir.CheckedState.Parent = this.btnConvertir;
			this.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConvertir.CustomImages.Parent = this.btnConvertir;
			this.btnConvertir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnConvertir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnConvertir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnConvertir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnConvertir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnConvertir.DisabledState.Parent = this.btnConvertir;
			this.btnConvertir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
			this.btnConvertir.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
			this.btnConvertir.FocusedColor = System.Drawing.Color.White;
			this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnConvertir.ForeColor = System.Drawing.Color.White;
			this.btnConvertir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
			this.btnConvertir.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
			this.btnConvertir.HoverState.Parent = this.btnConvertir;
			this.btnConvertir.Location = new System.Drawing.Point(87, 286);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.ShadowDecoration.Parent = this.btnConvertir;
			this.btnConvertir.Size = new System.Drawing.Size(68, 45);
			this.btnConvertir.TabIndex = 16;
			this.btnConvertir.Text = "OK";
			this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
			// 
			// FrmConversion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(250, 358);
			this.Controls.Add(this.btnConvertir);
			this.Controls.Add(this.llbNumero);
			this.Controls.Add(this.lblConversion);
			this.Controls.Add(this.pbTempC);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pbTemp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmConversion";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmConversion";
			this.Load += new System.EventHandler(this.FrmConversion_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbTempC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTemp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private System.Windows.Forms.PictureBox pbTempC;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pbTemp;
		private System.Windows.Forms.Label lblConversion;
		private System.Windows.Forms.Label llbNumero;
		private Guna.UI2.WinForms.Guna2GradientButton btnConvertir;
	}
}