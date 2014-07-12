using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sterling.IS.Utilities.Web.ViewModels;
using Sterling.IS.Utilities.ServiceAgent.Manager;
using Sterling.IS.Utilities.ServiceAgent.Entities;
using System.IO;

namespace Sterling.IS.Utilities.Web.Controllers
{
    public class DevelopersController : Controller
    {
       
        //
        // GET: /Developers/
        public delegate void DevFunctionDelegate(Owner owner, ref ApplicationManager appMgr, List<int> lstApps);
        public ActionResult Index()
        {
            var viewModel = new DevelopersViewModel();
            var manager = new ApplicationManager();
            viewModel.Developers = manager.GetOwners();
            return View(viewModel);
        }
        //
        // GET: /Developers/Profile/{id}
        public ActionResult Profile(int id)
        {
           
            return View(new ApplicationManager().GetOwnerById(id));
        }

        public PartialViewResult _DevForm(_OwnerFormViewModel viewModel)
        {
            if (String.IsNullOrEmpty(viewModel.Developer.Pic))
                viewModel.Developer.Pic = "~/Images/profile-blank.jpg";
            return PartialView("_DevForm", viewModel);
        }
        public PartialViewResult _GetAllDevelopers(List<Owner> devs)
        {
            
            return PartialView("_GetAllDevelopers", devs);
        }
        public PartialViewResult _Edit(int id)
        {
            var viewModel = new _OwnerFormViewModel();
            var dev= new ApplicationManager().GetOwnerById(id);
            viewModel.Developer = dev;
            
            return PartialView("_Edit", viewModel);

        }
        public PartialViewResult _CreateDev()
        {
            var viewModel = new _OwnerFormViewModel
            {
                Developer = new Owner()
            };
            return PartialView("_CreateDev",viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Update(_OwnerFormViewModel ownerViewModel)
        {

            return Process(ownerViewModel, UpdateFunction);
        }
        public void UpdateFunction(Owner owner, ref ApplicationManager appMgr, List<int> lstApps)
        {
            appMgr.UpdateDeveloper(owner, lstApps);
           
        }
        private ActionResult Process(_OwnerFormViewModel ownerViewModel, DevFunctionDelegate del)
        {
            var appMgr = new ApplicationManager();
            var viewModel = new DevelopersViewModel();
            if (!ModelState.IsValid)
            {
              //  var devsOld = appMgr.GetOwners();
               // viewModel.Developers = devsOld;
                return RedirectToAction("Index");
            }
            ownerViewModel.Developer.Pic=SavePicture(ownerViewModel);
            List<int> lstApps = new List<int>();
            if (ownerViewModel.PostedApps != null)
            {
                foreach (string id in ownerViewModel.PostedApps)
                {
                    lstApps.Add(Convert.ToInt32(id));
                }
            }
           del(ownerViewModel.Developer,ref appMgr, lstApps);
            
           // var devs = appMgr.GetOwners();
          //  viewModel.Developers = devs;
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create(_OwnerFormViewModel ownerViewModel)
        {
            return Process(ownerViewModel,CreateFunction);
            
           
        }

        public PartialViewResult _DeleteConfirmed(Owner owner)
        {
            var appMgr = new ApplicationManager();
            appMgr.DeleteDeveloper(appMgr.GetOwnerById(owner.ID));
            var devs = appMgr.GetOwners();
            return PartialView("_GetAllDevelopers", devs); 
        }
        public PartialViewResult _Delete(int id)
        {
            var dev = new ApplicationManager().GetOwnerById(id);
            return PartialView("_Delete", dev);
        }
        private void CreateFunction(Owner owner, ref ApplicationManager appMgr, List<int> lstApps)
        {
           
            appMgr.CreateDeveloper(owner, lstApps);
            
        }

        private string SavePicture(_OwnerFormViewModel ownerViewModel)
        {
            try
            {
                string pic= ownerViewModel.Developer.Pic;
                if (ownerViewModel.File != null)
                {
                    var fileName = ownerViewModel.SavedFileName;
                    var ext = Path.GetExtension(ownerViewModel.File.FileName);
                    var path = Path.Combine(Server.MapPath("~/images/pics"), fileName);
                    ownerViewModel.File.SaveAs(path + ext);
                   pic = "~/images/pics/" + fileName + ext;

                }
                return pic;
            }
            catch (Exception e)
            {
               return string.Empty;
            }
        }
    }
}
