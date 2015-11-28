using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginProject.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string ContentType { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string SampleCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Published { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
        

    }
}