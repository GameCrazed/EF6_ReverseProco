

namespace Generator
{

    public class PsubMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Psub>
    {
        public PsubMapping()
            : this("dbo")
        {
        }

        public PsubMapping(string schema)
        {
            ToTable("PSUB", schema);
            HasKey(x => x.Psub000);

            Property(x => x.Psub000).HasColumnName(@"PSUB000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Psub001).HasColumnName(@"PSUB001").HasColumnType("smallint").IsRequired();
            Property(x => x.Psub010).HasColumnName(@"PSUB010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Psub020).HasColumnName(@"PSUB020").HasColumnType("smallint").IsRequired();
            Property(x => x.Psub030).HasColumnName(@"PSUB030").HasColumnType("smallint").IsRequired();
            Property(x => x.Psub050).HasColumnName(@"PSUB050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Psub040).HasColumnName(@"PSUB040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Psub060).HasColumnName(@"PSUB060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psub065).HasColumnName(@"PSUB065").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psub070).HasColumnName(@"PSUB070").HasColumnType("int").IsRequired();
            Property(x => x.Psub075).HasColumnName(@"PSUB075").HasColumnType("datetime").IsRequired();
        }
    }

}
