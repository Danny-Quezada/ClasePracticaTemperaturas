using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class DataGridInformation
	{
		public int Numero_Operacion { get; set; }
		public Temperaturas Unidad_Medida_Original { get; set; }
		public double Temperatura_Original { get; set; }
		public Temperaturas Unidad_Medida_Convertida { get; set; }
		public double Temperatura_Convertida { get; set; }
	}
}
