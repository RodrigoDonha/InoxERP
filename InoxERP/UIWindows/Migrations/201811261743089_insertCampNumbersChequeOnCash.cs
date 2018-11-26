namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertCampNumbersChequeOnCash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_cash", "sChequeNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_cash", "sChequeNumber");
        }
    }
}
