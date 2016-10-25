namespace EstiemPortal6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EstiemPortalContext : DbContext
    {
        public EstiemPortalContext()
            : base("name=EstiemPortal5CodeFirst")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ALUMNI_Event> ALUMNI_Event { get; set; }
        public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; }
        public virtual DbSet<CONFIGURATION_Assets> CONFIGURATION_Assets { get; set; }
        public virtual DbSet<CONFIGURATION_Data> CONFIGURATION_Data { get; set; }
        public virtual DbSet<CONFIGURATION_Keys> CONFIGURATION_Keys { get; set; }
        public virtual DbSet<CONFIGURATION_Scopes> CONFIGURATION_Scopes { get; set; }
        public virtual DbSet<CONFIGURATION_Sets> CONFIGURATION_Sets { get; set; }
        public virtual DbSet<CONFIGURATION_Values> CONFIGURATION_Values { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<ESTIEM_CorporateInfo> ESTIEM_CorporateInfo { get; set; }
        public virtual DbSet<ESTIEM_Country> ESTIEM_Country { get; set; }
        public virtual DbSet<ESTIEM_Group> ESTIEM_Group { get; set; }
        public virtual DbSet<ESTIEM_LocalGroup> ESTIEM_LocalGroup { get; set; }
        public virtual DbSet<ESTIEM_OldUser> ESTIEM_OldUser { get; set; }
        public virtual DbSet<ESTIEM_RegionLocalGroup> ESTIEM_RegionLocalGroup { get; set; }
        public virtual DbSet<ESTIEM_RegionResponsible> ESTIEM_RegionResponsible { get; set; }
        public virtual DbSet<ESTIEM_TeamCategory> ESTIEM_TeamCategory { get; set; }
        public virtual DbSet<ESTIEM_TeamRelation> ESTIEM_TeamRelation { get; set; }
        public virtual DbSet<ESTIEM_UserCompany> ESTIEM_UserCompany { get; set; }
        public virtual DbSet<EVENTS_Events> EVENTS_Events { get; set; }
        public virtual DbSet<EVENTS_EventType> EVENTS_EventType { get; set; }
        public virtual DbSet<EVENTS_Participants> EVENTS_Participants { get; set; }
        public virtual DbSet<FORUM_AccessMask> FORUM_AccessMask { get; set; }
        public virtual DbSet<FORUM_Active> FORUM_Active { get; set; }
        public virtual DbSet<FORUM_Attachment> FORUM_Attachment { get; set; }
        public virtual DbSet<FORUM_BannedIP> FORUM_BannedIP { get; set; }
        public virtual DbSet<FORUM_BBCode> FORUM_BBCode { get; set; }
        public virtual DbSet<FORUM_Board> FORUM_Board { get; set; }
        public virtual DbSet<FORUM_Buddy> FORUM_Buddy { get; set; }
        public virtual DbSet<FORUM_Category> FORUM_Category { get; set; }
        public virtual DbSet<FORUM_CheckEmail> FORUM_CheckEmail { get; set; }
        public virtual DbSet<FORUM_Choice> FORUM_Choice { get; set; }
        public virtual DbSet<FORUM_EventLog> FORUM_EventLog { get; set; }
        public virtual DbSet<FORUM_Extension> FORUM_Extension { get; set; }
        public virtual DbSet<FORUM_FavoriteTopic> FORUM_FavoriteTopic { get; set; }
        public virtual DbSet<FORUM_Forum> FORUM_Forum { get; set; }
        public virtual DbSet<FORUM_ForumAccess> FORUM_ForumAccess { get; set; }
        public virtual DbSet<FORUM_Group> FORUM_Group { get; set; }
        public virtual DbSet<FORUM_IgnoreUser> FORUM_IgnoreUser { get; set; }
        public virtual DbSet<FORUM_Mail> FORUM_Mail { get; set; }
        public virtual DbSet<FORUM_Medal> FORUM_Medal { get; set; }
        public virtual DbSet<FORUM_Message> FORUM_Message { get; set; }
        public virtual DbSet<FORUM_NntpForum> FORUM_NntpForum { get; set; }
        public virtual DbSet<FORUM_NntpServer> FORUM_NntpServer { get; set; }
        public virtual DbSet<FORUM_NntpTopic> FORUM_NntpTopic { get; set; }
        public virtual DbSet<FORUM_PMessage> FORUM_PMessage { get; set; }
        public virtual DbSet<FORUM_Poll> FORUM_Poll { get; set; }
        public virtual DbSet<FORUM_PollGroupCluster> FORUM_PollGroupCluster { get; set; }
        public virtual DbSet<FORUM_PollVote> FORUM_PollVote { get; set; }
        public virtual DbSet<FORUM_prov_Application> FORUM_prov_Application { get; set; }
        public virtual DbSet<FORUM_prov_Membership> FORUM_prov_Membership { get; set; }
        public virtual DbSet<FORUM_prov_Profile> FORUM_prov_Profile { get; set; }
        public virtual DbSet<FORUM_prov_Role> FORUM_prov_Role { get; set; }
        public virtual DbSet<FORUM_Rank> FORUM_Rank { get; set; }
        public virtual DbSet<FORUM_Registry> FORUM_Registry { get; set; }
        public virtual DbSet<FORUM_Replace_Words> FORUM_Replace_Words { get; set; }
        public virtual DbSet<FORUM_ShoutboxMessage> FORUM_ShoutboxMessage { get; set; }
        public virtual DbSet<FORUM_Smiley> FORUM_Smiley { get; set; }
        public virtual DbSet<FORUM_Thanks> FORUM_Thanks { get; set; }
        public virtual DbSet<FORUM_Topic> FORUM_Topic { get; set; }
        public virtual DbSet<FORUM_User> FORUM_User { get; set; }
        public virtual DbSet<FORUM_UserAlbum> FORUM_UserAlbum { get; set; }
        public virtual DbSet<FORUM_UserAlbumImage> FORUM_UserAlbumImage { get; set; }
        public virtual DbSet<FORUM_UserForum> FORUM_UserForum { get; set; }
        public virtual DbSet<FORUM_UserPMessage> FORUM_UserPMessage { get; set; }
        public virtual DbSet<FORUM_WatchForum> FORUM_WatchForum { get; set; }
        public virtual DbSet<FORUM_WatchTopic> FORUM_WatchTopic { get; set; }
        public virtual DbSet<HTML_HtmlModule> HTML_HtmlModule { get; set; }
        public virtual DbSet<IST_Attachment> IST_Attachment { get; set; }
        public virtual DbSet<IST_Category> IST_Category { get; set; }
        public virtual DbSet<IST_Issue> IST_Issue { get; set; }
        public virtual DbSet<IST_Release> IST_Release { get; set; }
        public virtual DbSet<IST_Subscription> IST_Subscription { get; set; }
        public virtual DbSet<IST_Ticket> IST_Ticket { get; set; }
        public virtual DbSet<IST_TicketModules> IST_TicketModules { get; set; }
        public virtual DbSet<LOGREPORT_IgnorableItems> LOGREPORT_IgnorableItems { get; set; }
        public virtual DbSet<LOGREPORT_PageInterpreter> LOGREPORT_PageInterpreter { get; set; }
        public virtual DbSet<NEWS_Category> NEWS_Category { get; set; }
        public virtual DbSet<NEWS_NewsCategories> NEWS_NewsCategories { get; set; }
        public virtual DbSet<NEWS_News> NEWS_News { get; set; }
        public virtual DbSet<NEWS_Newsletter> NEWS_Newsletter { get; set; }
        public virtual DbSet<NEWS_NewsletterTemplate> NEWS_NewsletterTemplate { get; set; }
        public virtual DbSet<ObjectAccessRight> ObjectAccessRights { get; set; }
        public virtual DbSet<PORTAL_ActionValidation> PORTAL_ActionValidation { get; set; }
        public virtual DbSet<PORTAL_ESTIEMAlumniUser> PORTAL_ESTIEMAlumniUser { get; set; }
        public virtual DbSet<PORTAL_ESTIEMUser> PORTAL_ESTIEMUser { get; set; }
        public virtual DbSet<PORTAL_Module> PORTAL_Module { get; set; }
        public virtual DbSet<PORTAL_ModuleDefinition> PORTAL_ModuleDefinition { get; set; }
        public virtual DbSet<PORTAL_ModuleDefinitionType> PORTAL_ModuleDefinitionType { get; set; }
        public virtual DbSet<PORTAL_ModuleRolePermission> PORTAL_ModuleRolePermission { get; set; }
        public virtual DbSet<PORTAL_Page> PORTAL_Page { get; set; }
        public virtual DbSet<PORTAL_PageModule> PORTAL_PageModule { get; set; }
        public virtual DbSet<PORTAL_PageRolePermission> PORTAL_PageRolePermission { get; set; }
        public virtual DbSet<PORTAL_Portal> PORTAL_Portal { get; set; }
        public virtual DbSet<PORTAL_PortalUser> PORTAL_PortalUser { get; set; }
        public virtual DbSet<PORTAL_Role> PORTAL_Role { get; set; }
        public virtual DbSet<PORTAL_UrlAlias> PORTAL_UrlAlias { get; set; }
        public virtual DbSet<PORTAL_User> PORTAL_User { get; set; }
        public virtual DbSet<SERVICE_Log> SERVICE_Log { get; set; }
        public virtual DbSet<SERVICE_Settings> SERVICE_Settings { get; set; }
        public virtual DbSet<TAG_Tag> TAG_Tag { get; set; }
        public virtual DbSet<TAG_TagLink> TAG_TagLink { get; set; }
        public virtual DbSet<ALUMNI_EventParticipant> ALUMNI_EventParticipant { get; set; }
        public virtual DbSet<ESTIEM_UserHistory> ESTIEM_UserHistory { get; set; }
        public virtual DbSet<ESTIEM_UserLocalGroupx> ESTIEM_UserLocalGroupx { get; set; }
        public virtual DbSet<FORUM_GroupMedal> FORUM_GroupMedal { get; set; }
        public virtual DbSet<FORUM_MessageHistory> FORUM_MessageHistory { get; set; }
        public virtual DbSet<FORUM_MessageReported> FORUM_MessageReported { get; set; }
        public virtual DbSet<FORUM_MessageReportedAudit> FORUM_MessageReportedAudit { get; set; }
        public virtual DbSet<FORUM_prov_RoleMembership> FORUM_prov_RoleMembership { get; set; }
        public virtual DbSet<FORUM_UserMedal> FORUM_UserMedal { get; set; }
        public virtual DbSet<HTML_HtmlModuleAudit> HTML_HtmlModuleAudit { get; set; }
        public virtual DbSet<NEWS_NewsletterNews> NEWS_NewsletterNews { get; set; }
        public virtual DbSet<PORTAL_CustomPageProperties> PORTAL_CustomPageProperties { get; set; }
        public virtual DbSet<PORTAL_DeletionLog> PORTAL_DeletionLog { get; set; }
        public virtual DbSet<PORTAL_ModuleAudit> PORTAL_ModuleAudit { get; set; }
        public virtual DbSet<PORTAL_RoleExternalMember> PORTAL_RoleExternalMember { get; set; }
        public virtual DbSet<SEARCH_SearchLog> SEARCH_SearchLog { get; set; }
        public virtual DbSet<STAT_EVENTS_Participants> STAT_EVENTS_Participants { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TRIPADVISOR_Advises> TRIPADVISOR_Advises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALUMNI_Event>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNI_Event>()
                .Property(e => e.XmlValues)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNI_Event>()
                .HasMany(e => e.ALUMNI_EventParticipant)
                .WithRequired(e => e.ALUMNI_Event)
                .HasForeignKey(e => e.EventId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.MessageType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.EventId)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.Sender)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.Exception)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.ExtendedProperties)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationLog>()
                .Property(e => e.UrlReferrer)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Assets>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Assets>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Assets>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Assets>()
                .HasMany(e => e.CONFIGURATION_Data)
                .WithOptional(e => e.CONFIGURATION_Assets)
                .HasForeignKey(e => e.AssetId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CONFIGURATION_Data>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Keys>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Keys>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Keys>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Keys>()
                .HasMany(e => e.CONFIGURATION_Data)
                .WithRequired(e => e.CONFIGURATION_Keys)
                .HasForeignKey(e => e.KeyId);

            modelBuilder.Entity<CONFIGURATION_Scopes>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Scopes>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Scopes>()
                .HasMany(e => e.CONFIGURATION_Keys)
                .WithRequired(e => e.CONFIGURATION_Scopes)
                .HasForeignKey(e => e.ScopeId);

            modelBuilder.Entity<CONFIGURATION_Sets>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Sets>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURATION_Sets>()
                .HasMany(e => e.CONFIGURATION_Data)
                .WithRequired(e => e.CONFIGURATION_Sets)
                .HasForeignKey(e => e.SetId);

            modelBuilder.Entity<CONFIGURATION_Sets>()
                .HasMany(e => e.CONFIGURATION_Sets1)
                .WithOptional(e => e.CONFIGURATION_Sets2)
                .HasForeignKey(e => e.ParentSetId);

            modelBuilder.Entity<CONFIGURATION_Values>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_Country>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_Country>()
                .Property(e => e.Coordinates)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_Group>()
                .HasMany(e => e.PORTAL_User1)
                .WithMany(e => e.ESTIEM_Group1)
                .Map(m => m.ToTable("ESTIEM_GroupAuthorizedSender").MapLeftKey("GroupId").MapRightKey("UserId"));

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.Country)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.UniversityName)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.Coordinates)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.GPSLocation)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.LogoPath)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.HomePage)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_LocalGroup>()
                .HasMany(e => e.ESTIEM_Group)
                .WithOptional(e => e.ESTIEM_LocalGroup)
                .HasForeignKey(e => e.LocalGroupFilter);

            modelBuilder.Entity<ESTIEM_OldUser>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_RegionResponsible>()
                .Property(e => e.RegionName)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.Branche)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.Division)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.HomePage)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.LineOfBusiness)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.UserFunction)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.FieldOfWork)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserCompany>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.HomePage)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.Youtube)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.EmailListAlias)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .Property(e => e.XmlQuestions)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Events>()
                .HasMany(e => e.EVENTS_Participants)
                .WithRequired(e => e.EVENTS_Events)
                .HasForeignKey(e => e.EventID);

            modelBuilder.Entity<EVENTS_EventType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_EventType>()
                .Property(e => e.ImageLocation)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.MotivationText)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Visa_Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Visa_Surname)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Visa_Birthplace)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Visa_Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Visa_PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Visa_PassportIssuedBy)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.Visa_Address)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTS_Participants>()
                .Property(e => e.XmlAnswers)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_AccessMask>()
                .HasMany(e => e.FORUM_ForumAccess)
                .WithRequired(e => e.FORUM_AccessMask)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_AccessMask>()
                .HasMany(e => e.FORUM_UserForum)
                .WithRequired(e => e.FORUM_AccessMask)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Active>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_AccessMask)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_Active)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_BannedIP)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_BBCode)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_Category)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_Group)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_NntpServer)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_Rank)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_Registry)
                .WithOptional(e => e.FORUM_Board)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_Smiley)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Board>()
                .HasMany(e => e.FORUM_User)
                .WithRequired(e => e.FORUM_Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Category>()
                .HasMany(e => e.FORUM_Forum)
                .WithRequired(e => e.FORUM_Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Choice>()
                .Property(e => e.MimeType)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_Forum>()
                .HasMany(e => e.FORUM_Forum1)
                .WithOptional(e => e.FORUM_Forum2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<FORUM_Forum>()
                .HasMany(e => e.FORUM_ForumAccess)
                .WithRequired(e => e.FORUM_Forum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Forum>()
                .HasMany(e => e.FORUM_NntpForum)
                .WithRequired(e => e.FORUM_Forum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Forum>()
                .HasMany(e => e.FORUM_Topic1)
                .WithRequired(e => e.FORUM_Forum1)
                .HasForeignKey(e => e.ForumID);

            modelBuilder.Entity<FORUM_Forum>()
                .HasMany(e => e.FORUM_UserForum)
                .WithRequired(e => e.FORUM_Forum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Forum>()
                .HasMany(e => e.FORUM_WatchForum)
                .WithRequired(e => e.FORUM_Forum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Group>()
                .HasMany(e => e.FORUM_ForumAccess)
                .WithRequired(e => e.FORUM_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Group>()
                .HasMany(e => e.FORUM_User)
                .WithMany(e => e.FORUM_Group)
                .Map(m => m.ToTable("FORUM_UserGroup").MapLeftKey("GroupID").MapRightKey("UserID"));

            modelBuilder.Entity<FORUM_Message>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_Message>()
                .HasMany(e => e.FORUM_Attachment)
                .WithRequired(e => e.FORUM_Message)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Message>()
                .HasMany(e => e.FORUM_Forum)
                .WithOptional(e => e.FORUM_Message)
                .HasForeignKey(e => e.LastMessageID);

            modelBuilder.Entity<FORUM_Message>()
                .HasMany(e => e.FORUM_Message1)
                .WithOptional(e => e.FORUM_Message2)
                .HasForeignKey(e => e.ReplyTo);

            modelBuilder.Entity<FORUM_Message>()
                .HasMany(e => e.FORUM_Topic1)
                .WithOptional(e => e.FORUM_Message1)
                .HasForeignKey(e => e.LastMessageID);

            modelBuilder.Entity<FORUM_NntpForum>()
                .HasMany(e => e.FORUM_NntpTopic)
                .WithRequired(e => e.FORUM_NntpForum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_NntpServer>()
                .HasMany(e => e.FORUM_NntpForum)
                .WithRequired(e => e.FORUM_NntpServer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_NntpTopic>()
                .Property(e => e.Thread)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_PMessage>()
                .HasMany(e => e.FORUM_UserPMessage)
                .WithRequired(e => e.FORUM_PMessage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Poll>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_Poll>()
                .Property(e => e.MimeType)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_Poll>()
                .HasMany(e => e.FORUM_Choice)
                .WithRequired(e => e.FORUM_Poll)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_PollGroupCluster>()
                .HasMany(e => e.FORUM_Poll)
                .WithOptional(e => e.FORUM_PollGroupCluster)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FORUM_PollGroupCluster>()
                .HasMany(e => e.FORUM_Topic)
                .WithOptional(e => e.FORUM_PollGroupCluster)
                .HasForeignKey(e => e.PollID);

            modelBuilder.Entity<FORUM_PollVote>()
                .Property(e => e.RemoteIP)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_Rank>()
                .HasMany(e => e.FORUM_User)
                .WithRequired(e => e.FORUM_Rank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_ShoutboxMessage>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_Topic>()
                .HasMany(e => e.FORUM_FavoriteTopic)
                .WithRequired(e => e.FORUM_Topic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Topic>()
                .HasMany(e => e.FORUM_Forum)
                .WithOptional(e => e.FORUM_Topic)
                .HasForeignKey(e => e.LastTopicID);

            modelBuilder.Entity<FORUM_Topic>()
                .HasMany(e => e.FORUM_Message)
                .WithRequired(e => e.FORUM_Topic)
                .HasForeignKey(e => e.TopicID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Topic>()
                .HasMany(e => e.FORUM_NntpTopic)
                .WithRequired(e => e.FORUM_Topic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_Topic>()
                .HasMany(e => e.FORUM_Topic1)
                .WithOptional(e => e.FORUM_Topic2)
                .HasForeignKey(e => e.TopicMovedID);

            modelBuilder.Entity<FORUM_Topic>()
                .HasMany(e => e.FORUM_WatchTopic)
                .WithRequired(e => e.FORUM_Topic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_User>()
                .Property(e => e.Culture)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_Active)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_Buddy)
                .WithRequired(e => e.FORUM_User)
                .HasForeignKey(e => e.FromUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_CheckEmail)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_EventLog)
                .WithOptional(e => e.FORUM_User)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_FavoriteTopic)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_Forum)
                .WithOptional(e => e.FORUM_User)
                .HasForeignKey(e => e.LastUserID);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_Message)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_PMessage)
                .WithRequired(e => e.FORUM_User)
                .HasForeignKey(e => e.FromUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_Thanks)
                .WithRequired(e => e.FORUM_User)
                .HasForeignKey(e => e.ThanksFromUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_Topic)
                .WithRequired(e => e.FORUM_User)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_Topic1)
                .WithOptional(e => e.FORUM_User1)
                .HasForeignKey(e => e.LastUserID);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_UserForum)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_UserPMessage)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_WatchForum)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_User>()
                .HasMany(e => e.FORUM_WatchTopic)
                .WithRequired(e => e.FORUM_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORUM_UserAlbum>()
                .HasMany(e => e.FORUM_UserAlbumImage)
                .WithRequired(e => e.FORUM_UserAlbum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IST_Attachment>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Attachment>()
                .Property(e => e.CONTENTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Attachment>()
                .Property(e => e.TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Attachment>()
                .Property(e => e.REFERENCE)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Attachment>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Category>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Category>()
                .Property(e => e.CategoryType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.FormData)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.STACKTRACE)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.OTHER)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Issue>()
                .Property(e => e.URLREFERRER)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Release>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Release>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Release>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Subscription>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Ticket>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Ticket>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Ticket>()
                .Property(e => e.KEY)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Ticket>()
                .Property(e => e.DEPLOYMENTNOTES)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Ticket>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<IST_Ticket>()
                .Property(e => e.AssignedUser)
                .IsUnicode(false);

            modelBuilder.Entity<LOGREPORT_IgnorableItems>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_News>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_News>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_News>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_News>()
                .Property(e => e.Preview)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_News>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_Newsletter>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_Newsletter>()
                .Property(e => e.GroupKey)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS_NewsletterTemplate>()
                .Property(e => e.Templatetitle)
                .IsUnicode(false);

            modelBuilder.Entity<ObjectAccessRight>()
                .Property(e => e.GroupKey)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ActionValidation>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMAlumniUser>()
                .Property(e => e.ContributionInfoXml)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.FirstNameEnglish)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.LastNameEnglish)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.BirthName)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.SkypeName)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Hometown)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Visa_Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Visa_Surname)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Visa_Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Visa_PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Visa_PassportIssuedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ESTIEMUser>()
                .Property(e => e.Visa_Birthplace)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Module>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Module>()
                .Property(e => e.Configuration)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Module>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Module>()
                .Property(e => e.CustomConfiguration)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Module>()
                .HasMany(e => e.PORTAL_ModuleRolePermission)
                .WithRequired(e => e.PORTAL_Module)
                .HasForeignKey(e => e.ModuleId);

            modelBuilder.Entity<PORTAL_Module>()
                .HasMany(e => e.PORTAL_PageModule)
                .WithRequired(e => e.PORTAL_Module)
                .HasForeignKey(e => e.ModuleId);

            modelBuilder.Entity<PORTAL_ModuleDefinition>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ModuleDefinition>()
                .Property(e => e.Src)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ModuleDefinition>()
                .HasMany(e => e.PORTAL_Module)
                .WithRequired(e => e.PORTAL_ModuleDefinition)
                .HasForeignKey(e => e.ModuleDefinitionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PORTAL_ModuleDefinitionType>()
                .HasMany(e => e.PORTAL_ModuleDefinition)
                .WithOptional(e => e.PORTAL_ModuleDefinitionType)
                .HasForeignKey(e => e.ModuleDefinitionTypeId);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.RedirectUrl)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.MetaRobots)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.MetaExpires)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.ReviewSettings)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.Configuration)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .Property(e => e.Keywords)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Page>()
                .HasMany(e => e.PORTAL_PageModule)
                .WithRequired(e => e.PORTAL_Page)
                .HasForeignKey(e => e.PageId);

            modelBuilder.Entity<PORTAL_Page>()
                .HasMany(e => e.PORTAL_PageRolePermission)
                .WithRequired(e => e.PORTAL_Page)
                .HasForeignKey(e => e.PageId);

            modelBuilder.Entity<PORTAL_Portal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .Property(e => e.Cultures)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .Property(e => e.PageColors)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .Property(e => e.LogoLinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .HasMany(e => e.PORTAL_Module)
                .WithRequired(e => e.PORTAL_Portal)
                .HasForeignKey(e => e.PortalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .HasMany(e => e.PORTAL_Page)
                .WithRequired(e => e.PORTAL_Portal)
                .HasForeignKey(e => e.PortalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PORTAL_Portal>()
                .HasMany(e => e.PORTAL_PortalUser)
                .WithRequired(e => e.PORTAL_Portal)
                .HasForeignKey(e => e.PortalId);

            modelBuilder.Entity<PORTAL_Portal>()
                .HasMany(e => e.PORTAL_Role)
                .WithMany(e => e.PORTAL_Portal)
                .Map(m => m.ToTable("PORTAL_PortalRole").MapLeftKey("PortalId").MapRightKey("RoleId"));

            modelBuilder.Entity<PORTAL_Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_Role>()
                .HasOptional(e => e.ESTIEM_Group)
                .WithRequired(e => e.PORTAL_Role)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PORTAL_Role>()
                .HasMany(e => e.PORTAL_ModuleRolePermission)
                .WithRequired(e => e.PORTAL_Role)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<PORTAL_Role>()
                .HasMany(e => e.PORTAL_PageRolePermission)
                .WithRequired(e => e.PORTAL_Role)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<PORTAL_Role>()
                .HasMany(e => e.PORTAL_RoleExternalMember)
                .WithRequired(e => e.PORTAL_Role)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<PORTAL_Role>()
                .HasMany(e => e.PORTAL_User)
                .WithMany(e => e.PORTAL_Role)
                .Map(m => m.ToTable("PORTAL_RoleMember").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<PORTAL_UrlAlias>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_UrlAlias>()
                .Property(e => e.Parameter)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_UrlAlias>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_User>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_User>()
                .HasMany(e => e.ESTIEM_CorporateInfo)
                .WithRequired(e => e.PORTAL_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<PORTAL_User>()
                .HasMany(e => e.ESTIEM_Group)
                .WithOptional(e => e.PORTAL_User)
                .HasForeignKey(e => e.AdminUserId);

            modelBuilder.Entity<PORTAL_User>()
                .HasMany(e => e.ESTIEM_TeamRelation)
                .WithRequired(e => e.PORTAL_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<PORTAL_User>()
                .HasMany(e => e.PORTAL_ActionValidation)
                .WithRequired(e => e.PORTAL_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<PORTAL_User>()
                .HasMany(e => e.PORTAL_PortalUser)
                .WithRequired(e => e.PORTAL_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<SERVICE_Log>()
                .Property(e => e.ServiceId)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE_Log>()
                .Property(e => e.LogName)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE_Log>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE_Log>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE_Settings>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE_Settings>()
                .Property(e => e.Assembly)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE_Settings>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<TAG_Tag>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TAG_Tag>()
                .HasMany(e => e.TAG_TagLink)
                .WithRequired(e => e.TAG_Tag)
                .HasForeignKey(e => e.TagId);

            modelBuilder.Entity<TAG_TagLink>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<TAG_TagLink>()
                .Property(e => e.ItemTypeKey)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNI_EventParticipant>()
                .Property(e => e.UserFreeText)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNI_EventParticipant>()
                .Property(e => e.XmlValues)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.ChangedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.GivenName)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.FamilyName)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.FirstNameEnglish)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.LastNameEnglish)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.BirthName)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.ImageChange)
                .IsUnicode(false);

            modelBuilder.Entity<ESTIEM_UserHistory>()
                .Property(e => e.Stamp)
                .IsFixedLength();

            modelBuilder.Entity<FORUM_MessageHistory>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<HTML_HtmlModuleAudit>()
                .Property(e => e.Action)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_CustomPageProperties>()
                .Property(e => e.BannerUrl)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_CustomPageProperties>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_DeletionLog>()
                .Property(e => e.RealDeletingUserName)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_DeletionLog>()
                .Property(e => e.ObjectType)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_DeletionLog>()
                .Property(e => e.ObjectName)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_ModuleAudit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PORTAL_RoleExternalMember>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SEARCH_SearchLog>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<SEARCH_SearchLog>()
                .Property(e => e.Action)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEARCH_SearchLog>()
                .Property(e => e.SearchText)
                .IsUnicode(false);

            modelBuilder.Entity<TRIPADVISOR_Advises>()
                .Property(e => e.NameOfPlace)
                .IsUnicode(false);

            modelBuilder.Entity<TRIPADVISOR_Advises>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<TRIPADVISOR_Advises>()
                .Property(e => e.Category)
                .IsUnicode(false);
        }
    }
}
