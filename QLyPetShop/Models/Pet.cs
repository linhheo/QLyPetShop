using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace QLyPetShop.Models
{
    [Table("Pets")]
    public class Pet
    {
        [Key]
        [AllowHtml]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string PetID { get; set; }
        public string TenPet { get; set; }
        public string Dichvu { get; set; }
    }
}