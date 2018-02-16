

namespace Generator
{

    public class NumMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Num>
    {
        public NumMapping()
            : this("dbo")
        {
        }

        public NumMapping(string schema)
        {
            ToTable("NUMS", schema);
            HasKey(x => x.Nums001);

            Property(x => x.Nums001).HasColumnName(@"NUMS001").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nums002).HasColumnName(@"NUMS002").HasColumnType("int").IsRequired();
            Property(x => x.Nums003).HasColumnName(@"NUMS003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Numsdtm).HasColumnName(@"NUMSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Nums004).HasColumnName(@"NUMS004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nums005).HasColumnName(@"NUMS005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Nums006).HasColumnName(@"NUMS006").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nums007).HasColumnName(@"NUMS007").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
