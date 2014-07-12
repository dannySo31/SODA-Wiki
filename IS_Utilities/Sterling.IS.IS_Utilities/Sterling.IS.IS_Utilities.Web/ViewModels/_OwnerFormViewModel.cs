using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sterling.IS.Utilities.ServiceAgent.Entities;
using Sterling.IS.Utilities.ServiceAgent.Manager;
using System.ComponentModel.DataAnnotations;

namespace Sterling.IS.Utilities.Web.ViewModels
{
    public class _OwnerFormViewModel
    {
      
        public Owner Developer { get; set; }
        public virtual List<Application> All_Applications
        {
            get
            {
                return new ApplicationManager().GetApplications();
            }
        }
        public string[] PostedApps { get; set; }
        public HttpPostedFileBase File { get; set; }
        public string SavedFileName
        {
            get
            {
                return String.Join("_", Developer.LastName, Developer.FirstName);
            }

        }

       
    }
}