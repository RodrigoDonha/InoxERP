namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcampsdpaiddremaing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_accountsToPay", "dPaid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_accountsToPay", "dRemaing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_accountsToReceive", "dPaid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_accountsToReceive", "dRemaing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_cheques", "dPaid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_cheques", "dRemaing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_cheques", "dRemaing");
            DropColumn("dbo.tb_cheques", "dPaid");
            DropColumn("dbo.tb_accountsToReceive", "dRemaing");
            DropColumn("dbo.tb_accountsToReceive", "dPaid");
            DropColumn("dbo.tb_accountsToPay", "dRemaing");
            DropColumn("dbo.tb_accountsToPay", "dPaid");
        }
    }
}
