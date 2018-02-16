

namespace Generator
{

    public class TrnoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trno>
    {
        public TrnoMapping()
            : this("dbo")
        {
        }

        public TrnoMapping(string schema)
        {
            ToTable("TRNO", schema);
            HasKey(x => x.Trno001);

            Property(x => x.Trno001).HasColumnName(@"TRNO001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Trno010).HasColumnName(@"TRNO010").HasColumnType("int").IsRequired();
            Property(x => x.Trno030).HasColumnName(@"TRNO030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trno040).HasColumnName(@"TRNO040").HasColumnType("datetime").IsRequired();
            Property(x => x.Trno050).HasColumnName(@"TRNO050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Trno080).HasColumnName(@"TRNO080").HasColumnType("int").IsRequired();
            Property(x => x.Trno090).HasColumnName(@"TRNO090").HasColumnType("smallint").IsRequired();
            Property(x => x.Trno100).HasColumnName(@"TRNO100").HasColumnType("int").IsRequired();
        }
    }

}
