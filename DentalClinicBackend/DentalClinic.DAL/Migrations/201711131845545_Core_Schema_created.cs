namespace DentalClinic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Core_Schema_created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "core.SystemRoles",
                c => new
                    {
                        SystemRoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.SystemRoleId);
            
            CreateTable(
                "core.SystemUserCredential",
                c => new
                    {
                        SystemUserCredentialId = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Salt = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        SystemUser_SystemUserId = c.Int(),
                    })
                .PrimaryKey(t => t.SystemUserCredentialId)
                .ForeignKey("core.SystemUsers", t => t.SystemUser_SystemUserId)
                .Index(t => t.SystemUser_SystemUserId);
            
            CreateTable(
                "core.SystemUsers",
                c => new
                    {
                        SystemUserId = c.Int(nullable: false, identity: true),
                        SystemRoleId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.SystemUserId)
                .ForeignKey("core.SystemRoles", t => t.SystemRoleId, cascadeDelete: true)
                .Index(t => t.SystemRoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("core.SystemUserCredential", "SystemUser_SystemUserId", "core.SystemUsers");
            DropForeignKey("core.SystemUsers", "SystemRoleId", "core.SystemRoles");
            DropIndex("core.SystemUsers", new[] { "SystemRoleId" });
            DropIndex("core.SystemUserCredential", new[] { "SystemUser_SystemUserId" });
            DropTable("core.SystemUsers");
            DropTable("core.SystemUserCredential");
            DropTable("core.SystemRoles");
        }
    }
}
