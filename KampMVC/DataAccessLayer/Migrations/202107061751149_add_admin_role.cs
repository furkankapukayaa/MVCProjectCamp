namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_admin_role : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Admins", name: "Role_RoleId", newName: "RoleId");
            RenameIndex(table: "dbo.Admins", name: "IX_Role_RoleId", newName: "IX_RoleId");
            AddColumn("dbo.Admins", "AdminStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminStatus");
            RenameIndex(table: "dbo.Admins", name: "IX_RoleId", newName: "IX_Role_RoleId");
            RenameColumn(table: "dbo.Admins", name: "RoleId", newName: "Role_RoleId");
        }
    }
}
