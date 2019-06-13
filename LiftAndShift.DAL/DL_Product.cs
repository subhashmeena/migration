using System.Collections.Generic;
using System.Linq;
using LiftAndShiftApp.Models;
using LiftAndShiftApp.Models.Models;

namespace LiftAndShift.DAL
{
    public class DL_Product
    {
        public void AddProduct(ProductModel product)
        {
            LS_Product productEntity = new LS_Product();

            productEntity.ImagePath = product.ImagePath;
            productEntity.Name = product.Name;
            productEntity.Price = product.Price;
            productEntity.Description = product.Description;

            using (DBDVEntities db = new DBDVEntities())
            {
                db.LS_Product.Add(productEntity);
                db.SaveChanges();
            }
        }

        public bool DeleteProduct(int productId)
        {
            using (DBDVEntities db = new DBDVEntities())
            {
                var result = db.LS_Product.SingleOrDefault(b => b.id == productId);

                if (result != null)
                {
                    result.IsDeleted = true;
                    db.SaveChanges();

                    return true;
                }

                return false;
            }
        }

        public List<LS_Product> GetAllProducts()
        {
            using (DBDVEntities db = new DBDVEntities())
            {
                var result = db.LS_Product.ToList();
                return result;
            }           
        }
    }
}
