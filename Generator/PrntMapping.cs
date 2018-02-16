

namespace Generator
{

    public class PrntMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prnt>
    {
        public PrntMapping()
            : this("dbo")
        {
        }

        public PrntMapping(string schema)
        {
            ToTable("PRNT", schema);
            HasKey(x => new { x.Prnt010, x.Prnt020 });

            Property(x => x.Prnt010).HasColumnName(@"PRNT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prnt020).HasColumnName(@"PRNT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(16).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prnt0301).HasColumnName(@"PRNT0301").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0302).HasColumnName(@"PRNT0302").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0303).HasColumnName(@"PRNT0303").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0304).HasColumnName(@"PRNT0304").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0305).HasColumnName(@"PRNT0305").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0306).HasColumnName(@"PRNT0306").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0307).HasColumnName(@"PRNT0307").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0308).HasColumnName(@"PRNT0308").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt0309).HasColumnName(@"PRNT0309").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03010).HasColumnName(@"PRNT03010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03011).HasColumnName(@"PRNT03011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03012).HasColumnName(@"PRNT03012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03013).HasColumnName(@"PRNT03013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03014).HasColumnName(@"PRNT03014").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03015).HasColumnName(@"PRNT03015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03016).HasColumnName(@"PRNT03016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03017).HasColumnName(@"PRNT03017").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03018).HasColumnName(@"PRNT03018").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03019).HasColumnName(@"PRNT03019").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03020).HasColumnName(@"PRNT03020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03021).HasColumnName(@"PRNT03021").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03022).HasColumnName(@"PRNT03022").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03023).HasColumnName(@"PRNT03023").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03024).HasColumnName(@"PRNT03024").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03025).HasColumnName(@"PRNT03025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03026).HasColumnName(@"PRNT03026").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03027).HasColumnName(@"PRNT03027").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03028).HasColumnName(@"PRNT03028").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03029).HasColumnName(@"PRNT03029").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03030).HasColumnName(@"PRNT03030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03031).HasColumnName(@"PRNT03031").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03032).HasColumnName(@"PRNT03032").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03033).HasColumnName(@"PRNT03033").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03034).HasColumnName(@"PRNT03034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03035).HasColumnName(@"PRNT03035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03036).HasColumnName(@"PRNT03036").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03037).HasColumnName(@"PRNT03037").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03038).HasColumnName(@"PRNT03038").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03039).HasColumnName(@"PRNT03039").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prnt03040).HasColumnName(@"PRNT03040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Prntdtm).HasColumnName(@"PRNTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
