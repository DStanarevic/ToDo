using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Details { get; set; }
        public bool IsDone { get; set; } //Bools always have to be named in the positive.

        [ForeignKey("List")]
        public int ListID { get; set; }  // This sets the foreign key from the other table.
        public virtual List List { get; set; } // This creates the connection to the other class.
    }
}