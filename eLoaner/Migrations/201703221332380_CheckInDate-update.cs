namespace eLoaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckInDateupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Checkouts", "CheckInDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Checkouts", "CheckInDate", c => c.DateTime(nullable: false));
        }
    }
}
