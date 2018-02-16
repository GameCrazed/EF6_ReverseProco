

namespace Generator
{

    public class ChlcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Chlc>
    {
        public ChlcMapping()
            : this("dbo")
        {
        }

        public ChlcMapping(string schema)
        {
            ToTable("CHLC", schema);
            HasKey(x => x.Chlc001);

            Property(x => x.Chlc001).HasColumnName(@"CHLC001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Chlc020).HasColumnName(@"CHLC020").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chlc021).HasColumnName(@"CHLC021").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chlc025).HasColumnName(@"CHLC025").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chlc026).HasColumnName(@"CHLC026").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chlc030).HasColumnName(@"CHLC030").HasColumnType("datetime").IsRequired();
            Property(x => x.Chlc050).HasColumnName(@"CHLC050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chlc051).HasColumnName(@"CHLC051").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chlc055).HasColumnName(@"CHLC055").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chlc056).HasColumnName(@"CHLC056").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chlc060).HasColumnName(@"CHLC060").HasColumnType("datetime").IsRequired();
            Property(x => x.Chlc061).HasColumnName(@"CHLC061").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chlc062).HasColumnName(@"CHLC062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chlc063).HasColumnName(@"CHLC063").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Chlc064).HasColumnName(@"CHLC064").HasColumnType("datetime").IsRequired();
            Property(x => x.Chlc065).HasColumnName(@"CHLC065").HasColumnType("datetime").IsRequired();
            Property(x => x.Chlc066).HasColumnName(@"CHLC066").HasColumnType("datetime").IsRequired();
            Property(x => x.Chlc067).HasColumnName(@"CHLC067").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chlc068).HasColumnName(@"CHLC068").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Chlc069).HasColumnName(@"CHLC069").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chlc071).HasColumnName(@"CHLC071").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Chlc072).HasColumnName(@"CHLC072").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Chlc073).HasColumnName(@"CHLC073").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
