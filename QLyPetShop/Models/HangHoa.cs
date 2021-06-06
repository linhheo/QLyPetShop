using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLyPetShop.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string HanghoaID { get; set; }
        public string Tenhanghoa { get; set; }
        public string Gia { get; set; }
    }
}