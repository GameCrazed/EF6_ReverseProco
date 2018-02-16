

namespace Generator
{

    public class TrchMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trch>
    {
        public TrchMapping()
            : this("dbo")
        {
        }

        public TrchMapping(string schema)
        {
            ToTable("TRCH", schema);
            HasKey(x => new { x.Trch010, x.Trch020, x.Trch025, x.Trch030, x.Trch085 });

            Property(x => x.Trch010).HasColumnName(@"TRCH010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trch020).HasColumnName(@"TRCH020").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trch025).HasColumnName(@"TRCH025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trch030).HasColumnName(@"TRCH030").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trch040).HasColumnName(@"TRCH040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Trch050).HasColumnName(@"TRCH050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Trch060).HasColumnName(@"TRCH060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trch070).HasColumnName(@"TRCH070").HasColumnType("int").IsRequired();
            Property(x => x.Trch080).HasColumnName(@"TRCH080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Trch090).HasColumnName(@"TRCH090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trch100).HasColumnName(@"TRCH100").HasColumnType("smallint").IsRequired();
            Property(x => x.Trch110).HasColumnName(@"TRCH110").HasColumnType("smallint").IsRequired();
            Property(x => x.Trch120).HasColumnName(@"TRCH120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trchdtm).HasColumnName(@"TRCHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Trch085).HasColumnName(@"TRCH085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trch999).HasColumnName(@"TRCH999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
