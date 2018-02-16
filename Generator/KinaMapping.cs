

namespace Generator
{

    public class KinaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Kina>
    {
        public KinaMapping()
            : this("dbo")
        {
        }

        public KinaMapping(string schema)
        {
            ToTable("KINA", schema);
            HasKey(x => new { x.Kina001, x.Kina020 });

            Property(x => x.Kina001).HasColumnName(@"KINA001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kina010).HasColumnName(@"KINA010").HasColumnType("int").IsRequired();
            Property(x => x.Kina020).HasColumnName(@"KINA020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kina021).HasColumnName(@"KINA021").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Kina030).HasColumnName(@"KINA030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kina035).HasColumnName(@"KINA035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kina040).HasColumnName(@"KINA040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kina050).HasColumnName(@"KINA050").HasColumnType("smallint").IsRequired();
            Property(x => x.Kina060).HasColumnName(@"KINA060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kina061).HasColumnName(@"KINA061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Kina070).HasColumnName(@"KINA070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kina080).HasColumnName(@"KINA080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Kina090).HasColumnName(@"KINA090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kina091).HasColumnName(@"KINA091").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kina092).HasColumnName(@"KINA092").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Kina100).HasColumnName(@"KINA100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kina120).HasColumnName(@"KINA120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Kina130).HasColumnName(@"KINA130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kina150).HasColumnName(@"KINA150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kina065).HasColumnName(@"KINA065").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kina067).HasColumnName(@"KINA067").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kina170).HasColumnName(@"KINA170").HasColumnType("int").IsRequired();
            Property(x => x.Kina180).HasColumnName(@"KINA180").HasColumnType("int").IsRequired();
            Property(x => x.Kina160).HasColumnName(@"KINA160").HasColumnType("int").IsRequired();
            Property(x => x.Kina190).HasColumnName(@"KINA190").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
