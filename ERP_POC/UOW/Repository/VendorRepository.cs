using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERP_POC.UOW.IRepository;
using System.Linq.Expressions;
using ERP_POC.Models;
using ERP_POC.Models.EF;
using ERP_POC.Helper;
using AutoMapper;
 

namespace ERP_POC.UOW.Repository
{
    public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
    {
         private readonly ERP_DBEntities db;
         public VendorRepository(ERP_DBEntities context) : base(context)
         {
             db = context;
         }
         
        public AjaxResponse Insert(VendorCreateVM VendorCreateVM)
        {
            AjaxResponse AjaxResponse = new AjaxResponse();

            IsDuplicate(ref AjaxResponse, VendorCreateVM);

            //Message Type  means no warning no error
            if (AjaxResponse.MessageType == 0)
            {
                Vendor Vendor = new Vendor();

                Vendor.VendorId = VendorCreateVM.VendorId;
                Vendor.VendorName = VendorCreateVM.VendorName;
                Vendor.PhoneNumber = VendorCreateVM.PhoneNumber;
                Vendor.CreatedBy = "Admin_1";
                Vendor.ModifiedBy = "Admin_1";
                Vendor.ModifiedDate = DateTime.UtcNow;



                if (Vendor.VendorId != 0)
                {
                    Update(Vendor.VendorId, Vendor);
                    AjaxResponse.Message = "Vendor " + SysMessage.Update;
                }
                else
                {
                    Vendor.CreatedDate = DateTime.UtcNow;
                    
                    Add(Vendor);
                    AjaxResponse.Message = "Vendor " + SysMessage.Create; 
                }

            }

            return AjaxResponse;

        }

        public List<VendorListVM> GetAllVendors()
        { 
            return  GetAll().Select( o => new VendorListVM {
                VendorId=o.VendorId,
                VendorName = o.VendorName,
                PhoneNumber =o.PhoneNumber,
            }).ToList();
                
        }

        public VendorCreateVM GetByVendor(int id)
        {
            Vendor Vendor = Get(id);

            return  new VendorCreateVM {
                VendorId= Vendor.VendorId,
                VendorName = Vendor.VendorName,
                PhoneNumber = Vendor.PhoneNumber,
            } ;
        }

        public AjaxResponse DeleteByVendor(int id)
        {
            Vendor Vendor = Get(id);
            AjaxResponse AjaxResponse = new AjaxResponse();
            IsRelation(ref AjaxResponse, Vendor);

            if (AjaxResponse.MessageType == 0)
            {
                Remove(Vendor);
                AjaxResponse.Message= "Vendor " + SysMessage.Delete;
            }
             
            return AjaxResponse;
        }


        private void IsDuplicate(ref AjaxResponse AjaxResponse, VendorCreateVM VMobj)
        {
            Vendor Vendor = new Vendor();

            //Update mode
            if (VMobj.VendorId != 0)
            {
                Vendor = GetAll().Where(o => o.VendorId != VMobj.VendorId && o.VendorName == VMobj.VendorName
                && o.PhoneNumber == VMobj.PhoneNumber).FirstOrDefault();

            }
            else
            {
                Vendor = GetAll().Where(o => o.VendorName == VMobj.VendorName && o.PhoneNumber == VMobj.PhoneNumber).FirstOrDefault();
            }

            if (Vendor != null)
            {
                AjaxResponse.MessageType = (int)MessageType.Error;
                if (Vendor.VendorName == VMobj.VendorName) AjaxResponse.Message = " Name " + SysMessage.RecordExsiting;

                if (Vendor.PhoneNumber == VMobj.PhoneNumber)
                {
                    if (AjaxResponse.Message.Length > 0) AjaxResponse.Message += " , ";

                    AjaxResponse.Message = "Mobile Number" + SysMessage.RecordExsiting;
                }
            }

        }


        public void IsRelation(ref AjaxResponse AjaxResponse, Vendor Vendor)
        {  
             
        }

    }
}  
