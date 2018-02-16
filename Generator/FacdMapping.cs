

namespace Generator
{

    public class FacdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Facd>
    {
        public FacdMapping()
            : this("dbo")
        {
        }

        public FacdMapping(string schema)
        {
            ToTable("FACD", schema);
            HasKey(x => new { x.Facd001, x.Facd010 });

            Property(x => x.Facd001).HasColumnName(@"FACD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Facd010).HasColumnName(@"FACD010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Facd020).HasColumnName(@"FACD020").HasColumnType("smallint").IsRequired();
            Property(x => x.Facd030).HasColumnName(@"FACD030").HasColumnType("datetime").IsRequired();
            Property(x => x.Facd040).HasColumnName(@"FACD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Facd100).HasColumnName(@"FACD100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd120).HasColumnName(@"FACD120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd130).HasColumnName(@"FACD130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd200).HasColumnName(@"FACD200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd210).HasColumnName(@"FACD210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd220).HasColumnName(@"FACD220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd230).HasColumnName(@"FACD230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd240).HasColumnName(@"FACD240").HasColumnType("int").IsRequired();
            Property(x => x.Facd250).HasColumnName(@"FACD250").HasColumnType("smallint").IsRequired();
            Property(x => x.Facd500).HasColumnName(@"FACD500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Facd110).HasColumnName(@"FACD110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd215).HasColumnName(@"FACD215").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Facd300).HasColumnName(@"FACD300").HasColumnType("int").IsRequired();
        }
    }

}
