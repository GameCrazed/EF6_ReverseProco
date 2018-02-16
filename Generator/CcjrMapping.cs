

namespace Generator
{

    public class CcjrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ccjr>
    {
        public CcjrMapping()
            : this("dbo")
        {
        }

        public CcjrMapping(string schema)
        {
            ToTable("CCJR", schema);
            HasKey(x => x.Ccjr000);

            Property(x => x.Ccjr000).HasColumnName(@"CCJR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ccjr005).HasColumnName(@"CCJR005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ccjr010).HasColumnName(@"CCJR010").HasColumnType("int").IsRequired();
            Property(x => x.Ccjr015).HasColumnName(@"CCJR015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ccjr020).HasColumnName(@"CCJR020").HasColumnType("int").IsRequired();
            Property(x => x.Ccjr025).HasColumnName(@"CCJR025").HasColumnType("datetime").IsRequired();
            Property(x => x.Ccjr030).HasColumnName(@"CCJR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ccjr035).HasColumnName(@"CCJR035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ccjr040).HasColumnName(@"CCJR040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccjr050).HasColumnName(@"CCJR050").HasColumnType("datetime").IsRequired();
            Property(x => x.Ccjr070).HasColumnName(@"CCJR070").HasColumnType("datetime").IsRequired();
            Property(x => x.Ccjr080).HasColumnName(@"CCJR080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Ccjr060).HasColumnName(@"CCJR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ccjr062).HasColumnName(@"CCJR062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ccjr100).HasColumnName(@"CCJR100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(13);
            Property(x => x.Ccjr110).HasColumnName(@"CCJR110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccjr120).HasColumnName(@"CCJR120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ccjr130).HasColumnName(@"CCJR130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ccjr006).HasColumnName(@"CCJR006").HasColumnType("smallint").IsRequired();
            Property(x => x.Ccjr065).HasColumnName(@"CCJR065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ccjr125).HasColumnName(@"CCJR125").HasColumnType("smallint").IsRequired();
            Property(x => x.Ccjr126).HasColumnName(@"CCJR126").HasColumnType("smallint").IsRequired();
        }
    }

}
