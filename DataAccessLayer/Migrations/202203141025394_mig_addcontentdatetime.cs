namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addcontentdatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "ContentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contents", "ContentDate");
        }
    }
}
