using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class RegistroDataService : IRegistroDataService
    {
        private IRegistroData registroData;

        public RegistroDataService(IRegistroData registroData)
        {
            this.registroData = registroData;
        }

        public void Add(DataGridInformation e)
        {
            registroData.Add(e);
        }

        public DataGridInformation[] FindAll()
        {
            return registroData.FindAll();
        }

        public int GetLastId()
        {
            return registroData.GetLastId();
        }
    }
}
