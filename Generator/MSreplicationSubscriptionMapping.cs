

namespace Generator
{

    public class MSreplicationSubscriptionMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MSreplicationSubscription>
    {
        public MSreplicationSubscriptionMapping()
            : this("dbo")
        {
        }

        public MSreplicationSubscriptionMapping(string schema)
        {
            ToTable("MSreplication_subscriptions", schema);
            HasKey(x => new { x.Publisher, x.IndependentAgent, x.SubscriptionType, x.Time, x.TransactionTimestamp, x.UpdateMode, x.ImmediateSync });

            Property(x => x.Publisher).HasColumnName(@"publisher").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PublisherDb).HasColumnName(@"publisher_db").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Publication).HasColumnName(@"publication").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.IndependentAgent).HasColumnName(@"independent_agent").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SubscriptionType).HasColumnName(@"subscription_type").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DistributionAgent).HasColumnName(@"distribution_agent").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Time).HasColumnName(@"time").HasColumnType("smalldatetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.TransactionTimestamp).HasColumnName(@"transaction_timestamp").HasColumnType("varbinary").IsRequired().HasMaxLength(16).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UpdateMode).HasColumnName(@"update_mode").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AgentId).HasColumnName(@"agent_id").HasColumnType("binary").IsOptional().HasMaxLength(16);
            Property(x => x.SubscriptionGuid).HasColumnName(@"subscription_guid").HasColumnType("binary").IsOptional().HasMaxLength(16);
            Property(x => x.Subid).HasColumnName(@"subid").HasColumnType("binary").IsOptional().HasMaxLength(16);
            Property(x => x.ImmediateSync).HasColumnName(@"immediate_sync").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
