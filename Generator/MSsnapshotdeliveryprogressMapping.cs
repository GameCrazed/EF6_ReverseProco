

namespace Generator
{

    public class MSsnapshotdeliveryprogressMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MSsnapshotdeliveryprogress>
    {
        public MSsnapshotdeliveryprogressMapping()
            : this("dbo")
        {
        }

        public MSsnapshotdeliveryprogressMapping(string schema)
        {
            ToTable("MSsnapshotdeliveryprogress", schema);
            HasKey(x => new { x.SessionToken, x.ProgressTokenHash, x.ProgressToken });

            Property(x => x.SessionToken).HasColumnName(@"session_token").HasColumnType("nvarchar").IsRequired().HasMaxLength(260).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProgressTokenHash).HasColumnName(@"progress_token_hash").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProgressToken).HasColumnName(@"progress_token").HasColumnType("nvarchar").IsRequired().HasMaxLength(500).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProgressTimestamp).HasColumnName(@"progress_timestamp").HasColumnType("datetime").IsOptional();
        }
    }

}
