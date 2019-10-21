using System.ComponentModel.DataAnnotations.Schema;

namespace Efcoreproject.Base
{
    //[ModelMetadataType(typeof(InventroyMetadata))]
    public partial class Inventory
    {
        public override string ToString(){
            return $"{this.PetName?? "**No Name"} is a {this.Color} {this.Make} with Id {this.Id}.";
        }
        [NotMapped]
        public string MakeColor => $"{Make} +({Color})";
    }
}