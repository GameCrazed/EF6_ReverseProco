

namespace Generator
{

    public class StrnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Strn>
    {
        public StrnMapping()
            : this("dbo")
        {
        }

        public StrnMapping(string schema)
        {
            ToTable("STRN", schema);
            HasKey(x => new { x.Strn001, x.Strn006 });

            Property(x => x.Strn001).HasColumnName(@"STRN001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Strn005).HasColumnName(@"STRN005").HasColumnType("int").IsRequired();
            Property(x => x.Strn006).HasColumnName(@"STRN006").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Strn015).HasColumnName(@"STRN015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Strn027).HasColumnName(@"STRN027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Strn070).HasColumnName(@"STRN070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Strndtm).HasColumnName(@"STRNDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
