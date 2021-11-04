using AppCore.Interfaces;
using AppCore.Services;
using AppTemperatura.Formularios;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTemperatura
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<RegistroDataRepository>().As<IRegistroData>();
			builder.RegisterType<RegistroDataService>().As<IRegistroDataService>();

			var container = builder.Build();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmTemperatura(container.Resolve<IRegistroDataService>()));
		}
	}
}
