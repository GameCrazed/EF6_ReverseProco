

namespace Generator
{

    public class CfinMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cfin>
    {
        public CfinMapping()
            : this("dbo")
        {
        }

        public CfinMapping(string schema)
        {
            ToTable("CFIN", schema);
            HasKey(x => new { x.Cfin010, x.Cfin050 });

            Property(x => x.Cfin010).HasColumnName(@"CFIN010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cfin020).HasColumnName(@"CFIN020").HasColumnType("datetime").IsRequired();
            Property(x => x.Cfin030).HasColumnName(@"CFIN030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cfin035).HasColumnName(@"CFIN035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Cfin040).HasColumnName(@"CFIN040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cfin050).HasColumnName(@"CFIN050").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cfin060).HasColumnName(@"CFIN060").HasColumnType("datetime").IsRequired();
            Property(x => x.Cfin080).HasColumnName(@"CFIN080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Cfin100).HasColumnName(@"CFIN100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cfin110).HasColumnName(@"CFIN110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cfin112).HasColumnName(@"CFIN112").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cfin114).HasColumnName(@"CFIN114").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cfin120).HasColumnName(@"CFIN120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cfin130).HasColumnName(@"CFIN130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cfin150).HasColumnName(@"CFIN150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Cfin1601).HasColumnName(@"CFIN1601").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1602).HasColumnName(@"CFIN1602").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1603).HasColumnName(@"CFIN1603").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1604).HasColumnName(@"CFIN1604").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1605).HasColumnName(@"CFIN1605").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin165).HasColumnName(@"CFIN165").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Cfin170).HasColumnName(@"CFIN170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cfin180).HasColumnName(@"CFIN180").HasColumnType("int").IsRequired();
            Property(x => x.Cfin140).HasColumnName(@"CFIN140").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(210);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cfindtm).HasColumnName(@"CFINDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Cfin1611).HasColumnName(@"CFIN1611").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1612).HasColumnName(@"CFIN1612").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1613).HasColumnName(@"CFIN1613").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1614).HasColumnName(@"CFIN1614").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cfin1615).HasColumnName(@"CFIN1615").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
