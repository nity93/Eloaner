namespace eLoaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddatabaseattributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Checkouts", "LastModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Checkouts", "LastModifiedBy", c => c.String());
            AddColumn("dbo.Checkouts", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Checkouts", "IsDeleted");
            DropColumn("dbo.Checkouts", "LastModifiedBy");
            DropColumn("dbo.Checkouts", "LastModifiedOn");
        }
    }
}
