using ERP_POC.Helper;
using ERP_POC.Models;
using ERP_POC.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_POC.UOW.IRepository
{
    public interface IVendorRepository 
    {
        AjaxResponse Insert(VendorCreateVM VendorCreateVM);
        List<VendorListVM> GetAllVendors();
        VendorCreateVM GetByVendor(int id);
        AjaxResponse DeleteByVendor(int id);
    }
}