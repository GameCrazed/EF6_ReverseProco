

namespace Generator
{

    public class AsstMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Asst>
    {
        public AsstMapping()
            : this("dbo")
        {
        }

        public AsstMapping(string schema)
        {
            ToTable("ASST", schema);
            HasKey(x => new { x.Asst040, x.Asst010, x.Asst020 });

            Property(x => x.Asst010).HasColumnName(@"ASST010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Asst020).HasColumnName(@"ASST020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Asst030).HasColumnName(@"ASST030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Asst040).HasColumnName(@"ASST040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Asstdtm).HasColumnName(@"ASSTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
