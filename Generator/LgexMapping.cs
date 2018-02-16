

namespace Generator
{

    public class LgexMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Lgex>
    {
        public LgexMapping()
            : this("dbo")
        {
        }

        public LgexMapping(string schema)
        {
            ToTable("LGEX", schema);
            HasKey(x => x.Lgex001);

            Property(x => x.Lgex001).HasColumnName(@"LGEX001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Lgex003).HasColumnName(@"LGEX003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Lgex004).HasColumnName(@"LGEX004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Lgex005).HasColumnName(@"LGEX005").HasColumnType("datetime").IsRequired();
            Property(x => x.Lgex010).HasColumnName(@"LGEX010").HasColumnType("int").IsRequired();
            Property(x => x.Lgex020).HasColumnName(@"LGEX020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Lgex030).HasColumnName(@"LGEX030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Lgex040).HasColumnName(@"LGEX040").HasColumnType("int").IsRequired();
            Property(x => x.Lgex050).HasColumnName(@"LGEX050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Lgex060).HasColumnName(@"LGEX060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Lgex080).HasColumnName(@"LGEX080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex100).HasColumnName(@"LGEX100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex101).HasColumnName(@"LGEX101").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex110).HasColumnName(@"LGEX110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex111).HasColumnName(@"LGEX111").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex120).HasColumnName(@"LGEX120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex121).HasColumnName(@"LGEX121").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex130).HasColumnName(@"LGEX130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex131).HasColumnName(@"LGEX131").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex142).HasColumnName(@"LGEX142").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex201).HasColumnName(@"LGEX201").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Lgex202).HasColumnName(@"LGEX202").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
