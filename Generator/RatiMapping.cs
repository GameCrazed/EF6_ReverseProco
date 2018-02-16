

namespace Generator
{

    public class RatiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rati>
    {
        public RatiMapping()
            : this("dbo")
        {
        }

        public RatiMapping(string schema)
        {
            ToTable("RATI", schema);
            HasKey(x => x.Rati999);

            Property(x => x.Rati010).HasColumnName(@"RATI010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Rati020).HasColumnName(@"RATI020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Rati030).HasColumnName(@"RATI030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Rati040).HasColumnName(@"RATI040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Rati050).HasColumnName(@"RATI050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Rati060).HasColumnName(@"RATI060").HasColumnType("datetime").IsRequired();
            Property(x => x.Rati999).HasColumnName(@"RATI999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Rati080).HasColumnName(@"RATI080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Rati090).HasColumnName(@"RATI090").HasColumnType("datetime").IsRequired();
        }
    }

}
