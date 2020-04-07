using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_POC.UOW.IRepository
{
    public interface ICommonRepository
    {

        List<SelectListItem> RoleDropDown(); 

    }
}