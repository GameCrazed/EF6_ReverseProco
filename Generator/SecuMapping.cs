

namespace Generator
{

    public class SecuMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Secu>
    {
        public SecuMapping()
            : this("dbo")
        {
        }

        public SecuMapping(string schema)
        {
            ToTable("SECU", schema);
            HasKey(x => x.Secu001);

            Property(x => x.Secu001).HasColumnName(@"SECU001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Secu004).HasColumnName(@"SECU004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Secu010).HasColumnName(@"SECU010").HasColumnType("int").IsRequired();
            Property(x => x.Secu020).HasColumnName(@"SECU020").HasColumnType("smallint").IsRequired();
            Property(x => x.Secu030).HasColumnName(@"SECU030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Secu040).HasColumnName(@"SECU040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Secu050).HasColumnName(@"SECU050").HasColumnType("datetime").IsRequired();
            Property(x => x.Secu060).HasColumnName(@"SECU060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Secu070).HasColumnName(@"SECU070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Secu080).HasColumnName(@"SECU080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Secu090).HasColumnName(@"SECU090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Secu100).HasColumnName(@"SECU100").HasColumnType("datetime").IsRequired();
            Property(x => x.Secu110).HasColumnName(@"SECU110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Secu200).HasColumnName(@"SECU200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Secu045).HasColumnName(@"SECU045").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Secu120).HasColumnName(@"SECU120").HasColumnType("int").IsRequired();
            Property(x => x.Secu130).HasColumnName(@"SECU130").HasColumnType("datetime").IsRequired();
        }
    }

}
