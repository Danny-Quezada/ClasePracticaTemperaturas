using AppTemperatura.Properties;
using Infraestructure.Factory;
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
	public partial class FrmConversion : Form
	{
		private double Valor;
		private int Temp;
		private int TempC;
		public FrmConversion(double valor, int temp,int tempC)
		{

			this.Valor = valor;
			this.Temp = temp;
			this.TempC = tempC;

			InitializeComponent();
		}

		private void FrmConversion_Load(object sender, EventArgs e)
		{
			if (Temp == 0)
			{
				pbTemp.Image = Properties.Resources.farenheit;
			}
			else if (Temp == 1)
			{
				pbTemp.Image = Properties.Resources.celsius;
			}
			else if (Temp == 2)
			{
				pbTemp.Image = Properties.Resources.kelvin;
			}
			if (TempC == 0)
			{
				pbTempC.Image = Properties.Resources.farenheit;
			}
			else if (TempC == 1)
			{
				pbTempC.Image = Properties.Resources.celsius;
			}
			else if (TempC == 2)
			{
				pbTempC.Image = Properties.Resources.kelvin;
			}
			llbNumero.Text = Convert.ToString(FactoryMethod.CreateInstance(Temp).CalculateTemperature(Valor, TempC));
		}

		private void llbNumero_Click(object sender, EventArgs e)
		{

		}

		private void btnConvertir_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
