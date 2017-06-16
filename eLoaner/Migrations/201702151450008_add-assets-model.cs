namespace eLoaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addassetsmodel : DbMigration
    {//create tables- fields and data types
    
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Serial = c.String(),
                        Manufacturer = c.String(),
                        Model = c.String(),
                        Type = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedOn = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        //code that runs to move table (remove migrations)
        public override void Down()
        {
            DropTable("dbo.Assets");
        }
    }
}
