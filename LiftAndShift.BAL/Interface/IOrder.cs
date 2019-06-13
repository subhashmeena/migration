using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.BAL.Interface
{
    public interface IOrder
    {
        string CreateOrder(List<ProductModel> products);
    }
}
