namespace QLyPetShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DichVus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        DichvuID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Dichvu = c.String(),
                        Gia = c.String(),
                    })
                .PrimaryKey(t => t.DichvuID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DichVus");
        }
    }
}
