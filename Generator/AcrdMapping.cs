

namespace Generator
{

    public class AcrdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acrd>
    {
        public AcrdMapping()
            : this("dbo")
        {
        }

        public AcrdMapping(string schema)
        {
            ToTable("ACRD", schema);
            HasKey(x => x.Acrd999);

            Property(x => x.Acrd001).HasColumnName(@"ACRD001").HasColumnType("int").IsRequired();
            Property(x => x.Acrd002).HasColumnName(@"ACRD002").HasColumnType("int").IsRequired();
            Property(x => x.Acrd010).HasColumnName(@"ACRD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acrd020).HasColumnName(@"ACRD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acrd030).HasColumnName(@"ACRD030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acrd040).HasColumnName(@"ACRD040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acrd050).HasColumnName(@"ACRD050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acrd060).HasColumnName(@"ACRD060").HasColumnType("int").IsRequired();
            Property(x => x.Acrd070).HasColumnName(@"ACRD070").HasColumnType("datetime").IsRequired();
            Property(x => x.Acrd080).HasColumnName(@"ACRD080").HasColumnType("datetime").IsRequired();
            Property(x => x.Acrd090).HasColumnName(@"ACRD090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acrd100).HasColumnName(@"ACRD100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acrd110).HasColumnName(@"ACRD110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acrd120).HasColumnName(@"ACRD120").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acrd130).HasColumnName(@"ACRD130").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acrd140).HasColumnName(@"ACRD140").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acrd150).HasColumnName(@"ACRD150").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acrd160).HasColumnName(@"ACRD160").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd170).HasColumnName(@"ACRD170").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd180).HasColumnName(@"ACRD180").HasColumnType("datetime").IsRequired();
            Property(x => x.Acrd190).HasColumnName(@"ACRD190").HasColumnType("datetime").IsRequired();
            Property(x => x.Acrd200).HasColumnName(@"ACRD200").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd210).HasColumnName(@"ACRD210").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd220).HasColumnName(@"ACRD220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acrd230).HasColumnName(@"ACRD230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acrd240).HasColumnName(@"ACRD240").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd250).HasColumnName(@"ACRD250").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd260).HasColumnName(@"ACRD260").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acrd270).HasColumnName(@"ACRD270").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acrd280).HasColumnName(@"ACRD280").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd290).HasColumnName(@"ACRD290").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd500).HasColumnName(@"ACRD500").HasColumnType("smallint").IsRequired();
            Property(x => x.Acrd999).HasColumnName(@"ACRD999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Acrd510).HasColumnName(@"ACRD510").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acrd520).HasColumnName(@"ACRD520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acrd530).HasColumnName(@"ACRD530").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
