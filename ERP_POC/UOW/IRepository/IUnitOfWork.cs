using ERP_POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_POC.UOW.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserLogInRepository UserLogIns { get; }
        IVendorRepository Vendors { get; }
        int SaveChanges();
      }  
}
