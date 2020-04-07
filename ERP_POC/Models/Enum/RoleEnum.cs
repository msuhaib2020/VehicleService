using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_POC.Models.Enum
{
    public enum RoleEnum
    {
        [Display(Name = "Super Admin")]
        SuperAdmin = 1,

        [Display(Name = "Admin")]
        Admin = 2,

        [Display(Name = "Manager")]
        Manager = 3,
    }
}