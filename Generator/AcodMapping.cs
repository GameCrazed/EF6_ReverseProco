

namespace Generator
{

    public class AcodMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acod>
    {
        public AcodMapping()
            : this("dbo")
        {
        }

        public AcodMapping(string schema)
        {
            ToTable("ACOD", schema);
            HasKey(x => new { x.Acod030, x.Acod010, x.Acod060 });

            Property(x => x.Acod010).HasColumnName(@"ACOD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acod020).HasColumnName(@"ACOD020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Acod030).HasColumnName(@"ACOD030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acoddtm).HasColumnName(@"ACODDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Acod040).HasColumnName(@"ACOD040").HasColumnType("smallint").IsRequired();
            Property(x => x.Acod050).HasColumnName(@"ACOD050").HasColumnType("smallint").IsRequired();
            Property(x => x.Acod060).HasColumnName(@"ACOD060").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acod070).HasColumnName(@"ACOD070").HasColumnType("smallint").IsRequired();
            Property(x => x.Acod080).HasColumnName(@"ACOD080").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acod100).HasColumnName(@"ACOD100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acod110).HasColumnName(@"ACOD110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acod055).HasColumnName(@"ACOD055").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
        }
    }

}
