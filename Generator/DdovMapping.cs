

namespace Generator
{

    public class DdovMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ddov>
    {
        public DdovMapping()
            : this("dbo")
        {
        }

        public DdovMapping(string schema)
        {
            ToTable("DDOV", schema);
            HasKey(x => new { x.Ddov010, x.Ddov020 });

            Property(x => x.Ddov010).HasColumnName(@"DDOV010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ddov020).HasColumnName(@"DDOV020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ddov030).HasColumnName(@"DDOV030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ddov040).HasColumnName(@"DDOV040").HasColumnType("int").IsRequired();
            Property(x => x.Ddov050).HasColumnName(@"DDOV050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ddovdtm).HasColumnName(@"DDOVDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ddov045).HasColumnName(@"DDOV045").HasColumnType("int").IsRequired();
        }
    }

}
