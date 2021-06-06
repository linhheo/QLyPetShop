namespace QLyPetShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HangHoas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        HanghoaID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Tenhanghoa = c.String(),
                        Gia = c.String(),
                    })
                .PrimaryKey(t => t.HanghoaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoas");
        }
    }
}
