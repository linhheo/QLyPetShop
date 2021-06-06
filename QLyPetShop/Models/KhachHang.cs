using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLyPetShop.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string KhachhangID { get; set; }
        public string TenKhachhang { get; set; }
        public string Sodienthoai { get; set; }
    }
}