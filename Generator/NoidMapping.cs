

namespace Generator
{

    public class NoidMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Noid>
    {
        public NoidMapping()
            : this("dbo")
        {
        }

        public NoidMapping(string schema)
        {
            ToTable("NOID", schema);
            HasKey(x => new { x.Noid010, x.Noid030 });

            Property(x => x.Noid010).HasColumnName(@"NOID010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Noid030).HasColumnName(@"NOID030").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Noid040).HasColumnName(@"NOID040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noid050).HasColumnName(@"NOID050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noid070).HasColumnName(@"NOID070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Noid080).HasColumnName(@"NOID080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
