namespace UF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "Question1", c => c.String());
            AddColumn("dbo.Tests", "Question2", c => c.String());
            AddColumn("dbo.Tests", "Question3", c => c.String());
            AddColumn("dbo.Tests", "Question4", c => c.String());
            AddColumn("dbo.Tests", "Question5", c => c.String());
            AddColumn("dbo.Tests", "Question6", c => c.String());
            DropColumn("dbo.Tests", "QuestionA");
            DropColumn("dbo.Tests", "QuestionB");
            DropColumn("dbo.Tests", "QuestionC");
            DropColumn("dbo.Tests", "QuestionD");
            DropColumn("dbo.Tests", "QuestionE");
            DropColumn("dbo.Tests", "QuestionF");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tests", "QuestionF", c => c.String());
            AddColumn("dbo.Tests", "QuestionE", c => c.String());
            AddColumn("dbo.Tests", "QuestionD", c => c.String());
            AddColumn("dbo.Tests", "QuestionC", c => c.String());
            AddColumn("dbo.Tests", "QuestionB", c => c.String());
            AddColumn("dbo.Tests", "QuestionA", c => c.String());
            DropColumn("dbo.Tests", "Question6");
            DropColumn("dbo.Tests", "Question5");
            DropColumn("dbo.Tests", "Question4");
            DropColumn("dbo.Tests", "Question3");
            DropColumn("dbo.Tests", "Question2");
            DropColumn("dbo.Tests", "Question1");
        }
    }
}
