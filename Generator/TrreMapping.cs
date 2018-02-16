

namespace Generator
{

    public class TrreMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trre>
    {
        public TrreMapping()
            : this("dbo")
        {
        }

        public TrreMapping(string schema)
        {
            ToTable("TRRE", schema);
            HasKey(x => x.Trre999);

            Property(x => x.Trre001).HasColumnName(@"TRRE001").HasColumnType("int").IsRequired();
            Property(x => x.Trre010).HasColumnName(@"TRRE010").HasColumnType("smallint").IsRequired();
            Property(x => x.Trre020).HasColumnName(@"TRRE020").HasColumnType("datetime").IsRequired();
            Property(x => x.Trre025).HasColumnName(@"TRRE025").HasColumnType("datetime").IsRequired();
            Property(x => x.Trre030).HasColumnName(@"TRRE030").HasColumnType("smallint").IsRequired();
            Property(x => x.Trre040).HasColumnName(@"TRRE040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trre045).HasColumnName(@"TRRE045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trre999).HasColumnName(@"TRRE999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
