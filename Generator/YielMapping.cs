

namespace Generator
{

    public class YielMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Yiel>
    {
        public YielMapping()
            : this("dbo")
        {
        }

        public YielMapping(string schema)
        {
            ToTable("YIEL", schema);
            HasKey(x => new { x.Yiel010, x.Yiel020, x.Yiel030, x.Yiel040 });

            Property(x => x.Yiel010).HasColumnName(@"YIEL010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Yiel020).HasColumnName(@"YIEL020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Yiel030).HasColumnName(@"YIEL030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Yiel040).HasColumnName(@"YIEL040").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Yiel050).HasColumnName(@"YIEL050").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Yiel055).HasColumnName(@"YIEL055").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Yiel060).HasColumnName(@"YIEL060").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Yiel065).HasColumnName(@"YIEL065").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Yieldtm).HasColumnName(@"YIELDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
