namespace UF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsocre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tests", "score");
        }
    }
}
