

namespace Generator
{

    public class FdepMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fdep>
    {
        public FdepMapping()
            : this("dbo")
        {
        }

        public FdepMapping(string schema)
        {
            ToTable("FDEP", schema);
            HasKey(x => new { x.Fdep001, x.Fdep003 });

            Property(x => x.Fdep001).HasColumnName(@"FDEP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fdep003).HasColumnName(@"FDEP003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fdep010).HasColumnName(@"FDEP010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
