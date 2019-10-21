using System.ComponentModel.DataAnnotations;

namespace Efcoreproject.Base
{
    public partial class Order : EntityBase
    { 
        [Key]
        public int CustomerId { get; set; }
        
        public int CarId { get; set; }
        [StringLength(50)]
        public Customer Customer { get; set; }
        public Inventory Car { get; set; }
    }
}