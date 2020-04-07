using AutoMapper;
using ERP_POC.Models;
using ERP_POC.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_POC.App_Start
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<List<Vendor>, List<VendorListVM>>();
        }
    }
}