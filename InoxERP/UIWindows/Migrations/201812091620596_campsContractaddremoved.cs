namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campsContractaddremoved : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_items", "IdContracts", "dbo.tb_contracts");
            DropIndex("dbo.tb_items", new[] { "IdContracts" });
            AddColumn("dbo.tb_contracts", "sCity", c => c.String());
            DropColumn("dbo.tb_items", "IdContracts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_items", "IdContracts", c => c.String(maxLength: 40));
            DropColumn("dbo.tb_contracts", "sCity");
            CreateIndex("dbo.tb_items", "IdContracts");
            AddForeignKey("dbo.tb_items", "IdContracts", "dbo.tb_contracts", "sID");
        }
    }
}
