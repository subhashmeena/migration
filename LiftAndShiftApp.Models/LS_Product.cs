//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiftAndShiftApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LS_Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
