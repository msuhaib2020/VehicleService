using ERP_POC.Models.Enum;
using ERP_POC.UOW.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_POC.UOW.Repository
{
    public class CommonRepository : ICommonRepository
    {
        public List<SelectListItem> RoleDropDown()
        {
           return Enum.GetValues(typeof(RoleEnum)).Cast<RoleEnum>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();
        }
    }
}