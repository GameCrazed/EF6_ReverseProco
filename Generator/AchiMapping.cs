

namespace Generator
{

    public class AchiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Achi>
    {
        public AchiMapping()
            : this("dbo")
        {
        }

        public AchiMapping(string schema)
        {
            ToTable("ACHI", schema);
            HasKey(x => new { x.Achi001, x.Achi010 });

            Property(x => x.Achi001).HasColumnName(@"ACHI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Achi010).HasColumnName(@"ACHI010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Achi020).HasColumnName(@"ACHI020").HasColumnType("datetime").IsRequired();
            Property(x => x.Achi030).HasColumnName(@"ACHI030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Achi040).HasColumnName(@"ACHI040").HasColumnType("datetime").IsRequired();
            Property(x => x.Achi050).HasColumnName(@"ACHI050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Achi060).HasColumnName(@"ACHI060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Achi070).HasColumnName(@"ACHI070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Achi080).HasColumnName(@"ACHI080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Achi090).HasColumnName(@"ACHI090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Achi100).HasColumnName(@"ACHI100").HasColumnType("smallint").IsRequired();
            Property(x => x.Achi110).HasColumnName(@"ACHI110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Achidtm).HasColumnName(@"ACHIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Achi120).HasColumnName(@"ACHI120").HasColumnType("int").IsRequired();
            Property(x => x.Achi200).HasColumnName(@"ACHI200").HasColumnType("int").IsRequired();
        }
    }

}
