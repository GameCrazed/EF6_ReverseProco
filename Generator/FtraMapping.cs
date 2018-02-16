

namespace Generator
{

    public class FtraMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ftra>
    {
        public FtraMapping()
            : this("dbo")
        {
        }

        public FtraMapping(string schema)
        {
            ToTable("FTRA", schema);
            HasKey(x => x.Ftra001);

            Property(x => x.Ftra001).HasColumnName(@"FTRA001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ftra010).HasColumnName(@"FTRA010").HasColumnType("int").IsRequired();
            Property(x => x.Ftra020).HasColumnName(@"FTRA020").HasColumnType("datetime").IsRequired();
            Property(x => x.Ftra030).HasColumnName(@"FTRA030").HasColumnType("datetime").IsRequired();
            Property(x => x.Ftra040).HasColumnName(@"FTRA040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ftra050).HasColumnName(@"FTRA050").HasColumnType("datetime").IsRequired();
            Property(x => x.Ftra060).HasColumnName(@"FTRA060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
