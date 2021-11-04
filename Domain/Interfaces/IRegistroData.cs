using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRegistroData
    {
        int GetLastId();
        void Add(DataGridInformation e);
        DataGridInformation[] FindAll();
    }
}
