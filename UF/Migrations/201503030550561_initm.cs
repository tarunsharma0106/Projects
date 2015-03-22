namespace UF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gators", "money", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gators", "money");
        }
    }
}
