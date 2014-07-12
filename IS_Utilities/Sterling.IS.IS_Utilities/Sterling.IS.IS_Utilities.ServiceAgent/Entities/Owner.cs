using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sterling.IS.Utilities.ServiceAgent.Manager;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sterling.IS.Utilities.ServiceAgent.Entities
{
    public class Owner
    {
        //COnstructor
        public Owner() {
           
        }

        [Required, Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage="This field is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage="This field requires an Email Address")]
        public string Email { get; set; }
      //  public virtual List<ApplicationOwner> ApplicationOwners { get; set; }
        public virtual List<Application> Applications { get; set; }

        public string Title { get; set; }
        public string Pic { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
