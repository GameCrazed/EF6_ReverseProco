

namespace Generator
{

    public class PpayMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ppay>
    {
        public PpayMapping()
            : this("dbo")
        {
        }

        public PpayMapping(string schema)
        {
            ToTable("PPAY", schema);
            HasKey(x => new { x.Ppay080, x.Ppay090 });

            Property(x => x.Ppay001).HasColumnName(@"PPAY001").HasColumnType("int").IsRequired();
            Property(x => x.Ppay080).HasColumnName(@"PPAY080").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ppay090).HasColumnName(@"PPAY090").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ppay100).HasColumnName(@"PPAY100").HasColumnType("datetime").IsRequired();
            Property(x => x.Ppay200).HasColumnName(@"PPAY200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
