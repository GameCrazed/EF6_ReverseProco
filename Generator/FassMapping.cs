

namespace Generator
{

    public class FassMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fass>
    {
        public FassMapping()
            : this("dbo")
        {
        }

        public FassMapping(string schema)
        {
            ToTable("FASS", schema);
            HasKey(x => x.Fass001);

            Property(x => x.Fass001).HasColumnName(@"FASS001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fass005).HasColumnName(@"FASS005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fass006).HasColumnName(@"FASS006").HasColumnType("int").IsRequired();
            Property(x => x.Fass010).HasColumnName(@"FASS010").HasColumnType("int").IsRequired();
            Property(x => x.Fass015).HasColumnName(@"FASS015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fass020).HasColumnName(@"FASS020").HasColumnType("datetime").IsRequired();
            Property(x => x.Fass025).HasColumnName(@"FASS025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fass027).HasColumnName(@"FASS027").HasColumnType("datetime").IsRequired();
            Property(x => x.Fass030).HasColumnName(@"FASS030").HasColumnType("int").IsRequired();
            Property(x => x.Fass046).HasColumnName(@"FASS046").HasColumnType("int").IsRequired();
            Property(x => x.Fass050).HasColumnName(@"FASS050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fass055).HasColumnName(@"FASS055").HasColumnType("datetime").IsRequired();
            Property(x => x.Fass060).HasColumnName(@"FASS060").HasColumnType("datetime").IsRequired();
            Property(x => x.Fass080).HasColumnName(@"FASS080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fass085).HasColumnName(@"FASS085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fass090).HasColumnName(@"FASS090").HasColumnType("int").IsRequired();
            Property(x => x.Fass100).HasColumnName(@"FASS100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fass110).HasColumnName(@"FASS110").HasColumnType("int").IsRequired();
            Property(x => x.Fass115).HasColumnName(@"FASS115").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Fass120).HasColumnName(@"FASS120").HasColumnType("int").IsRequired();
            Property(x => x.Fass150).HasColumnName(@"FASS150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Fass300).HasColumnName(@"FASS300").HasColumnType("int").IsRequired();
            Property(x => x.Fass200).HasColumnName(@"FASS200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Fass500).HasColumnName(@"FASS500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(490);
            Property(x => x.Fassdtm).HasColumnName(@"FASSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Fass003).HasColumnName(@"FASS003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Fass040).HasColumnName(@"FASS040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Fass045).HasColumnName(@"FASS045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Fass170).HasColumnName(@"FASS170").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fass210).HasColumnName(@"FASS210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Fass162).HasColumnName(@"FASS162").HasColumnType("int").IsRequired();
            Property(x => x.Fass175).HasColumnName(@"FASS175").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fass160).HasColumnName(@"FASS160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Fass215).HasColumnName(@"FASS215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fass400).HasColumnName(@"FASS400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Fass220).HasColumnName(@"FASS220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
        }
    }

}
