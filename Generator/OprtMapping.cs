

namespace Generator
{

    public class OprtMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Oprt>
    {
        public OprtMapping()
            : this("dbo")
        {
        }

        public OprtMapping(string schema)
        {
            ToTable("OPRT", schema);
            HasKey(x => new { x.Oprt001, x.Oprt002 });

            Property(x => x.Oprt001).HasColumnName(@"OPRT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Oprt002).HasColumnName(@"OPRT002").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Oprt010).HasColumnName(@"OPRT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Oprt020).HasColumnName(@"OPRT020").HasColumnType("smallint").IsRequired();
            Property(x => x.Oprt030).HasColumnName(@"OPRT030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Oprt050).HasColumnName(@"OPRT050").HasColumnType("int").IsRequired();
            Property(x => x.Oprt090).HasColumnName(@"OPRT090").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Oprt100).HasColumnName(@"OPRT100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Oprtdtm).HasColumnName(@"OPRTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
