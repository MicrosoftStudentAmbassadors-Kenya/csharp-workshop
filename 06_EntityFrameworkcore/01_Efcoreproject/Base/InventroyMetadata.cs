using System.ComponentModel.DataAnnotations;

namespace Efcoreproject.Base
{
    public class InventroyMetadata
    {
        [Display(Name="Pet Name")]
        public string petname;
        [StringLength(50,ErrorMessage ="Please Enter a value less than 50 characters long")]
        public string Make;
    }
}