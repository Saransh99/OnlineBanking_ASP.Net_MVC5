namespace OnlineBanking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BeneficiaryModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beneficiaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BeneficiaryName = c.String(nullable: false),
                        BeneficiaryAccountNo = c.String(nullable: false),
                        BeneficiaryBankName = c.String(nullable: false),
                        BeneficiaryIFSCode = c.String(nullable: false),
                        TransferLimit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Beneficiaries");
        }
    }
}
