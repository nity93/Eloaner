namespace eLoaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assets", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsDeleted");
            DropColumn("dbo.Assets", "IsDeleted");
        }
    }
}
