

namespace Generator
{

    public class JlogMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Jlog>
    {
        public JlogMapping()
            : this("dbo")
        {
        }

        public JlogMapping(string schema)
        {
            ToTable("JLOG", schema);
            HasKey(x => x.Jlog999);

            Property(x => x.Jlog010).HasColumnName(@"JLOG010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Jlog020).HasColumnName(@"JLOG020").HasColumnType("datetime").IsRequired();
            Property(x => x.Jlog030).HasColumnName(@"JLOG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Jlog040).HasColumnName(@"JLOG040").HasColumnType("int").IsRequired();
            Property(x => x.Jlog050).HasColumnName(@"JLOG050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Jlog999).HasColumnName(@"JLOG999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Jlogdtm).HasColumnName(@"JLOGDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Jlog035).HasColumnName(@"JLOG035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Jlog060).HasColumnName(@"JLOG060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Jlog070).HasColumnName(@"JLOG070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
        }
    }

}
