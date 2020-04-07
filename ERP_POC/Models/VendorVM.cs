using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_POC.Models
{
    public class VendorVM
    {

        public VendorCreateVM Vendor { get; set; } = new VendorCreateVM();
        public List<VendorListVM> Vendors { get; set; } = new List<VendorListVM>();

    }

    public class VendorCreateVM
    {
        public int VendorId { get; set; }

  
        public string VendorName { get; set; }
 
        public int PhoneNumber { get; set; }
    }

    public class VendorListVM : VendorCreateVM
    {
    }
}