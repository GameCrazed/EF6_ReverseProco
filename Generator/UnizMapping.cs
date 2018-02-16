

namespace Generator
{

    public class UnizMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Uniz>
    {
        public UnizMapping()
            : this("dbo")
        {
        }

        public UnizMapping(string schema)
        {
            ToTable("UNIZ", schema);
            HasKey(x => new { x.Uniz001, x.Uniz000 });

            Property(x => x.Uniz000).HasColumnName(@"UNIZ000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Uniz001).HasColumnName(@"UNIZ001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Uniz010).HasColumnName(@"UNIZ010").HasColumnType("int").IsRequired();
            Property(x => x.Uniz011).HasColumnName(@"UNIZ011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Uniz012).HasColumnName(@"UNIZ012").HasColumnType("int").IsRequired();
            Property(x => x.Uniz015).HasColumnName(@"UNIZ015").HasColumnType("smallint").IsRequired();
            Property(x => x.Uniz020).HasColumnName(@"UNIZ020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Uniz060).HasColumnName(@"UNIZ060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Uniz065).HasColumnName(@"UNIZ065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Uniz075).HasColumnName(@"UNIZ075").HasColumnType("smallint").IsRequired();
            Property(x => x.Uniz076).HasColumnName(@"UNIZ076").HasColumnType("smallint").IsRequired();
            Property(x => x.Uniz320).HasColumnName(@"UNIZ320").HasColumnType("int").IsRequired();
            Property(x => x.Uniz400).HasColumnName(@"UNIZ400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz405).HasColumnName(@"UNIZ405").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz420).HasColumnName(@"UNIZ420").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz425).HasColumnName(@"UNIZ425").HasColumnType("datetime").IsRequired();
            Property(x => x.Uniz500).HasColumnName(@"UNIZ500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz505).HasColumnName(@"UNIZ505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz510).HasColumnName(@"UNIZ510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz520).HasColumnName(@"UNIZ520").HasColumnType("datetime").IsRequired();
            Property(x => x.Uniz530).HasColumnName(@"UNIZ530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz600).HasColumnName(@"UNIZ600").HasColumnType("int").IsRequired();
            Property(x => x.Uniz610).HasColumnName(@"UNIZ610").HasColumnType("datetime").IsRequired();
            Property(x => x.Uniz430).HasColumnName(@"UNIZ430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Uniz061).HasColumnName(@"UNIZ061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
        }
    }

}
