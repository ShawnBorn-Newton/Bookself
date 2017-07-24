using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Bookself.Models
{
    public class book
    {
        [Key]//Primary Key
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate{ get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        [ForeignKey("Catagory")]
        public int CatagoryID { get; set; }
        public virtual Catagory Catagory { get; set; }// Navigation Property
    }

}