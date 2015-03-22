namespace UF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletegator1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "UFID", c => c.String());
            AddColumn("dbo.Tests", "Gator_ID", c => c.Int());
            CreateIndex("dbo.Tests", "Gator_ID");
            AddForeignKey("dbo.Tests", "Gator_ID", "dbo.Gators", "ID");
            DropColumn("dbo.Tests", "Gator1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tests", "Gator1", c => c.String());
            DropForeignKey("dbo.Tests", "Gator_ID", "dbo.Gators");
            DropIndex("dbo.Tests", new[] { "Gator_ID" });
            DropColumn("dbo.Tests", "Gator_ID");
            DropColumn("dbo.Tests", "UFID");
        }
    }
}
