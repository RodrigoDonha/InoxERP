namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter_properties_notnull_camps_sPhones_providers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_providers", "sPhoneComercial", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.tb_providers", "sPhoneCelularOne", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_providers", "sPhoneCelularOne", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.tb_providers", "sPhoneComercial", c => c.String(maxLength: 14));
        }
    }
}
