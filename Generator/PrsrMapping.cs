

namespace Generator
{

    public class PrsrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prsr>
    {
        public PrsrMapping()
            : this("dbo")
        {
        }

        public PrsrMapping(string schema)
        {
            ToTable("PRSR", schema);
            HasKey(x => x.Prsr010);

            Property(x => x.Prsr010).HasColumnName(@"PRSR010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prsr030).HasColumnName(@"PRSR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr051).HasColumnName(@"PRSR051").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr052).HasColumnName(@"PRSR052").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Prsr053).HasColumnName(@"PRSR053").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsr055).HasColumnName(@"PRSR055").HasColumnType("int").IsRequired();
            Property(x => x.Prsr057).HasColumnName(@"PRSR057").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsr060).HasColumnName(@"PRSR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr070).HasColumnName(@"PRSR070").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsr100).HasColumnName(@"PRSR100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr110).HasColumnName(@"PRSR110").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr120).HasColumnName(@"PRSR120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsr125).HasColumnName(@"PRSR125").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr130).HasColumnName(@"PRSR130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr135).HasColumnName(@"PRSR135").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Prsr140).HasColumnName(@"PRSR140").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr150).HasColumnName(@"PRSR150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr155).HasColumnName(@"PRSR155").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsr160).HasColumnName(@"PRSR160").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr180).HasColumnName(@"PRSR180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr182).HasColumnName(@"PRSR182").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsr185).HasColumnName(@"PRSR185").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr188).HasColumnName(@"PRSR188").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsr200).HasColumnName(@"PRSR200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Prsr210).HasColumnName(@"PRSR210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr240).HasColumnName(@"PRSR240").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr250).HasColumnName(@"PRSR250").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr300).HasColumnName(@"PRSR300").HasColumnType("int").IsRequired();
            Property(x => x.Prsr400).HasColumnName(@"PRSR400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr410).HasColumnName(@"PRSR410").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsr4201).HasColumnName(@"PRSR4201").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Prsr4202).HasColumnName(@"PRSR4202").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Prsr4301).HasColumnName(@"PRSR4301").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr4302).HasColumnName(@"PRSR4302").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr480).HasColumnName(@"PRSR480").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr500).HasColumnName(@"PRSR500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Prsr016).HasColumnName(@"PRSR016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prsr046).HasColumnName(@"PRSR046").HasColumnType("int").IsRequired();
            Property(x => x.Prsr510).HasColumnName(@"PRSR510").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr068).HasColumnName(@"PRSR068").HasColumnType("int").IsRequired();
            Property(x => x.Prsr145).HasColumnName(@"PRSR145").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Prsr215).HasColumnName(@"PRSR215").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsr980).HasColumnName(@"PRSR980").HasColumnType("int").IsRequired();
            Property(x => x.Prsr990).HasColumnName(@"PRSR990").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsr065).HasColumnName(@"PRSR065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr056).HasColumnName(@"PRSR056").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsr220).HasColumnName(@"PRSR220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsr520).HasColumnName(@"PRSR520").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Prsr530).HasColumnName(@"PRSR530").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Prsr490).HasColumnName(@"PRSR490").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr017).HasColumnName(@"PRSR017").HasColumnType("int").IsRequired();
            Property(x => x.Prsr540).HasColumnName(@"PRSR540").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsr061).HasColumnName(@"PRSR061").HasColumnType("smallint").IsRequired();
        }
    }

}
