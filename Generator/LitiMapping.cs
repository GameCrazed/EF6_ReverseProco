

namespace Generator
{

    public class LitiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Liti>
    {
        public LitiMapping()
            : this("dbo")
        {
        }

        public LitiMapping(string schema)
        {
            ToTable("LITI", schema);
            HasKey(x => x.Liti010);

            Property(x => x.Liti010).HasColumnName(@"LITI010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Liti015).HasColumnName(@"LITI015").HasColumnType("int").IsRequired();
            Property(x => x.Liti020).HasColumnName(@"LITI020").HasColumnType("datetime").IsRequired();
            Property(x => x.Liti030).HasColumnName(@"LITI030").HasColumnType("datetime").IsRequired();
            Property(x => x.Liti040).HasColumnName(@"LITI040").HasColumnType("datetime").IsRequired();
            Property(x => x.Liti500).HasColumnName(@"LITI500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Litidtm).HasColumnName(@"LITIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
