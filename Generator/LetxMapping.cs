

namespace Generator
{

    public class LetxMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Letx>
    {
        public LetxMapping()
            : this("dbo")
        {
        }

        public LetxMapping(string schema)
        {
            ToTable("LETX", schema);
            HasKey(x => x.Letx999);

            Property(x => x.Letx999).HasColumnName(@"LETX999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Letx010).HasColumnName(@"LETX010").HasColumnType("int").IsRequired();
            Property(x => x.Letx020).HasColumnName(@"LETX020").HasColumnType("int").IsRequired();
            Property(x => x.Letx030).HasColumnName(@"LETX030").HasColumnType("datetime").IsRequired();
            Property(x => x.Letx035).HasColumnName(@"LETX035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Letx060).HasColumnName(@"LETX060").HasColumnType("int").IsRequired();
            Property(x => x.Letx040).HasColumnName(@"LETX040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2100);
            Property(x => x.Letx050).HasColumnName(@"LETX050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
        }
    }

}
