

namespace Generator
{

    public class MatyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Maty>
    {
        public MatyMapping()
            : this("dbo")
        {
        }

        public MatyMapping(string schema)
        {
            ToTable("MATY", schema);
            HasKey(x => x.Maty010);

            Property(x => x.Maty010).HasColumnName(@"MATY010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Maty020).HasColumnName(@"MATY020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Matydtm).HasColumnName(@"MATYDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
