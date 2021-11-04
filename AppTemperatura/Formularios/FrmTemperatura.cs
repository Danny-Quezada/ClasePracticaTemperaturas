using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTemperatura.Formularios
{
	public partial class FrmTemperatura : Form
	{
		public FrmTemperatura()
		{
			InitializeComponent();
		}

		private void FrmTemperatura_Load(object sender, EventArgs e)
		{
			cmbConvertir.Items.AddRange(Enum.GetValues(typeof(Temperaturas)).Cast<object>().ToArray());
			cmbTiposTempe.Items.AddRange(Enum.GetValues(typeof(Temperaturas)).Cast<object>().ToArray());
		}

		private void txtTemp_TextChanged(object sender, EventArgs e)
		{

		}

		private void cmbTiposTempe_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}
		private void VerificarCmb()
		{
			if (cmbConvertir.SelectedIndex == cmbTiposTempe.SelectedIndex)
			{

				if (cmbTiposTempe.SelectedIndex == (cmbConvertir.Items.Count-1))
				{
					cmbConvertir.SelectedIndex = cmbTiposTempe.SelectedIndex - 1;
				}
				else if (cmbTiposTempe.SelectedIndex == (cmbConvertir.Items.Count - cmbConvertir.Items.Count))
				{
					cmbConvertir.SelectedIndex = cmbTiposTempe.SelectedIndex + 1;
				}
				else
				{
					cmbConvertir.SelectedIndex = cmbTiposTempe.SelectedIndex + 1;
				}

			}
		}

		
		private void FrmTemperatura_MinimumSizeChanged(object sender, EventArgs e)
		{
			
		
		}

		private void FrmTemperatura_SizeChanged(object sender, EventArgs e)
		{
			
		}



		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			FrmInformacion Informacion = new FrmInformacion();
			Informacion.ShowDialog();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void cmbTiposTempe_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			VerificarCmb();
		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cmbConvertir_SelectedIndexChanged(object sender, EventArgs e)
		{
			VerificarCmb();
		}

		private void btnConvertir_Click(object sender, EventArgs e)
		{


			string original= Convertidor(cmbTiposTempe.SelectedIndex);
			string conversion = Convertidor(cmbConvertir.SelectedIndex);
			FrmConversion Conversion = new FrmConversion(22,0,1);
			Conversion.ShowDialog();	
		}
		private string Convertidor(int i)
		{
			var a= (Temperaturas)i;
			string nombre = a.ToString();
			return nombre;
		}
	}
}
