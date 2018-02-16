

namespace Generator
{

    public class CtctMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ctct>
    {
        public CtctMapping()
            : this("dbo")
        {
        }

        public CtctMapping(string schema)
        {
            ToTable("CTCT", schema);
            HasKey(x => x.Ctct001);

            Property(x => x.Ctct001).HasColumnName(@"CTCT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ctct010).HasColumnName(@"CTCT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ctct011).HasColumnName(@"CTCT011").HasColumnType("datetime").IsRequired();
            Property(x => x.Ctct012).HasColumnName(@"CTCT012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ctct015).HasColumnName(@"CTCT015").HasColumnType("int").IsRequired();
            Property(x => x.Ctct020).HasColumnName(@"CTCT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Ctct030).HasColumnName(@"CTCT030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ctct040).HasColumnName(@"CTCT040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ctct042).HasColumnName(@"CTCT042").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ctct045).HasColumnName(@"CTCT045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Ctct046).HasColumnName(@"CTCT046").HasColumnType("int").IsRequired();
            Property(x => x.Ctct047).HasColumnName(@"CTCT047").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Ctct049).HasColumnName(@"CTCT049").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ctct050).HasColumnName(@"CTCT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ctct060).HasColumnName(@"CTCT060").HasColumnType("int").IsRequired();
            Property(x => x.Ctct200).HasColumnName(@"CTCT200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ctct500).HasColumnName(@"CTCT500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Ctct300).HasColumnName(@"ctct300").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ctct310).HasColumnName(@"ctct310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ctct400).HasColumnName(@"ctct400").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ctct450).HasColumnName(@"CTCT450").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Ctct470).HasColumnName(@"CTCT470").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Ctct035).HasColumnName(@"CTCT035").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ctct036).HasColumnName(@"CTCT036").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ctctdtm).HasColumnName(@"CTCTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ctct025).HasColumnName(@"CTCT025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Ctct100).HasColumnName(@"CTCT100").HasColumnType("int").IsRequired();
            Property(x => x.Ctct110).HasColumnName(@"CTCT110").HasColumnType("datetime").IsRequired();
            Property(x => x.Ctct051).HasColumnName(@"CTCT051").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ctct600).HasColumnName(@"CTCT600").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ctct210).HasColumnName(@"CTCT210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Ctct610).HasColumnName(@"CTCT610").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ctct115).HasColumnName(@"CTCT115").HasColumnType("datetime").IsRequired();
        }
    }

}
