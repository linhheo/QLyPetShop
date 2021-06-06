namespace QLyPetShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Khos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khos",
                c => new
                    {
                        HanghoaID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Soluong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HanghoaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khos");
        }
    }
}
