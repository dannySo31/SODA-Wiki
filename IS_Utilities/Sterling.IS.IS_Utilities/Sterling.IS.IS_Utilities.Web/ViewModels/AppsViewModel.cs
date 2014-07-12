using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sterling.IS.Utilities.ServiceAgent.Entities;

namespace Sterling.IS.Utilities.Web.ViewModels
{
    public class AppsViewModel
    {
        public Application Application { get; set; }
        public List<Utility> AppUtilities { get; set; }
    }
}