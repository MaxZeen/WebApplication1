using Max.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Redis;

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

        public ActionResult RedisStudy()
        {


            //var client = new RedisClient("127.0.0.1", 6379);
             var client = new RedisClient("10.55.160.168", 6379);
            client.Set<int>("pwd", 1111);
            int pwd = client.Get<int>("pwd");

            //UserInfo userInfo = new UserInfo() { UserName = "zhangsan", UserPwd = "1111" };//</span>(底层使用json序列化 )  
            //client.Set<UserInfo>("userInfo", userInfo);
            //UserInfo user = client.Get<UserInfo>("userInfo");
            //Console.WriteLine(user.UserName);

            //List<UserInfo> list = new List<UserInfo>() { new UserInfo() { UserName = "lisi", UserPwd = "111" }, new UserInfo() { UserName = "wangwu", UserPwd = "123" } };
            //client.Set<List<UserInfo>>("list", list);
            //List<UserInfo> userInfoList = client.Get<List<UserInfo>>("list");

            //foreach (UserInfo userInfo in userInfoList)
            //{
            //    Console.WriteLine(userInfo.UserName);
            //}

            return View();
        }
    }
}