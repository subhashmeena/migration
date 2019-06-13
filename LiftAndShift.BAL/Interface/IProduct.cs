using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.BAL.Interface
{
    interface IProduct
    {
        bool AddProduct(ProductModel products);
        bool DeleteProduct(ProductModel products);
    }
}
