namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campinscricaostadual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_contracts", "sRegistStateRg", c => c.String(nullable: false, maxLength: 16));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_contracts", "sRegistStateRg");
        }
    }
}
