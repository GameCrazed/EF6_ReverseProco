

namespace Generator
{

    public class GiltMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Gilt>
    {
        public GiltMapping()
            : this("dbo")
        {
        }

        public GiltMapping(string schema)
        {
            ToTable("GILT", schema);
            HasKey(x => x.Gilt001);

            Property(x => x.Gilt001).HasColumnName(@"GILT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Gilt005).HasColumnName(@"GILT005").HasColumnType("datetime").IsRequired();
            Property(x => x.Gilt010).HasColumnName(@"GILT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Gilt020).HasColumnName(@"GILT020").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Gilt025).HasColumnName(@"GILT025").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Gilt030).HasColumnName(@"GILT030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Gilt035).HasColumnName(@"GILT035").HasColumnType("datetime").IsRequired();
            Property(x => x.Gilt040).HasColumnName(@"GILT040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
