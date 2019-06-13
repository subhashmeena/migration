using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductManagement" in both code and config file together.
    [ServiceContract]
    public interface IProductManagement
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        bool AddProduct(ProductModel product);
        [OperationContract]
        bool DeleteProduct(ProductModel product);
        [OperationContract]
        List<ProductModel> GetAllProducts();
    }
}
