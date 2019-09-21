namespace OnlineBanking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminModelUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrators", "BranchManager_Id", c => c.Int());
            AlterColumn("dbo.Administrators", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "Username", c => c.String(nullable: false));
            CreateIndex("dbo.Administrators", "BranchManager_Id");
            AddForeignKey("dbo.Administrators", "BranchManager_Id", "dbo.BranchManagers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Administrators", "BranchManager_Id", "dbo.BranchManagers");
            DropIndex("dbo.Administrators", new[] { "BranchManager_Id" });
            AlterColumn("dbo.Administrators", "Username", c => c.String());
            AlterColumn("dbo.Administrators", "Password", c => c.String());
            DropColumn("dbo.Administrators", "BranchManager_Id");
        }
    }
}
