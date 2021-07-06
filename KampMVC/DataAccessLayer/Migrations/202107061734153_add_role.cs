namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_role : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 1),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleId);
            
            AddColumn("dbo.Admins", "Role_RoleId", c => c.Int());
            CreateIndex("dbo.Admins", "Role_RoleId");
            AddForeignKey("dbo.Admins", "Role_RoleId", "dbo.Roles", "RoleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "Role_RoleId", "dbo.Roles");
            DropIndex("dbo.Admins", new[] { "Role_RoleId" });
            DropColumn("dbo.Admins", "Role_RoleId");
            DropTable("dbo.Roles");
        }
    }
}
