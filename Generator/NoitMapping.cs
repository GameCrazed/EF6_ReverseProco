

namespace Generator
{

    public class NoitMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Noit>
    {
        public NoitMapping()
            : this("dbo")
        {
        }

        public NoitMapping(string schema)
        {
            ToTable("NOIT", schema);
            HasKey(x => x.Noit000);

            Property(x => x.Noit000).HasColumnName(@"NOIT000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Noit010).HasColumnName(@"NOIT010").HasColumnType("int").IsRequired();
            Property(x => x.Noit020).HasColumnName(@"NOIT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Noit030).HasColumnName(@"NOIT030").HasColumnType("int").IsRequired();
            Property(x => x.Noit040).HasColumnName(@"NOIT040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Noit050).HasColumnName(@"NOIT050").HasColumnType("int").IsRequired();
            Property(x => x.Noit060).HasColumnName(@"NOIT060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Noit070).HasColumnName(@"NOIT070").HasColumnType("smallint").IsRequired();
            Property(x => x.Noit080).HasColumnName(@"NOIT080").HasColumnType("int").IsRequired();
            Property(x => x.Noit100).HasColumnName(@"NOIT100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Noit110).HasColumnName(@"NOIT110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Noit120).HasColumnName(@"NOIT120").HasColumnType("datetime").IsRequired();
            Property(x => x.Noit130).HasColumnName(@"NOIT130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Noit200).HasColumnName(@"NOIT200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Noit210).HasColumnName(@"NOIT210").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Noit220).HasColumnName(@"NOIT220").HasColumnType("int").IsRequired();
            Property(x => x.Noit230).HasColumnName(@"NOIT230").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
