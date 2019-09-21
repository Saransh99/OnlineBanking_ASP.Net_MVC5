using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Controllers
{
    public class FundTransferController : Controller
    {
        // GET: FundTransfer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Neft() {

            return View();
        }
        public ActionResult Rtgs() {

            return View();
        }

    }
}