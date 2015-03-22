namespace UF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsocre2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gators", "UFID", c => c.Int(nullable: false));
            AlterColumn("dbo.Tests", "UFID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tests", "UFID", c => c.String());
            AlterColumn("dbo.Gators", "UFID", c => c.String());
        }
    }
}
