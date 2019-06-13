using System;
using System.Collections.Generic;
using LiftAndShift.BAL.Interface;
using LiftAndShift.DAL;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.BAL
{
    public class Product : IProduct
    {
        public bool AddProduct(ProductModel product)
        {
            try
            {
                DL_Product dlProduct = new DL_Product();
                dlProduct.AddProduct(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }

        public bool DeleteProduct(ProductModel product)
        {
            try
            {
                DL_Product dlProduct = new DL_Product();

                dlProduct.DeleteProduct(product.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
               
                return false;
            }
            return true;
        }

        public List<ProductModel> GetAllProducts()
        {
            try
            {
                DL_Product dlProduct = new DL_Product();
                var productEntityList = dlProduct.GetAllProducts();

                List<ProductModel> productModels = new List<ProductModel>();

                foreach (var product in productEntityList)
                {
                    productModels.Add(new ProductModel { ImagePath = product.ImagePath, Description = product.Description, Name = product.Name, Price = product.Price });
                }

                return productModels;
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
           
        }
    }
}
