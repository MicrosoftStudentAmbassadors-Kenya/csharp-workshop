using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Efcoreproject.Base
{
    public class Customer
    {
        [StringLength(50)]
     public string FirstName { get; set; }   
     [StringLength(50)]
     public string LastName { get; set; }
     public List<Order> Orders { get; set; } = new List<Order>();
     [NotMapped]
     public string FullName { get; set; }
    }
}