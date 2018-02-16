

namespace Generator
{

    public class GuidMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Guid>
    {
        public GuidMapping()
            : this("dbo")
        {
        }

        public GuidMapping(string schema)
        {
            ToTable("GUID", schema);
            HasKey(x => x.Guid001);

            Property(x => x.Guid001).HasColumnName(@"GUID001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Guid005).HasColumnName(@"GUID005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Guid010).HasColumnName(@"GUID010").HasColumnType("datetime").IsRequired();
            Property(x => x.Guid020).HasColumnName(@"GUID020").HasColumnType("int").IsRequired();
            Property(x => x.Guid025).HasColumnName(@"GUID025").HasColumnType("int").IsRequired();
            Property(x => x.Guid030).HasColumnName(@"GUID030").HasColumnType("int").IsRequired();
            Property(x => x.Guid035).HasColumnName(@"GUID035").HasColumnType("int").IsRequired();
            Property(x => x.Guid050).HasColumnName(@"GUID050").HasColumnType("datetime").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Guiddtm).HasColumnName(@"GUIDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
