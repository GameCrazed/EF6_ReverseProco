

namespace Generator
{

    public class LtluMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ltlu>
    {
        public LtluMapping()
            : this("dbo")
        {
        }

        public LtluMapping(string schema)
        {
            ToTable("LTLU", schema);
            HasKey(x => new { x.Ltlu010, x.Ltlu020, x.Ltlu030, x.Ltlu040 });

            Property(x => x.Ltlu010).HasColumnName(@"LTLU010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltlu020).HasColumnName(@"LTLU020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltlu030).HasColumnName(@"LTLU030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltlu040).HasColumnName(@"LTLU040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ltlu050).HasColumnName(@"LTLU050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Ltlu060).HasColumnName(@"LTLU060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Ltlu070).HasColumnName(@"LTLU070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
