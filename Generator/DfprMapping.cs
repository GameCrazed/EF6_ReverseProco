

namespace Generator
{

    public class DfprMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dfpr>
    {
        public DfprMapping()
            : this("dbo")
        {
        }

        public DfprMapping(string schema)
        {
            ToTable("DFPR", schema);
            HasKey(x => x.Dfpr001);

            Property(x => x.Dfpr001).HasColumnName(@"DFPR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Dfpr003).HasColumnName(@"DFPR003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dfpr010).HasColumnName(@"DFPR010").HasColumnType("int").IsRequired();
            Property(x => x.Dfpr015).HasColumnName(@"DFPR015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Dfpr020).HasColumnName(@"DFPR020").HasColumnType("datetime").IsRequired();
            Property(x => x.Dfpr500).HasColumnName(@"DFPR500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(500);
        }
    }

}
