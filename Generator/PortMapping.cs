

namespace Generator
{

    public class PortMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Port>
    {
        public PortMapping()
            : this("dbo")
        {
        }

        public PortMapping(string schema)
        {
            ToTable("PORT", schema);
            HasKey(x => x.Port001);

            Property(x => x.Port001).HasColumnName(@"PORT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Port010).HasColumnName(@"PORT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Port020).HasColumnName(@"PORT020").HasColumnType("datetime").IsRequired();
            Property(x => x.Port022).HasColumnName(@"PORT022").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Port030).HasColumnName(@"PORT030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Port035).HasColumnName(@"PORT035").HasColumnType("datetime").IsRequired();
            Property(x => x.Port040).HasColumnName(@"PORT040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Port045).HasColumnName(@"PORT045").HasColumnType("datetime").IsRequired();
            Property(x => x.Port050).HasColumnName(@"PORT050").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Port060).HasColumnName(@"PORT060").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
        }
    }

}
