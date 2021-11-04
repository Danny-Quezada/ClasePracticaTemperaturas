using AppCore.Interfaces;
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
		private IRegistroDataService registroDataService;
		public FrmInformacion(IRegistroDataService registroDataService)
		{
			this.registroDataService = registroDataService;
			InitializeComponent();
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FrmInformacion_Load(object sender, EventArgs e)
		{

			guna2DataGridView1.DataSource = registroDataService.FindAll();
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
