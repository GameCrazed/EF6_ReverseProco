

namespace Generator
{

    public class LtemMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ltem>
    {
        public LtemMapping()
            : this("dbo")
        {
        }

        public LtemMapping(string schema)
        {
            ToTable("LTEM", schema);
            HasKey(x => new { x.Ltem001, x.Ltem003 });

            Property(x => x.Ltem001).HasColumnName(@"LTEM001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltem002).HasColumnName(@"LTEM002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Ltem003).HasColumnName(@"LTEM003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltem032).HasColumnName(@"LTEM032").HasColumnType("datetime").IsRequired();
            Property(x => x.Ltem034).HasColumnName(@"LTEM034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
