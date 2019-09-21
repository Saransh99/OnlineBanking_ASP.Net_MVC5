using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddBranchManager() {

            return View();
        }
        public ActionResult DeleteBranchManager() {

            return View();
        }
        public ActionResult EditBranchManager() {

            return View();
        }
    }
}