

namespace Generator
{

    public class UndcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Undc>
    {
        public UndcMapping()
            : this("dbo")
        {
        }

        public UndcMapping(string schema)
        {
            ToTable("UNDC", schema);
            HasKey(x => x.Undc999);

            Property(x => x.Undc001).HasColumnName(@"UNDC001").HasColumnType("int").IsRequired();
            Property(x => x.Undc005).HasColumnName(@"UNDC005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Undc010).HasColumnName(@"UNDC010").HasColumnType("smallint").IsRequired();
            Property(x => x.Undc020).HasColumnName(@"UNDC020").HasColumnType("int").IsRequired();
            Property(x => x.Undc030).HasColumnName(@"UNDC030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Undc035).HasColumnName(@"UNDC035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Undc040).HasColumnName(@"UNDC040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Undc045).HasColumnName(@"UNDC045").HasColumnType("datetime").IsRequired();
            Property(x => x.Undc050).HasColumnName(@"UNDC050").HasColumnType("datetime").IsRequired();
            Property(x => x.Undc060).HasColumnName(@"UNDC060").HasColumnType("smallint").IsRequired();
            Property(x => x.Undc070).HasColumnName(@"UNDC070").HasColumnType("datetime").IsRequired();
            Property(x => x.Undc100).HasColumnName(@"UNDC100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Undc999).HasColumnName(@"UNDC999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
