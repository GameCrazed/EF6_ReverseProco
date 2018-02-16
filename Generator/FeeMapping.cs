

namespace Generator
{

    public class FeeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fee>
    {
        public FeeMapping()
            : this("dbo")
        {
        }

        public FeeMapping(string schema)
        {
            ToTable("FEES", schema);
            HasKey(x => new { x.Fees020, x.Fees010, x.Fees050, x.Fees015 });

            Property(x => x.Fees010).HasColumnName(@"FEES010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fees020).HasColumnName(@"FEES020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fees030).HasColumnName(@"FEES030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fees040).HasColumnName(@"FEES040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fees050).HasColumnName(@"FEES050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fees060).HasColumnName(@"FEES060").HasColumnType("int").IsRequired();
            Property(x => x.Fees070).HasColumnName(@"FEES070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fees075).HasColumnName(@"FEES075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fees080).HasColumnName(@"FEES080").HasColumnType("datetime").IsRequired();
            Property(x => x.Fees090).HasColumnName(@"FEES090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fees100).HasColumnName(@"FEES100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fees110).HasColumnName(@"FEES110").HasColumnType("smallint").IsRequired();
            Property(x => x.Fees120).HasColumnName(@"FEES120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Feesdtm).HasColumnName(@"FEESDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Fees015).HasColumnName(@"FEES015").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fees130).HasColumnName(@"FEES130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
