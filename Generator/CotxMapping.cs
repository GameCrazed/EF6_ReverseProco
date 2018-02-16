

namespace Generator
{

    public class CotxMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cotx>
    {
        public CotxMapping()
            : this("dbo")
        {
        }

        public CotxMapping(string schema)
        {
            ToTable("COTX", schema);
            HasKey(x => x.Cotx010);

            Property(x => x.Cotx010).HasColumnName(@"COTX010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cotx100).HasColumnName(@"COTX100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Cotx110).HasColumnName(@"COTX110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Cotx150).HasColumnName(@"COTX150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cotx160).HasColumnName(@"COTX160").HasColumnType("int").IsRequired();
            Property(x => x.Cotx170).HasColumnName(@"COTX170").HasColumnType("int").IsRequired();
            Property(x => x.Cotx200).HasColumnName(@"COTX200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cotx201).HasColumnName(@"COTX201").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cotx202).HasColumnName(@"COTX202").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cotx203).HasColumnName(@"COTX203").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(77);
            Property(x => x.Cotx2101).HasColumnName(@"COTX2101").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cotx2102).HasColumnName(@"COTX2102").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cotx2103).HasColumnName(@"COTX2103").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cotx2104).HasColumnName(@"COTX2104").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cotx2105).HasColumnName(@"COTX2105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cotx1301).HasColumnName(@"COTX1301").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Cotx1302).HasColumnName(@"COTX1302").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Cotx1303).HasColumnName(@"COTX1303").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Cotx1304).HasColumnName(@"COTX1304").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Cotx300).HasColumnName(@"COTX300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cotxdtm).HasColumnName(@"COTXDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Cotx205).HasColumnName(@"COTX205").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cotx115).HasColumnName(@"COTX115").HasColumnType("int").IsRequired();
            Property(x => x.Cotx400).HasColumnName(@"COTX400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cotx401).HasColumnName(@"COTX401").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cotx402).HasColumnName(@"COTX402").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cotx206).HasColumnName(@"COTX206").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Cotx403).HasColumnName(@"COTX403").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cotx500).HasColumnName(@"COTX500").HasColumnType("datetime").IsRequired();
            Property(x => x.Cotx501).HasColumnName(@"COTX501").HasColumnType("datetime").IsRequired();
        }
    }

}
