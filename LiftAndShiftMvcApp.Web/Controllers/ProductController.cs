using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LiftAndShiftApp.Models.Models;
using LiftAndShiftMvcApp.Web.Helper;
using LiftAndShiftMvcApp.Web.ProductServiceReference;
using LiftAndShiftMvcApp.Web.Service;
using LiftAndShiftMvcApp.Web.ServiceReferenceIIS;

namespace LiftAndShiftMvcApp.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductManagementClient clientProduct = new ProductManagementClient();
        //ServiceReferenceIIS.OrdersManagementClient c = new OrdersManagementClient();

        // GET: Product
        public ActionResult Add()
        {            
            return View();
            
        }

        [HttpPost]
        public async Task<ActionResult> Add(ProductModel productModel)
        {

            ImageService imageService = new ImageService();

            productModel.ImagePath = await imageService.UploadImageAsync(productModel.ImageFile);

            string fileName = Path.GetFileNameWithoutExtension(productModel.ImageFile.FileName);
            //string extn = Path.GetExtension(productModel.ImageFile.FileName);
            //fileName = fileName + DateTime.Now.ToString("yymmssfff") + extn;
            //string url = ConfigurationManager.AppSettings["path"];
            //productModel.ImagePath = url + fileName;
            //fileName = Path.Combine(Server.MapPath(url), fileName);
            //productModel.ImageFile.SaveAs(fileName);


            clientProduct.AddProduct(productModel);


            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ActionResult ViewList()
        {
            var products = clientProduct.GetAllProducts();
            return View(products);
        }



    }
}