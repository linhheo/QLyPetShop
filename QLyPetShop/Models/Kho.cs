using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLyPetShop.Models
{
    [Table("Khos")]
    public class Kho
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string HanghoaID { get; set; }
        public int Soluong { get; set; }
    }
}