using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Work.Models
{
    public class Worker
    {
        [Key]
        public int worker_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int lang_id { get; set; }
        public int department_id { get; set; }
    }
}