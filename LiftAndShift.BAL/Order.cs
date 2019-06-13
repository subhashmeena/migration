using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftAndShift.BAL.Interface;
using LiftAndShift.DAL;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.BAL
{
    public class Order : IOrder
    {
        public string CreateOrder(List<ProductModel> products)
        {
            try
            {
                DL_Order dlOrder = new DL_Order();

                string id = Guid.NewGuid().ToString();

                foreach (var product in products)
                {
                    dlOrder.AddOrder(product, id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "false";
            }
          
           return "true";
        }
    }
}
