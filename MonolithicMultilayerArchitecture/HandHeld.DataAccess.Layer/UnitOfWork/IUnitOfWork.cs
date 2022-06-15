using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHeld.DataAccess.Layer.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Dispose();
        void SaveChanges();
    }
}
