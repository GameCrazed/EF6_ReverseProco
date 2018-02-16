

namespace Generator
{

    public class PcodMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pcod>
    {
        public PcodMapping()
            : this("dbo")
        {
        }

        public PcodMapping(string schema)
        {
            ToTable("PCOD", schema);
            HasKey(x => x.Pcod010);

            Property(x => x.Pcod010).HasColumnName(@"PCOD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pcod020).HasColumnName(@"PCOD020").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pcod030).HasColumnName(@"PCOD030").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pcod040).HasColumnName(@"PCOD040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pcod050).HasColumnName(@"PCOD050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
        }
    }

}
