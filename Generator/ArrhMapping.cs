

namespace Generator
{

    public class ArrhMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Arrh>
    {
        public ArrhMapping()
            : this("dbo")
        {
        }

        public ArrhMapping(string schema)
        {
            ToTable("ARRH", schema);
            HasKey(x => x.Arrh000);

            Property(x => x.Arrh000).HasColumnName(@"ARRH000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Arrh001).HasColumnName(@"ARRH001").HasColumnType("int").IsRequired();
            Property(x => x.Arrh010).HasColumnName(@"ARRH010").HasColumnType("int").IsRequired();
            Property(x => x.Arrh015).HasColumnName(@"ARRH015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Arrh020).HasColumnName(@"ARRH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Arrh030).HasColumnName(@"ARRH030").HasColumnType("int").IsRequired();
            Property(x => x.Arrh035).HasColumnName(@"ARRH035").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Arrh040).HasColumnName(@"ARRH040").HasColumnType("smallint").IsRequired();
            Property(x => x.Arrh050).HasColumnName(@"ARRH050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Arrh060).HasColumnName(@"ARRH060").HasColumnType("datetime").IsRequired();
            Property(x => x.Arrh070).HasColumnName(@"ARRH070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Arrh080).HasColumnName(@"ARRH080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Arrh090).HasColumnName(@"ARRH090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Arrh095).HasColumnName(@"ARRH095").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Arrh100).HasColumnName(@"ARRH100").HasColumnType("int").IsRequired();
            Property(x => x.Arrh101).HasColumnName(@"ARRH101").HasColumnType("int").IsRequired();
            Property(x => x.Arrh110).HasColumnName(@"ARRH110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Arrh150).HasColumnName(@"ARRH150").HasColumnType("int").IsRequired();
            Property(x => x.Arrh200).HasColumnName(@"ARRH200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Arrhdtm).HasColumnName(@"ARRHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Arrh055).HasColumnName(@"ARRH055").HasColumnType("tinyint").IsRequired();
            Property(x => x.Arrh210).HasColumnName(@"ARRH210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Arrh220).HasColumnName(@"ARRH220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Arrh230).HasColumnName(@"ARRH230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Arrh240).HasColumnName(@"ARRH240").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Arrh250).HasColumnName(@"ARRH250").HasColumnType("tinyint").IsRequired();
            Property(x => x.Arrh222).HasColumnName(@"ARRH222").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Arrh225).HasColumnName(@"ARRH225").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
