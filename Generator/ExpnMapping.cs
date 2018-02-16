

namespace Generator
{

    public class ExpnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Expn>
    {
        public ExpnMapping()
            : this("dbo")
        {
        }

        public ExpnMapping(string schema)
        {
            ToTable("EXPN", schema);
            HasKey(x => x.Expn000);

            Property(x => x.Expn000).HasColumnName(@"EXPN000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Expn001).HasColumnName(@"EXPN001").HasColumnType("int").IsRequired();
            Property(x => x.Expn010).HasColumnName(@"EXPN010").HasColumnType("int").IsRequired();
            Property(x => x.Expn020).HasColumnName(@"EXPN020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Expn030).HasColumnName(@"EXPN030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Expn040).HasColumnName(@"EXPN040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Expn045).HasColumnName(@"EXPN045").HasColumnType("datetime").IsRequired();
            Property(x => x.Expn049).HasColumnName(@"EXPN049").HasColumnType("int").IsRequired();
            Property(x => x.Expn050).HasColumnName(@"EXPN050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Expn055).HasColumnName(@"EXPN055").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Expn060).HasColumnName(@"EXPN060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Expn070).HasColumnName(@"EXPN070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
