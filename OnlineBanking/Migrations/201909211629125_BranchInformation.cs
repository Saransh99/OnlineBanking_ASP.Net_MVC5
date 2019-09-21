namespace OnlineBanking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchInformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BranchInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchCode = c.String(nullable: false),
                        State = c.String(nullable: false),
                        City = c.String(nullable: false),
                        PinCode = c.String(nullable: false),
                        IFSCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BranchInformations");
        }
    }
}
