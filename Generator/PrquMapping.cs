

namespace Generator
{

    public class PrquMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prqu>
    {
        public PrquMapping()
            : this("dbo")
        {
        }

        public PrquMapping(string schema)
        {
            ToTable("PRQU", schema);
            HasKey(x => new { x.Prqu001, x.Prqu005, x.Prqu015 });

            Property(x => x.Prqu001).HasColumnName(@"PRQU001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prqu005).HasColumnName(@"PRQU005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prqu010).HasColumnName(@"PRQU010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Prqu015).HasColumnName(@"PRQU015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Prqudtm).HasColumnName(@"PRQUDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Prqu020).HasColumnName(@"PRQU020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
        }
    }

}
