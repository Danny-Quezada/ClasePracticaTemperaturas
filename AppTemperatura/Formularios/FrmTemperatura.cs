using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infraestructure.Factory;
using Infraestructure.Repository;
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
		private IRegistroDataService registroData;
		public FrmTemperatura(IRegistroDataService registroData)
		{
			RegistroDataRepository Inicializador = new RegistroDataRepository();
			this.registroData = registroData;
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
			FrmInformacion Informacion = new FrmInformacion(registroData);
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
			DataGridInformation dataGridInformation = new DataGridInformation
			{
				Numero_Operacion = registroData.GetLastId() + 1,
				Unidad_Medida_Original = (Temperaturas)cmbTiposTempe.SelectedIndex,
				Temperatura_Original = double.Parse(txtTemp.Text),
				Unidad_Medida_Convertida = (Temperaturas)cmbConvertir.SelectedIndex,
				Temperatura_Convertida = FactoryMethod.CreateInstance(cmbTiposTempe.SelectedIndex).CalculateTemperature(double.Parse(txtTemp.Text), cmbConvertir.SelectedIndex),
			};
			registroData.Add(dataGridInformation);
			FrmConversion Conversion = new FrmConversion(double.Parse(txtTemp.Text), cmbTiposTempe.SelectedIndex, cmbConvertir.SelectedIndex);
			Conversion.ShowDialog();
			txtTemp.Text = "";
			cmbTiposTempe.Text = null;
			cmbConvertir.Text = null;
		}

        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
		(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}
    }
}
