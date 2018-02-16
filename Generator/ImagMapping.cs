

namespace Generator
{

    public class ImagMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Imag>
    {
        public ImagMapping()
            : this("dbo")
        {
        }

        public ImagMapping(string schema)
        {
            ToTable("IMAG", schema);
            HasKey(x => x.Imag999);

            Property(x => x.Imag010).HasColumnName(@"IMAG010").HasColumnType("int").IsRequired();
            Property(x => x.Imag020).HasColumnName(@"IMAG020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Imag030).HasColumnName(@"IMAG030").HasColumnType("datetime").IsRequired();
            Property(x => x.Imag040).HasColumnName(@"IMAG040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Imag050).HasColumnName(@"IMAG050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Imag060).HasColumnName(@"IMAG060").HasColumnType("smallint").IsRequired();
            Property(x => x.Imag070).HasColumnName(@"IMAG070").HasColumnType("smallint").IsRequired();
            Property(x => x.Imag999).HasColumnName(@"IMAG999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Imagdtm).HasColumnName(@"IMAGDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Imag015).HasColumnName(@"IMAG015").HasColumnType("int").IsRequired();
            Property(x => x.Imag080).HasColumnName(@"IMAG080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(64);
        }
    }

}
