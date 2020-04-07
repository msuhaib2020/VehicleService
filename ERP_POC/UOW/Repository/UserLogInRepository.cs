using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERP_POC.UOW.IRepository;
using System.Linq.Expressions;
using ERP_POC.Models;
using ERP_POC.Models.EF;

namespace ERP_POC.UOW.Repository
{
    public class UserLogInRepository : GenericRepository<UserLogIn>, IUserLogInRepository
    {
         private readonly ERP_DBEntities db;
         public UserLogInRepository(ERP_DBEntities context) : base(context)
         {
             db = context;
         }
          
    }
}  
