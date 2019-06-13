using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LiftAndShift.BAL;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShiftWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrdersManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrdersManagement.svc or OrdersManagement.svc.cs at the Solution Explorer and start debugging.
    public class OrdersManagement : IOrdersManagement
    {
        public void DoWork()
        {
        }

        public string CreateOrder(List<ProductModel> Products)
        {
            Order order = new Order();
            order.CreateOrder(Products);
            Console.WriteLine("In CreateOrder()");
            return "In CreateOrder()";
        }
    }
}
