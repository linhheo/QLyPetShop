using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLyPetShop.Models
{
    public partial class PetShopDbContext : DbContext
    {
        public PetShopDbContext()
            : base("name=PetShopDbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<Kho> Khos { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
