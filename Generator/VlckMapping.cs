

namespace Generator
{

    public class VlckMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vlck>
    {
        public VlckMapping()
            : this("dbo")
        {
        }

        public VlckMapping(string schema)
        {
            ToTable("VLCK", schema);
            HasKey(x => x.Vlck010);

            Property(x => x.Vlck010).HasColumnName(@"VLCK010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vlck020).HasColumnName(@"VLCK020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vlck030).HasColumnName(@"VLCK030").HasColumnType("datetime").IsRequired();
        }
    }

}
