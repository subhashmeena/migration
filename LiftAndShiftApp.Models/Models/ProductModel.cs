using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LiftAndShiftApp.Models.Models
{
    [DataContract]
    public class ProductModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }
        [DataMember]
        public Nullable<decimal> Price { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public Nullable<bool> IsDeleted { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
    }

    public class ProductViewModel
    {
        List<ProductModel> Products { get; set; }        
    }
}
