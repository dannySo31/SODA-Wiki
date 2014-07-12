using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sterling.IS.Utilities.ServiceAgent.Manager;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sterling.IS.Utilities.ServiceAgent.Entities
{
    public class Application
    {
        [Required,Key,DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage="Please enter a Name")]
        [DisplayName("Application Name")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a Description")]
        public string Description { get; set; }
        public virtual List<Owner> Owners { get; set; }
       // public virtual List<ApplicationOwner> ApplicationOwners { get; set; }
        public virtual List<Utility> Utilities{get;set;}
        public virtual List<Section> Sections { get; set; }
        
    }
}
