using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHeld.Business.Layer.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<object> GetProducts();
    }
}
