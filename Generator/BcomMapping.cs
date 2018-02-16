

namespace Generator
{

    public class BcomMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Bcom>
    {
        public BcomMapping()
            : this("dbo")
        {
        }

        public BcomMapping(string schema)
        {
            ToTable("BCOM", schema);
            HasKey(x => x.Bcom001);

            Property(x => x.Bcom001).HasColumnName(@"BCOM001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Bcom005).HasColumnName(@"BCOM005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Bcom010).HasColumnName(@"BCOM010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Bcom015).HasColumnName(@"BCOM015").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Bcom020).HasColumnName(@"BCOM020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bcom025).HasColumnName(@"BCOM025").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
