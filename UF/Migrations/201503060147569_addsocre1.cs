namespace UF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsocre1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gators", "score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gators", "score");
        }
    }
}
