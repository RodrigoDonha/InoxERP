namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatbooleancampandcamebackcall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_budgets_os", "bContractRegistred", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_items", "IdContracts", c => c.String(maxLength: 40));
            AddColumn("dbo.tb_contracts", "sIdBudget_OS", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.tb_items", "IdContracts");
            AddForeignKey("dbo.tb_items", "IdContracts", "dbo.tb_contracts", "sID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_items", "IdContracts", "dbo.tb_contracts");
            DropIndex("dbo.tb_items", new[] { "IdContracts" });
            DropColumn("dbo.tb_contracts", "sIdBudget_OS");
            DropColumn("dbo.tb_items", "IdContracts");
            DropColumn("dbo.tb_budgets_os", "bContractRegistred");
        }
    }
}
