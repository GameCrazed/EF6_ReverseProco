

namespace Generator
{

    public class RalkMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ralk>
    {
        public RalkMapping()
            : this("dbo")
        {
        }

        public RalkMapping(string schema)
        {
            ToTable("RALK", schema);
            HasKey(x => x.Ralk999);

            Property(x => x.Ralk001).HasColumnName(@"RALK001").HasColumnType("int").IsRequired();
            Property(x => x.Ralk010).HasColumnName(@"RALK010").HasColumnType("int").IsRequired();
            Property(x => x.Ralk020).HasColumnName(@"RALK020").HasColumnType("int").IsRequired();
            Property(x => x.Ralk030).HasColumnName(@"RALK030").HasColumnType("int").IsRequired();
            Property(x => x.Ralk040).HasColumnName(@"RALK040").HasColumnType("datetime").IsRequired();
            Property(x => x.Ralk999).HasColumnName(@"RALK999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ralk080).HasColumnName(@"RALK080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ralk090).HasColumnName(@"RALK090").HasColumnType("datetime").IsRequired();
        }
    }

}
