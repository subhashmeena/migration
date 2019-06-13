using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LiftAndShift.BAL;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductManagement.svc or ProductManagement.svc.cs at the Solution Explorer and start debugging.
    public class ProductManagement : IProductManagement
    {
        public bool AddProduct(ProductModel productModel)
        {
            Product product = new Product();
            product.AddProduct(productModel);
            Console.WriteLine("In AddProduct()");
            
            return true;
        }

        public bool DeleteProduct(ProductModel productModel)
        {
            Product product = new Product();
            product.DeleteProduct(productModel);
            Console.WriteLine("In DeleteProduct()");
            return true;
        }

        public List<ProductModel> GetAllProducts()
        {
            Product product = new Product();
            var products = product.GetAllProducts();
            Console.WriteLine("In GetAllProducts()");
            return products;
        }
        public void DoWork()
        {
        }
    }
}
