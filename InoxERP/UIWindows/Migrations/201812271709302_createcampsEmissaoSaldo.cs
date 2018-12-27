namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcampsEmissaoSaldo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_accountsToPay", "dtIssue", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_cash", "dBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_accountsToReceive", "dtIssue", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_cheques", "dtIssue", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_cheques", "dtIssue");
            DropColumn("dbo.tb_accountsToReceive", "dtIssue");
            DropColumn("dbo.tb_cash", "dBalance");
            DropColumn("dbo.tb_accountsToPay", "dtIssue");
        }
    }
}
