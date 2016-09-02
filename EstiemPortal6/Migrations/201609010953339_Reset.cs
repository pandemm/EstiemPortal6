namespace EstiemPortal6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventParticipants",
                c => new
                    {
                        EventId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        RegistrationStatus = c.Int(nullable: false),
                        Comments = c.String(),
                        CmStatus = c.Int(nullable: false),
                        MotivationText = c.String(),
                        Vegetarian = c.Boolean(nullable: false),
                        NoPork = c.Boolean(nullable: false),
                        VisaRequired = c.Boolean(nullable: false),
                        Visa_Firstname = c.String(),
                        Visa_Surname = c.String(),
                        Visa_Birthplace = c.String(),
                        Visa_Birthdate = c.DateTime(nullable: false),
                        Visa_Nationality = c.String(),
                        Visa_PassportIssuedDate = c.DateTime(nullable: false),
                        Visa_PassportIssuedBy = c.String(),
                        Visa_Address = c.String(),
                        Travel_ArrivalDate = c.DateTime(nullable: false),
                        Travel_DepartureDate = c.DateTime(nullable: false),
                        XmlAnswers = c.String(),
                        Visa_PassportNumber = c.String(),
                        Visa_PassportExpiryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventId, t.UserId })
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HistoryId = c.Int(),
                        EventType = c.Int(nullable: false),
                        RegistrationMode = c.Int(),
                        ConfirmationType = c.Int(),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Place = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ApplicationStartDate = c.DateTime(),
                        ApplicationEndDate = c.DateTime(),
                        CancellationDeadLine = c.DateTime(),
                        MaxParticipants = c.Int(),
                        MaxParticipantsperLG = c.Int(),
                        ParticipationFee = c.Int(),
                        HomePage = c.String(),
                        Email = c.String(),
                        Facebook = c.String(),
                        Youtube = c.String(),
                        ParticipantsListGroupId = c.Int(),
                        WaitingListGroupId = c.Int(),
                        EmailListAlias = c.String(),
                        XmlQuestions = c.String(),
                        AdminUserId = c.Int(),
                        ParentGroupId = c.Int(),
                        PartyLevel = c.Short(),
                        SelfDevLevel = c.Short(),
                        EDevLevel = c.Short(),
                        AContentLevel = c.Short(),
                        BContactLevel = c.Short(),
                        CultureLevel = c.Short(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        FirstName = c.String(),
                        FirstNameEnglish = c.String(),
                        LastName = c.String(),
                        LastNameEnglish = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        MobilePhone = c.String(),
                        HomePage = c.String(),
                        Facebook = c.String(),
                        Skype = c.String(),
                        Twitter = c.String(),
                        Linkedin = c.String(),
                        Instagram = c.String(),
                        SnapChat = c.String(),
                        LocalGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventParticipants", "UserId", "dbo.Users");
            DropForeignKey("dbo.EventParticipants", "EventId", "dbo.Events");
            DropIndex("dbo.EventParticipants", new[] { "UserId" });
            DropIndex("dbo.EventParticipants", new[] { "EventId" });
            DropTable("dbo.Users");
            DropTable("dbo.Events");
            DropTable("dbo.EventParticipants");
        }
    }
}
