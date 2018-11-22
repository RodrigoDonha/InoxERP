namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCampsNotNullidClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_accountsToPay", "sId_Budgets_OS", c => c.String(maxLength: 100));
            AlterColumn("dbo.tb_accountsToPay", "sId_Client", c => c.String(maxLength: 100));
            AlterColumn("dbo.tb_cash", "sId_Client", c => c.String(maxLength: 100));
            AlterColumn("dbo.tb_accountsToReceive", "sId_Client", c => c.String(maxLength: 100));
            AlterColumn("dbo.tb_cheques", "sId_Client", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_cheques", "sId_Client", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.tb_accountsToReceive", "sId_Client", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.tb_cash", "sId_Client", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.tb_accountsToPay", "sId_Client", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.tb_accountsToPay", "sId_Budgets_OS", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
