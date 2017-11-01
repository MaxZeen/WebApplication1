using Max.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Views.Test
{
    public class TestController : Controller
    {
        // GET: Test
        [AllowAnonymous]
        public ActionResult Angularjs()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult NgTable()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult StTable()
        {
            return View();
        }

        public JsonResult GetLicensensList()
        {
            AngularDAL da = new AngularDAL();
            var items = da.GetLicensensList();
          //  var jsonstr= JsonConvert.SerializeObject(items);
            return Json(new { data= items.ToArray() }, JsonRequestBehavior.AllowGet);
        }
    }
}