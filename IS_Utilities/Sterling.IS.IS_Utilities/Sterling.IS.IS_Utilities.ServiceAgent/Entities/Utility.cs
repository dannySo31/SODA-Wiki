using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sterling.IS.Utilities.ServiceAgent.Entities
{
    public class Utility
    {
         [Required, Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string PartialViewName { get; set; }
        public string Name { get; set; }
        public int ApplicationId { get; set; }
    }
}
