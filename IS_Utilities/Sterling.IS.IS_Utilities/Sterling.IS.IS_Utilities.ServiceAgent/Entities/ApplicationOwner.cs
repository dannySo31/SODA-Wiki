using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sterling.IS.Utilities.ServiceAgent.Entities
{
    public class ApplicationOwner
    {
         [Required, Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int OwnerId { get; set; }

       // public virtual Owner Owner { get; set; }
       // public virtual Application Application { get; set; }
    }
}
