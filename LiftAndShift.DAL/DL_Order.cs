using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftAndShiftApp.Models;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.DAL
{
    public class DL_Order
    {
        public void AddOrder(ProductModel product, string id)
        {
            LS_Orders order = new LS_Orders();
            order.Id = id;
            order.ProductId = product.Id;
            order.Quantity = product.Quantity;
            order.Total = product.Quantity * product.Price;            

            using (DBDVEntities db = new DBDVEntities())
            {
                db.LS_Orders.Add(order);
                db.SaveChanges();
            }            
        }
    }
}
