

namespace Generator
{

    public class BinMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Bin>
    {
        public BinMapping()
            : this("dbo")
        {
        }

        public BinMapping(string schema)
        {
            ToTable("BINS", schema);
            HasKey(x => x.Bins001);

            Property(x => x.Bins001).HasColumnName(@"BINS001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Bins002).HasColumnName(@"BINS002").HasColumnType("int").IsRequired();
            Property(x => x.Bins010).HasColumnName(@"BINS010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bins020).HasColumnName(@"BINS020").HasColumnType("datetime").IsRequired();
            Property(x => x.Bins030).HasColumnName(@"BINS030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bins040).HasColumnName(@"BINS040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bins060).HasColumnName(@"BINS060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bins090).HasColumnName(@"BINS090").HasColumnType("smallint").IsRequired();
            Property(x => x.Bins100).HasColumnName(@"BINS100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bins110).HasColumnName(@"BINS110").HasColumnType("datetime").IsRequired();
            Property(x => x.Bins120).HasColumnName(@"BINS120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bins130).HasColumnName(@"BINS130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bins150).HasColumnName(@"BINS150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bins003).HasColumnName(@"BINS003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bins0041).HasColumnName(@"BINS0041").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bins0042).HasColumnName(@"BINS0042").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bins0043).HasColumnName(@"BINS0043").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bins0044).HasColumnName(@"BINS0044").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bins0045).HasColumnName(@"BINS0045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bins005).HasColumnName(@"BINS005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Bins006).HasColumnName(@"BINS006").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bins007).HasColumnName(@"BINS007").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Binsdtm).HasColumnName(@"BINSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Bins160).HasColumnName(@"BINS160").HasColumnType("int").IsRequired();
            Property(x => x.Bins170).HasColumnName(@"BINS170").HasColumnType("datetime").IsRequired();
        }
    }

}
