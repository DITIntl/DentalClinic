namespace DentalClinic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dmn_Schema_created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dmn.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        VisitId = c.Int(nullable: false),
                        Text = c.String(),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dmn.Visits", t => t.VisitId, cascadeDelete: true)
                .Index(t => t.VisitId);
            
            CreateTable(
                "dmn.Visits",
                c => new
                    {
                        VisitId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        DentistId = c.Int(nullable: false),
                        Date = c.DateTime(),
                        IsCanceled = c.Boolean(nullable: false),
                        Client_SystemUserId = c.Int(),
                        Dentist_SystemUserId = c.Int(),
                    })
                .PrimaryKey(t => t.VisitId)
                .ForeignKey("core.SystemUsers", t => t.Client_SystemUserId)
                .ForeignKey("core.SystemUsers", t => t.Dentist_SystemUserId)
                .Index(t => t.Client_SystemUserId)
                .Index(t => t.Dentist_SystemUserId);
            
            CreateTable(
                "dbo.Suggestions",
                c => new
                    {
                        SuggestionId = c.Int(nullable: false, identity: true),
                        VisitId = c.Int(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.SuggestionId)
                .ForeignKey("dmn.Visits", t => t.VisitId, cascadeDelete: true)
                .Index(t => t.VisitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suggestions", "VisitId", "dmn.Visits");
            DropForeignKey("dmn.Comments", "VisitId", "dmn.Visits");
            DropForeignKey("dmn.Visits", "Dentist_SystemUserId", "core.SystemUsers");
            DropForeignKey("dmn.Visits", "Client_SystemUserId", "core.SystemUsers");
            DropIndex("dbo.Suggestions", new[] { "VisitId" });
            DropIndex("dmn.Visits", new[] { "Dentist_SystemUserId" });
            DropIndex("dmn.Visits", new[] { "Client_SystemUserId" });
            DropIndex("dmn.Comments", new[] { "VisitId" });
            DropTable("dbo.Suggestions");
            DropTable("dmn.Visits");
            DropTable("dmn.Comments");
        }
    }
}
