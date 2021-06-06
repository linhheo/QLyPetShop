using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLyPetShop.Models
{
    [Table("DichVus")]
    public class DichVu
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string DichvuID { get; set; }
        public string Dichvu { get; set; }
        public string Gia { get; set; }
    }
}