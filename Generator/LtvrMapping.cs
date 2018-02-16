

namespace Generator
{

    public class LtvrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ltvr>
    {
        public LtvrMapping()
            : this("dbo")
        {
        }

        public LtvrMapping(string schema)
        {
            ToTable("LTVR", schema);
            HasKey(x => new { x.Ltvr001, x.Ltvr010 });

            Property(x => x.Ltvr001).HasColumnName(@"LTVR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltvr010).HasColumnName(@"LTVR010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltvr020).HasColumnName(@"LTVR020").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Ltvr040).HasColumnName(@"LTVR040").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
        }
    }

}
