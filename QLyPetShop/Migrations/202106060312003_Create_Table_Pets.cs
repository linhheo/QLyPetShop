namespace QLyPetShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Pets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        PetID = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenPet = c.String(),
                        Dichvu = c.String(),
                    })
                .PrimaryKey(t => t.PetID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pets");
        }
    }
}
