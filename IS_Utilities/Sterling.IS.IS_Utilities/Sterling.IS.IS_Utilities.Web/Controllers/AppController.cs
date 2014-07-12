using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sterling.IS.Utilities.ServiceAgent.Manager;
using Sterling.IS.Utilities.ServiceAgent.Entities;
using Sterling.IS.Utilities.Web.ViewModels;

namespace Sterling.IS.Utilities.Web.Controllers
{
    public class AppController : Controller
    {
        //
        // GET: /App/

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _AppForm(Application app)
        {
           
            return PartialView("_AppForm", app);
        }

        public PartialViewResult _Edit(int id)
        {
            var app = new ApplicationManager().GetApplicationById(id);
            return PartialView("_Edit", app);
        }

        public ActionResult _CreateNewSection(Section section)
        {
            var appMgr = new ApplicationManager();
            var viewmodel = new AppsViewModel();
            appMgr.InsertSection(section);
            viewmodel.Application = appMgr.GetApplicationById(section.ApplicationId);

            return RedirectToAction("Apps", new { id = section.ApplicationId });
        }
        
        public ActionResult _UpdateSection(Section section)
        {
            var appMgr = new ApplicationManager();
            var viewmodel = new AppsViewModel();
            appMgr.UpdateSection(section);
            viewmodel.Application = appMgr.GetApplicationById(section.ApplicationId);

            return RedirectToAction("Apps", new { id = section.ApplicationId });

        }
        public PartialViewResult _Delete(int id)
        {
            var app = new ApplicationManager().GetApplicationById(id);
            return PartialView("_Delete", app);
        }
        public PartialViewResult _DeleteConfirmed(Application app)
        {
            var appMgr = new ApplicationManager();
            appMgr.DeleteApplication(app.ID);
            var apps = appMgr.GetApplications();
            return PartialView("_GetApps", apps); 
        }
         [ValidateAntiForgeryToken]
        public PartialViewResult _Update(Application app)
        {
             var appMgr= new ApplicationManager();
             
            if (!ModelState.IsValid)
            {
                var appsOld = appMgr.GetApplications();
                return PartialView("_GetApps", appsOld);
            }
            appMgr.UpdateApplication(app);
            var apps = appMgr.GetApplications();
            return PartialView("_GetApps", apps);
        }
        [ValidateAntiForgeryToken]
        public PartialViewResult _Submit(Application app)
        {
           
           var appMgr= new ApplicationManager();

           
           if (!ModelState.IsValid)
           {
               var appsOld = appMgr.GetApplications();
               return PartialView("_GetApps", appsOld);
           }
           appMgr.CreateApplication(app);
           var apps = appMgr.GetApplications();
           
           return PartialView("_GetApps", apps);
        }
        public PartialViewResult _Create()
        {
            var app = new Application();

            return PartialView("_Create", app);
        }
        public PartialViewResult _GetApps(List<Application> apps)
        {
          
            return PartialView("_GetApps", apps);
        }
             // GET: /App/Apps/id
        public ActionResult Apps(int id)
        {
            var appsViewModel = new AppsViewModel();
            var appMgr = new ApplicationManager();
            appsViewModel.Application = appMgr.GetAppById(id);
            appsViewModel.AppUtilities = appsViewModel.Application.Utilities;
            return View(appsViewModel);
        }

        
    }
}
