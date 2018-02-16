

namespace Generator
{

    public class CutyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cuty>
    {
        public CutyMapping()
            : this("dbo")
        {
        }

        public CutyMapping(string schema)
        {
            ToTable("CUTY", schema);
            HasKey(x => x.Cuty040);

            Property(x => x.Cuty010).HasColumnName(@"CUTY010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cuty040).HasColumnName(@"CUTY040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cuty050).HasColumnName(@"CUTY050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Cuty060).HasColumnName(@"CUTY060").HasColumnType("smallint").IsRequired();
            Property(x => x.Cuty045).HasColumnName(@"CUTY045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cuty055).HasColumnName(@"CUTY055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
        }
    }

}
