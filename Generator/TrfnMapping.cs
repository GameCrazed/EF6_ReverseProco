

namespace Generator
{

    public class TrfnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trfn>
    {
        public TrfnMapping()
            : this("dbo")
        {
        }

        public TrfnMapping(string schema)
        {
            ToTable("TRFN", schema);
            HasKey(x => new { x.Trfn001, x.Trfn010 });

            Property(x => x.Trfn001).HasColumnName(@"TRFN001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trfn010).HasColumnName(@"TRFN010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(150).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
