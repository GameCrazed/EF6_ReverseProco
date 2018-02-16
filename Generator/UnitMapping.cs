

namespace Generator
{

    public class UnitMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Unit>
    {
        public UnitMapping()
            : this("dbo")
        {
        }

        public UnitMapping(string schema)
        {
            ToTable("UNIT", schema);
            HasKey(x => x.Unit000);

            Property(x => x.Unit000).HasColumnName(@"UNIT000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Unit010).HasColumnName(@"UNIT010").HasColumnType("int").IsRequired();
            Property(x => x.Unit011).HasColumnName(@"UNIT011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Unit012).HasColumnName(@"UNIT012").HasColumnType("int").IsRequired();
            Property(x => x.Unit015).HasColumnName(@"UNIT015").HasColumnType("smallint").IsRequired();
            Property(x => x.Unit020).HasColumnName(@"UNIT020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Unit060).HasColumnName(@"UNIT060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Unit075).HasColumnName(@"UNIT075").HasColumnType("smallint").IsRequired();
            Property(x => x.Unit076).HasColumnName(@"UNIT076").HasColumnType("smallint").IsRequired();
            Property(x => x.Unit320).HasColumnName(@"UNIT320").HasColumnType("int").IsRequired();
            Property(x => x.Unit500).HasColumnName(@"UNIT500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit510).HasColumnName(@"UNIT510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit520).HasColumnName(@"UNIT520").HasColumnType("datetime").IsRequired();
            Property(x => x.Unit530).HasColumnName(@"UNIT530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit400).HasColumnName(@"UNIT400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit405).HasColumnName(@"UNIT405").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit420).HasColumnName(@"UNIT420").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit425).HasColumnName(@"UNIT425").HasColumnType("datetime").IsRequired();
            Property(x => x.Unit065).HasColumnName(@"UNIT065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Unit505).HasColumnName(@"UNIT505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit430).HasColumnName(@"UNIT430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Unit061).HasColumnName(@"UNIT061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
        }
    }

}
