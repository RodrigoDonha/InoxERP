namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRangeonCampsChequeNumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_cash", "sChequeNumber", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_cash", "sChequeNumber", c => c.String());
        }
    }
}
