

namespace Generator
{

    public class StcrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Stcr>
    {
        public StcrMapping()
            : this("dbo")
        {
        }

        public StcrMapping(string schema)
        {
            ToTable("STCR", schema);
            HasKey(x => x.Stcr000);

            Property(x => x.Stcr000).HasColumnName(@"STCR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Stcr005).HasColumnName(@"STCR005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Stcr010).HasColumnName(@"STCR010").HasColumnType("smallint").IsRequired();
            Property(x => x.Stcr015).HasColumnName(@"STCR015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stcr020).HasColumnName(@"STCR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Stcr030).HasColumnName(@"STCR030").HasColumnType("smallint").IsRequired();
            Property(x => x.Stcr040).HasColumnName(@"STCR040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stcr050).HasColumnName(@"STCR050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stcr060).HasColumnName(@"STCR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stcr070).HasColumnName(@"STCR070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stcr080).HasColumnName(@"STCR080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stcr100).HasColumnName(@"STCR100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Stcr110).HasColumnName(@"STCR110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stcr120).HasColumnName(@"STCR120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
