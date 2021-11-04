using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RegistroDataRepository : IRegistroData
    {
        private List<DataGridInformation> Data;

        public RegistroDataRepository()
        {
            Data = new List<DataGridInformation>();
        }

        public void Add(DataGridInformation e)
        {
            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            Data.Add(e);
        }

        public DataGridInformation[] FindAll()
        {
            return Data.ToArray();
        }

        public int GetLastId()
        {
            if (Data.Count == 0)
            {
                return 0;
            }
            DataGridInformation temp = Data.FindLast(O => O.Numero_Operacion > 0);
            return temp.Numero_Operacion;
        }
    }
}
