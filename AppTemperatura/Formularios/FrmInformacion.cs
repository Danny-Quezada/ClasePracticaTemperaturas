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
	public partial class FrmInformacion : Form
	{
		public FrmInformacion()
		{
			InitializeComponent();
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FrmInformacion_Load(object sender, EventArgs e)
		{
			guna2DataGridView1.Rows.Add("Celsius", 22, "Kelvin", 333);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
