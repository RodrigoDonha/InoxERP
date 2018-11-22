namespace UIWindows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initianCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_accountsToPay",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sId_Budgets_OS = c.String(nullable: false, maxLength: 100),
                        sId_Client = c.String(nullable: false, maxLength: 100),
                        dValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dtDueDate = c.DateTime(nullable: false),
                        dtPayDate = c.DateTime(nullable: false),
                        bReceivePaid = c.Boolean(nullable: false),
                        iInstallment = c.Int(nullable: false),
                        iAmountInstallment = c.Int(nullable: false),
                        sReferentTo = c.String(maxLength: 100),
                        idCash = c.String(maxLength: 40),
                        idProviders = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_cash", t => t.idCash)
                .ForeignKey("dbo.tb_providers", t => t.idProviders)
                .Index(t => t.idCash)
                .Index(t => t.idProviders);
            
            CreateTable(
                "dbo.tb_cash",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sId_Budgets_OS = c.String(nullable: false, maxLength: 100),
                        sId_Client = c.String(nullable: false, maxLength: 100),
                        dValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dtDate = c.DateTime(nullable: false),
                        sReferentTo = c.String(maxLength: 100),
                        CashType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sID);
            
            CreateTable(
                "dbo.tb_accountsToReceive",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sId_Budgets_OS = c.String(nullable: false, maxLength: 100),
                        sId_Client = c.String(nullable: false, maxLength: 100),
                        dValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dtDueDate = c.DateTime(nullable: false),
                        dtReceiveDate = c.DateTime(nullable: false),
                        bReceivePaid = c.Boolean(nullable: false),
                        iInstallment = c.Int(nullable: false),
                        iAmountInstallment = c.Int(nullable: false),
                        sReferentTo = c.String(maxLength: 100),
                        idCash = c.String(maxLength: 40),
                        idBudgets_OS = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_budgets_os", t => t.idBudgets_OS)
                .ForeignKey("dbo.tb_cash", t => t.idCash)
                .Index(t => t.idCash)
                .Index(t => t.idBudgets_OS);
            
            CreateTable(
                "dbo.tb_budgets_os",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        iCod = c.Int(nullable: false),
                        ClientType = c.Int(nullable: false),
                        dtDate = c.DateTime(nullable: false),
                        sName = c.String(nullable: false, maxLength: 100),
                        sAdress = c.String(maxLength: 100),
                        sTelephone = c.String(nullable: false, maxLength: 14),
                        sOccupation = c.String(maxLength: 100),
                        PaymentMethods = c.Int(nullable: false),
                        bPaymentToMatch = c.Boolean(nullable: false),
                        dPercentDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iPaymentInstallments = c.Int(nullable: false),
                        bInterestRate = c.Boolean(nullable: false),
                        dWithInterest = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iPrevisionOfExecute = c.Int(nullable: false),
                        dtStartPrevision = c.DateTime(nullable: false),
                        dtFinalPrevision = c.DateTime(nullable: false),
                        iWarrantyTime = c.Int(nullable: false),
                        dtBudgetExpirationDate = c.DateTime(nullable: false),
                        sObservation = c.String(),
                        dTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bServiceOrderApproved = c.Boolean(nullable: false),
                        dtDateServiceOrderApproved = c.DateTime(),
                        bServiceOrderDelivered = c.Boolean(nullable: false),
                        dtDateServiceOrderDelivered = c.DateTime(),
                        bRegisterFinished = c.Boolean(nullable: false),
                        dtDateRegisterFinished = c.DateTime(),
                        IdClients = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_clients", t => t.IdClients)
                .Index(t => t.IdClients);
            
            CreateTable(
                "dbo.tb_clients",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sName = c.String(nullable: false, maxLength: 100),
                        sCpfCnpj = c.String(nullable: false, maxLength: 18),
                        sRg = c.String(maxLength: 14),
                        ClientType = c.Int(nullable: false),
                        sAdress = c.String(maxLength: 100),
                        iNumber = c.Int(nullable: false),
                        sDistrict = c.String(maxLength: 100),
                        sComplement = c.String(maxLength: 50),
                        sCity = c.String(maxLength: 100),
                        Estate = c.Int(nullable: false),
                        sCEP = c.String(maxLength: 9),
                        sPhoneResidencial = c.String(maxLength: 14),
                        sPhoneCelularOne = c.String(nullable: false, maxLength: 15),
                        sPhoneCelularTwo = c.String(maxLength: 15),
                        sEmail = c.String(maxLength: 100),
                        sOccupation = c.String(maxLength: 100),
                        sObservation = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.sID);
            
            CreateTable(
                "dbo.tb_items",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        dAmount = c.Double(nullable: false),
                        sDescription = c.String(nullable: false, maxLength: 100),
                        dPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sObservation = c.String(maxLength: 300),
                        IdBudgets_OS = c.String(maxLength: 40),
                        IdContracts = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_budgets_os", t => t.IdBudgets_OS)
                .ForeignKey("dbo.tb_contracts", t => t.IdContracts)
                .Index(t => t.IdBudgets_OS)
                .Index(t => t.IdContracts);
            
            CreateTable(
                "dbo.tb_contracts",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sProviderName = c.String(nullable: false, maxLength: 100),
                        sProviderCpfCnpj = c.String(nullable: false, maxLength: 100),
                        sProviderAdress = c.String(nullable: false, maxLength: 100),
                        sProviderNumberAdress = c.String(nullable: false, maxLength: 100),
                        sProviderDistrict = c.String(nullable: false, maxLength: 100),
                        sProviderCep = c.String(nullable: false, maxLength: 100),
                        sProviderCity = c.String(nullable: false, maxLength: 100),
                        ProviderEstate = c.Int(nullable: false),
                        sClientName = c.String(nullable: false, maxLength: 100),
                        sClientCpfCnpj = c.String(nullable: false, maxLength: 100),
                        sClientRg = c.String(nullable: false, maxLength: 100),
                        sClientAdress = c.String(nullable: false, maxLength: 100),
                        sClientNumberAdress = c.String(nullable: false, maxLength: 100),
                        sClientDistrict = c.String(nullable: false, maxLength: 100),
                        sClientCep = c.String(nullable: false, maxLength: 100),
                        sClientCity = c.String(nullable: false, maxLength: 100),
                        ClientEstate = c.Int(nullable: false),
                        dTotalValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iDeadline = c.Int(nullable: false),
                        dtStartExecution = c.DateTime(nullable: false),
                        iWarrantyTime = c.Int(nullable: false),
                        dtContractDate = c.DateTime(nullable: false),
                        sClientObjectContract = c.String(nullable: false),
                        sPaymentForm = c.String(),
                        Budgets_OS_sID = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_budgets_os", t => t.Budgets_OS_sID)
                .Index(t => t.Budgets_OS_sID);
            
            CreateTable(
                "dbo.tb_products",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sDescription = c.String(nullable: false, maxLength: 100),
                        dAmount = c.Double(nullable: false),
                        Type = c.Int(nullable: false),
                        dPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sObservation = c.String(maxLength: 300),
                        IdProviders = c.String(maxLength: 40),
                        IdItems = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_items", t => t.IdItems)
                .ForeignKey("dbo.tb_providers", t => t.IdProviders)
                .Index(t => t.IdProviders)
                .Index(t => t.IdItems);
            
            CreateTable(
                "dbo.tb_providers",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sName = c.String(nullable: false, maxLength: 100),
                        sCpfCnpj = c.String(nullable: false, maxLength: 18),
                        sAdress = c.String(maxLength: 100),
                        iNumber = c.Int(nullable: false),
                        sDistrict = c.String(maxLength: 100),
                        sComplement = c.String(maxLength: 50),
                        sCity = c.String(maxLength: 100),
                        Estate = c.Int(nullable: false),
                        sCEP = c.String(maxLength: 9),
                        sPhoneComercial = c.String(maxLength: 14),
                        sPhoneCelularOne = c.String(nullable: false, maxLength: 15),
                        sPhoneCelularTwo = c.String(maxLength: 15),
                        sEmail = c.String(maxLength: 100),
                        sBank = c.String(maxLength: 50),
                        sAgency = c.String(maxLength: 20),
                        sAccount = c.String(maxLength: 20),
                        sFavored = c.String(maxLength: 100),
                        sCpfCnpjFavored = c.String(maxLength: 18),
                        dMinimumPurchase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sObservation = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.sID);
            
            CreateTable(
                "dbo.tb_services",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sDescription = c.String(nullable: false, maxLength: 100),
                        sTime = c.Double(nullable: false),
                        dTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sObservation = c.String(maxLength: 300),
                        IdItems = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_items", t => t.IdItems)
                .Index(t => t.IdItems);
            
            CreateTable(
                "dbo.tb_parcialReceive",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        dParcialValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dtParcialDueDate = c.DateTime(nullable: false),
                        sReferentTo = c.String(maxLength: 100),
                        idAccountsToReceive = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_accountsToReceive", t => t.idAccountsToReceive)
                .Index(t => t.idAccountsToReceive);
            
            CreateTable(
                "dbo.tb_cheques",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sId_Budgets_OS = c.String(nullable: false, maxLength: 100),
                        sId_Client = c.String(nullable: false, maxLength: 100),
                        dValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dtDueDate = c.DateTime(nullable: false),
                        dtPayDate = c.DateTime(nullable: false),
                        bChequePaid = c.Boolean(nullable: false),
                        iInstallment = c.Int(nullable: false),
                        iAmountInstallment = c.Int(nullable: false),
                        sChequeNumber = c.String(nullable: false, maxLength: 33),
                        sReferentTo = c.String(maxLength: 100),
                        idCash = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_cash", t => t.idCash)
                .Index(t => t.idCash);
            
            CreateTable(
                "dbo.tb_parcialPay",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        dParcialValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dtParcialDueDate = c.DateTime(nullable: false),
                        sReferentTo = c.String(maxLength: 100),
                        idAccountsToPay = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.tb_accountsToPay", t => t.idAccountsToPay)
                .Index(t => t.idAccountsToPay);
            
            CreateTable(
                "dbo.Permitions",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        bRegisters = c.Boolean(nullable: false),
                        bBudgets = c.Boolean(nullable: false),
                        bServicesOrders = c.Boolean(nullable: false),
                        bDeliverys = c.Boolean(nullable: false),
                        bAccounts = c.Boolean(nullable: false),
                        bCash = c.Boolean(nullable: false),
                        bReports = c.Boolean(nullable: false),
                        bBackups = c.Boolean(nullable: false),
                        bPermitions = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.sID);
            
            CreateTable(
                "dbo.tb_users",
                c => new
                    {
                        sID = c.String(nullable: false, maxLength: 40),
                        sName = c.String(nullable: false, maxLength: 100),
                        sLogin = c.String(nullable: false, maxLength: 100),
                        sKey = c.String(nullable: false, maxLength: 100),
                        Type = c.Int(nullable: false),
                        Permitions_sID = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.sID)
                .ForeignKey("dbo.Permitions", t => t.Permitions_sID)
                .Index(t => t.Permitions_sID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_users", "Permitions_sID", "dbo.Permitions");
            DropForeignKey("dbo.tb_accountsToPay", "idProviders", "dbo.tb_providers");
            DropForeignKey("dbo.tb_parcialPay", "idAccountsToPay", "dbo.tb_accountsToPay");
            DropForeignKey("dbo.tb_accountsToPay", "idCash", "dbo.tb_cash");
            DropForeignKey("dbo.tb_cheques", "idCash", "dbo.tb_cash");
            DropForeignKey("dbo.tb_parcialReceive", "idAccountsToReceive", "dbo.tb_accountsToReceive");
            DropForeignKey("dbo.tb_accountsToReceive", "idCash", "dbo.tb_cash");
            DropForeignKey("dbo.tb_accountsToReceive", "idBudgets_OS", "dbo.tb_budgets_os");
            DropForeignKey("dbo.tb_services", "IdItems", "dbo.tb_items");
            DropForeignKey("dbo.tb_products", "IdProviders", "dbo.tb_providers");
            DropForeignKey("dbo.tb_products", "IdItems", "dbo.tb_items");
            DropForeignKey("dbo.tb_items", "IdContracts", "dbo.tb_contracts");
            DropForeignKey("dbo.tb_contracts", "Budgets_OS_sID", "dbo.tb_budgets_os");
            DropForeignKey("dbo.tb_items", "IdBudgets_OS", "dbo.tb_budgets_os");
            DropForeignKey("dbo.tb_budgets_os", "IdClients", "dbo.tb_clients");
            DropIndex("dbo.tb_users", new[] { "Permitions_sID" });
            DropIndex("dbo.tb_parcialPay", new[] { "idAccountsToPay" });
            DropIndex("dbo.tb_cheques", new[] { "idCash" });
            DropIndex("dbo.tb_parcialReceive", new[] { "idAccountsToReceive" });
            DropIndex("dbo.tb_services", new[] { "IdItems" });
            DropIndex("dbo.tb_products", new[] { "IdItems" });
            DropIndex("dbo.tb_products", new[] { "IdProviders" });
            DropIndex("dbo.tb_contracts", new[] { "Budgets_OS_sID" });
            DropIndex("dbo.tb_items", new[] { "IdContracts" });
            DropIndex("dbo.tb_items", new[] { "IdBudgets_OS" });
            DropIndex("dbo.tb_budgets_os", new[] { "IdClients" });
            DropIndex("dbo.tb_accountsToReceive", new[] { "idBudgets_OS" });
            DropIndex("dbo.tb_accountsToReceive", new[] { "idCash" });
            DropIndex("dbo.tb_accountsToPay", new[] { "idProviders" });
            DropIndex("dbo.tb_accountsToPay", new[] { "idCash" });
            DropTable("dbo.tb_users");
            DropTable("dbo.Permitions");
            DropTable("dbo.tb_parcialPay");
            DropTable("dbo.tb_cheques");
            DropTable("dbo.tb_parcialReceive");
            DropTable("dbo.tb_services");
            DropTable("dbo.tb_providers");
            DropTable("dbo.tb_products");
            DropTable("dbo.tb_contracts");
            DropTable("dbo.tb_items");
            DropTable("dbo.tb_clients");
            DropTable("dbo.tb_budgets_os");
            DropTable("dbo.tb_accountsToReceive");
            DropTable("dbo.tb_cash");
            DropTable("dbo.tb_accountsToPay");
        }
    }
}
