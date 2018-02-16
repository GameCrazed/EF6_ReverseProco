

namespace Generator
{

    public class ScvrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Scvr>
    {
        public ScvrMapping()
            : this("dbo")
        {
        }

        public ScvrMapping(string schema)
        {
            ToTable("SCVR", schema);
            HasKey(x => x.Scvr999);

            Property(x => x.Scvr001).HasColumnName(@"SCVR001").HasColumnType("int").IsRequired();
            Property(x => x.Scvr010).HasColumnName(@"SCVR010").HasColumnType("datetime").IsRequired();
            Property(x => x.Scvr020).HasColumnName(@"SCVR020").HasColumnType("int").IsRequired();
            Property(x => x.Scvr030).HasColumnName(@"SCVR030").HasColumnType("int").IsRequired();
            Property(x => x.Scvr031).HasColumnName(@"SCVR031").HasColumnType("int").IsRequired();
            Property(x => x.Scvr032).HasColumnName(@"SCVR032").HasColumnType("int").IsRequired();
            Property(x => x.Scvr033).HasColumnName(@"SCVR033").HasColumnType("int").IsRequired();
            Property(x => x.Scvr034).HasColumnName(@"SCVR034").HasColumnType("int").IsRequired();
            Property(x => x.Scvr035).HasColumnName(@"SCVR035").HasColumnType("int").IsRequired();
            Property(x => x.Scvr990).HasColumnName(@"SCVR990").HasColumnType("datetime").IsRequired();
            Property(x => x.Scvr991).HasColumnName(@"SCVR991").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Scvr999).HasColumnName(@"SCVR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
