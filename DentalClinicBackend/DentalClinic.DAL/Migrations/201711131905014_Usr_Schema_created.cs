namespace DentalClinic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usr_Schema_created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "usr.Clients",
                c => new
                    {
                        SystemUserId = c.Int(nullable: false, identity: true),
                        DateOfBirth = c.DateTime(),
                        SystemUser_SystemUserId = c.Int(),
                    })
                .PrimaryKey(t => t.SystemUserId)
                .ForeignKey("core.SystemUsers", t => t.SystemUser_SystemUserId)
                .Index(t => t.SystemUser_SystemUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("usr.Clients", "SystemUser_SystemUserId", "core.SystemUsers");
            DropIndex("usr.Clients", new[] { "SystemUser_SystemUserId" });
            DropTable("usr.Clients");
        }
    }
}
