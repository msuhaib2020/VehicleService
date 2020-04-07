using ERP_POC.Models;
using ERP_POC.UOW.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_POC.Helper;

namespace ERP_POC.Controllers
{
    public class VendorController : Controller
    {

        private IUnitOfWork UOW;

        public VendorController(IUnitOfWork _UOW)
        {
            UOW = _UOW;
        }


        // GET: Vendor
        public ActionResult Index1()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Index()
        { 
            VendorVM Vendor = new VendorVM();
            Vendor.Vendors= UOW.Vendors.GetAllVendors();
             
            return View(Vendor);
        }
        [HttpGet]
        public ActionResult List()
        {
             return PartialView(UOW.Vendors.GetAllVendors());
        }
        [HttpGet]
        public ActionResult Create()
        {
            try
            {
                VendorCreateVM VendorCreateVM = new VendorCreateVM();
           
                return PartialView(VendorCreateVM);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Create(VendorCreateVM VendorCreateVM)
        {
            try
            {
                AjaxResponse AjaxResponse = UOW.Vendors.Insert(VendorCreateVM);
            UOW.SaveChanges();

            return Json(AjaxResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            try
            {
                return PartialView("Create", UOW.Vendors.GetByVendor(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
             try
            {

                AjaxResponse AjaxResponse = UOW.Vendors.DeleteByVendor(id);
                UOW.SaveChanges();
                return Json(AjaxResponse);
            }
            catch(Exception ex)
            { 
                throw ex;
            }
            
        }
    }
}