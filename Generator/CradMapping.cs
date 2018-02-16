

namespace Generator
{

    public class CradMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Crad>
    {
        public CradMapping()
            : this("dbo")
        {
        }

        public CradMapping(string schema)
        {
            ToTable("CRAD", schema);
            HasKey(x => x.Crad001);

            Property(x => x.Crad001).HasColumnName(@"CRAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Crad010).HasColumnName(@"CRAD010").HasColumnType("datetime").IsRequired();
            Property(x => x.Crad020).HasColumnName(@"CRAD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Crad030).HasColumnName(@"CRAD030").HasColumnType("int").IsRequired();
            Property(x => x.Crad040).HasColumnName(@"CRAD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Crad046).HasColumnName(@"CRAD046").HasColumnType("int").IsRequired();
            Property(x => x.Crad050).HasColumnName(@"CRAD050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Crad060).HasColumnName(@"CRAD060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Crad100).HasColumnName(@"CRAD100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Crad110).HasColumnName(@"CRAD110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crad120).HasColumnName(@"CRAD120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crad130).HasColumnName(@"CRAD130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Crad140).HasColumnName(@"CRAD140").HasColumnType("datetime").IsRequired();
            Property(x => x.Crad150).HasColumnName(@"CRAD150").HasColumnType("smallint").IsRequired();
            Property(x => x.Crad160).HasColumnName(@"CRAD160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Crad170).HasColumnName(@"CRAD170").HasColumnType("datetime").IsRequired();
            Property(x => x.Crad180).HasColumnName(@"CRAD180").HasColumnType("smallint").IsRequired();
            Property(x => x.Crad190).HasColumnName(@"CRAD190").HasColumnType("smallint").IsRequired();
            Property(x => x.Crad200).HasColumnName(@"CRAD200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Crad210).HasColumnName(@"CRAD210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Crad220).HasColumnName(@"CRAD220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Crad300).HasColumnName(@"CRAD300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Craddtm).HasColumnName(@"CRADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Crad070).HasColumnName(@"CRAD070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crad080).HasColumnName(@"CRAD080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Crad090).HasColumnName(@"CRAD090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crad084).HasColumnName(@"CRAD084").HasColumnType("smallint").IsRequired();
            Property(x => x.Crad087).HasColumnName(@"CRAD087").HasColumnType("smallint").IsRequired();
            Property(x => x.Crad088).HasColumnName(@"CRAD088").HasColumnType("smallint").IsRequired();
        }
    }

}
