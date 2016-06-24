using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Work.Models
{
    public class Language
    {
        [Key]
        public int lang_id { get; set; }
        public string Name { get; set; }
     
    }
}