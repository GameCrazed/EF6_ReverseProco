

namespace Generator
{

    public class MSsubscriptionAgentMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MSsubscriptionAgent>
    {
        public MSsubscriptionAgentMapping()
            : this("dbo")
        {
        }

        public MSsubscriptionAgentMapping(string schema)
        {
            ToTable("MSsubscription_agents", schema);
            HasKey(x => new { x.Id, x.Publisher, x.PublisherDb, x.Publication, x.SubscriptionType, x.UpdateMode, x.FailoverMode, x.Spid, x.LoginTime, x.AllowSubscriptionCopy, x.AttachState, x.AttachVersion });

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Publisher).HasColumnName(@"publisher").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PublisherDb).HasColumnName(@"publisher_db").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Publication).HasColumnName(@"publication").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SubscriptionType).HasColumnName(@"subscription_type").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.QueueId).HasColumnName(@"queue_id").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.UpdateMode).HasColumnName(@"update_mode").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FailoverMode).HasColumnName(@"failover_mode").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Spid).HasColumnName(@"spid").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LoginTime).HasColumnName(@"login_time").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AllowSubscriptionCopy).HasColumnName(@"allow_subscription_copy").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AttachState).HasColumnName(@"attach_state").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AttachVersion).HasColumnName(@"attach_version").HasColumnType("binary").IsRequired().HasMaxLength(16).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LastSyncStatus).HasColumnName(@"last_sync_status").HasColumnType("int").IsOptional();
            Property(x => x.LastSyncSummary).HasColumnName(@"last_sync_summary").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.LastSyncTime).HasColumnName(@"last_sync_time").HasColumnType("datetime").IsOptional();
            Property(x => x.QueueServer).HasColumnName(@"queue_server").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
        }
    }

}
