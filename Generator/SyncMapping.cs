

namespace Generator
{

    public class SyncMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sync>
    {
        public SyncMapping()
            : this("dbo")
        {
        }

        public SyncMapping(string schema)
        {
            ToTable("SYNC", schema);
            HasKey(x => x.Sync001);

            Property(x => x.Sync001).HasColumnName(@"SYNC001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Sync010).HasColumnName(@"SYNC010").HasColumnType("datetime").IsRequired();
            Property(x => x.Sync020).HasColumnName(@"SYNC020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
