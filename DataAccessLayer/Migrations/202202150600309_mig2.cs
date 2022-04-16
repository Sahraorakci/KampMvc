namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 55));
            DropColumn("dbo.Contents", "ContentDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "ContentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 50));
        }
    }
}
