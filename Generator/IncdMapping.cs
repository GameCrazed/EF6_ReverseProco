

namespace Generator
{

    public class IncdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Incd>
    {
        public IncdMapping()
            : this("dbo")
        {
        }

        public IncdMapping(string schema)
        {
            ToTable("INCD", schema);
            HasKey(x => x.Incd001);

            Property(x => x.Incd001).HasColumnName(@"INCD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Incd010).HasColumnName(@"INCD010").HasColumnType("int").IsRequired();
            Property(x => x.Incd020).HasColumnName(@"INCD020").HasColumnType("int").IsRequired();
            Property(x => x.Incd030).HasColumnName(@"INCD030").HasColumnType("tinyint").IsRequired();
            Property(x => x.Incd040).HasColumnName(@"INCD040").HasColumnType("datetime").IsRequired();
            Property(x => x.Incd050).HasColumnName(@"INCD050").HasColumnType("datetime").IsRequired();
            Property(x => x.Incd060).HasColumnName(@"INCD060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Incd070).HasColumnName(@"INCD070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(80);
        }
    }

}
