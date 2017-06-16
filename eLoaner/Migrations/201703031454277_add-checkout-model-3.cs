namespace eLoaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcheckoutmodel3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checkouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckedOutBy = c.String(),
                        CheckInBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Checkouts");
        }
    }
}
