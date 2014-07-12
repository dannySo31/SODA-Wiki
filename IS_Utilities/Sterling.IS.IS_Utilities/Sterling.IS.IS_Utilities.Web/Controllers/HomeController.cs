using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sterling.IS.Utilities.Web.ViewModels;
using Sterling.IS.Utilities.ServiceAgent.Manager;

namespace Sterling.IS.Utilities.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            var appMgr=new ApplicationManager();
            homeViewModel.Applications = appMgr.GetApplications();
           
            return View(homeViewModel);
        }
       

    }
}
