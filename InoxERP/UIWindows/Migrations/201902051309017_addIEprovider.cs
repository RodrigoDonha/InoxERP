namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIEprovider : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_providers", "sInscrEst", c => c.String(nullable: false, maxLength: 16));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_providers", "sInscrEst");
        }
    }
}
