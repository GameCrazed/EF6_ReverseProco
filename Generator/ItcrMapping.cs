

namespace Generator
{

    public class ItcrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Itcr>
    {
        public ItcrMapping()
            : this("dbo")
        {
        }

        public ItcrMapping(string schema)
        {
            ToTable("ITCR", schema);
            HasKey(x => x.Itcr030);

            Property(x => x.Itcr030).HasColumnName(@"ITCR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Itcr150).HasColumnName(@"ITCR150").HasColumnType("datetime").IsRequired();
            Property(x => x.Itcr160).HasColumnName(@"ITCR160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Itcr170).HasColumnName(@"ITCR170").HasColumnType("datetime").IsRequired();
            Property(x => x.Itcr180).HasColumnName(@"ITCR180").HasColumnType("datetime").IsRequired();
            Property(x => x.Itcr220).HasColumnName(@"ITCR220").HasColumnType("smallint").IsRequired();
            Property(x => x.Itcr250).HasColumnName(@"ITCR250").HasColumnType("smallint").IsRequired();
            Property(x => x.Itcr252).HasColumnName(@"ITCR252").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itcr254).HasColumnName(@"ITCR254").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itcr260).HasColumnName(@"ITCR260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itcr290).HasColumnName(@"ITCR290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itcr300).HasColumnName(@"ITCR300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itcr320).HasColumnName(@"ITCR320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itcr330).HasColumnName(@"ITCR330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itcr340).HasColumnName(@"ITCR340").HasColumnType("smallint").IsRequired();
            Property(x => x.Itcr345).HasColumnName(@"ITCR345").HasColumnType("smallint").IsRequired();
            Property(x => x.Itcr350).HasColumnName(@"ITCR350").HasColumnType("smallint").IsRequired();
            Property(x => x.Itcr355).HasColumnName(@"ITCR355").HasColumnType("smallint").IsRequired();
            Property(x => x.Itcr040).HasColumnName(@"ITCR040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Itcr400).HasColumnName(@"ITCR400").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Itcrdtm).HasColumnName(@"ITCRDTM").HasColumnType("timestamp").IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Itcr255).HasColumnName(@"ITCR255").HasColumnType("tinyint").IsRequired();
            Property(x => x.Itcr500).HasColumnName(@"ITCR500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itcr501).HasColumnName(@"ITCR501").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itcr410).HasColumnName(@"ITCR410").HasColumnType("tinyint").IsRequired();
        }
    }

}
