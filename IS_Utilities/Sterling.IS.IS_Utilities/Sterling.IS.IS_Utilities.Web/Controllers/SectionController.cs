using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sterling.IS.Utilities.ServiceAgent.Entities;
using Sterling.IS.Utilities.ServiceAgent.Manager;

namespace Sterling.IS.Utilities.Web.Controllers
{
    public class SectionController : Controller
    {
        //
        // GET: /Section/

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _GetSections(List<Section> sections){

          
            return PartialView("_GetSections",sections);
        }

        public ActionResult _Edit(int id)
        {
            var section = new ApplicationManager().GetSectionById(id);
            return View("_Edit", section);
        }
        public PartialViewResult _DeleteConfirmed(Section section)
        {
            var appMgr = new ApplicationManager();
            appMgr.DeleteSection(section);
            var sections = appMgr.GetSectionsByAppId(section.ApplicationId);
            return PartialView("_GetSections", sections);
        }
        public PartialViewResult _CreateNew(Section section)
        {
            var appMgr = new ApplicationManager();
            appMgr.InsertSection(section);
            var sections = appMgr.GetSectionsByAppId(section.ApplicationId);
            return PartialView("_GetSections", sections);
        }
        public PartialViewResult _Create(int appId)
        {
            var section = new Section();
            section.ApplicationId = appId;
            return PartialView("_Create", section);
        }
        public PartialViewResult _SectionForm(Section section)
        {
            return PartialView("_SectionForm", section);
        }
        public PartialViewResult _Delete(int id)
        {
            var section = new ApplicationManager().GetSectionById(id);
            return PartialView("_Delete", section);
        }
    }
}
