namespace UF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmoney : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "MONEY", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tests", "MONEY");
        }
    }
}
