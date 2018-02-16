

namespace Generator
{

    public class GewdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Gewd>
    {
        public GewdMapping()
            : this("dbo")
        {
        }

        public GewdMapping(string schema)
        {
            ToTable("GEWD", schema);
            HasKey(x => x.Gewd010);

            Property(x => x.Gewd010).HasColumnName(@"GEWD010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Gewd020).HasColumnName(@"GEWD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
        }
    }

}
