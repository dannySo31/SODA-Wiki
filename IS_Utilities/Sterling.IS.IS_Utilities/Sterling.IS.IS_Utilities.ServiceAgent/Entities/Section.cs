using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Sterling.IS.Utilities.ServiceAgent.Entities
{
    public class Section
    {
         [Required, Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ApplicationId { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Content { get; set; }
    }
}
