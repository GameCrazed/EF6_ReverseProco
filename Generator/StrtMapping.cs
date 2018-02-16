

namespace Generator
{

    public class StrtMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Strt>
    {
        public StrtMapping()
            : this("dbo")
        {
        }

        public StrtMapping(string schema)
        {
            ToTable("STRT", schema);
            HasKey(x => x.Strt010);

            Property(x => x.Strt010).HasColumnName(@"STRT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Strtdtm).HasColumnName(@"STRTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
