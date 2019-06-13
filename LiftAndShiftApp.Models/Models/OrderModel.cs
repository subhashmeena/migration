using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftAndShiftApp.Models.Models
{
    public class OrderModel
    {
        public string Id { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
