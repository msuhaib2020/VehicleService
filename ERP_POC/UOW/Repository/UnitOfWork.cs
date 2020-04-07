using ERP_POC.Models.EF;
using ERP_POC.UOW.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_POC.UOW.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ERP_DBEntities db;
         public IUserLogInRepository UserLogIns { get; set; }
        public IVendorRepository Vendors { get; set; }
        public UnitOfWork(ERP_DBEntities context)
        {
            db = context;
            UserLogIns = new UserLogInRepository(db);
            Vendors = new VendorRepository(db);
        }
         


        public int SaveChanges()
        {
            return db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }

        



          
    }
}