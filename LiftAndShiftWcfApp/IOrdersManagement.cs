using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShiftWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrdersManagement" in both code and config file together.
    [ServiceContract]
    public interface IOrdersManagement
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string CreateOrder(List<ProductModel> products);
    }
}
