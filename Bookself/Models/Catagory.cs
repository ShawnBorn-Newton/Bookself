using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookself.Models
{
    public class Catagory
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public virtual ICollection<book> Books { get; set; }
    }
}