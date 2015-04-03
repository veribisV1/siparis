﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using siparis.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
namespace siparis.Controllers
{
    public class BaseController : Controller
    {
        public void checkCart()
        {
            siparis.Models.VdbSoftEntities db = new VdbSoftEntities();
            int sepetID = (from d in db.OPPORTUNITYMASTERs
                           where d.OPEN_CLOSE == 0 && d.APPOINTED_USER_CODE == 1// user ID gelmeli Fix Me
                           select d.OPPORTUNITY_CODE).FirstOrDefault();
            Session.Add("Sepet", sepetID);

        }
        public IEnumerable<OPPORTUNITYDETAIL> getCartProduct()
        {
            siparis.Models.VdbSoftEntities db = new VdbSoftEntities();
            var model = from d in db.OPPORTUNITYDETAILs
                        join master in db.OPPORTUNITYMASTERs on d.OPPORTUNITY_CODE equals master.OPPORTUNITY_CODE
                        where master.OPEN_CLOSE == 0 && master.APPOINTED_USER_CODE == 1
                        select d;
            return model;
        }
        public static STOKCARD getProduct(int ID = 1)
        {
            siparis.Models.VdbSoftEntities db = new VdbSoftEntities();
            STOKCARD st = (from d in db.STOKCARDs
                           where d.ID == ID
                           select d).FirstOrDefault();
            return st;
        }

        public static IEnumerable<STOKCARD> getProductAll()
        {
            siparis.Models.VdbSoftEntities db = new VdbSoftEntities();
            var model = from d in db.STOKCARDs
                        select d;
            return model;
        }
    }
}