namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullbablecampidbudgetofcheques : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_cheques", "sId_Budgets_OS", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_cheques", "sId_Budgets_OS", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
