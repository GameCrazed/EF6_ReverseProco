

namespace Generator
{

    public class OffpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Offp>
    {
        public OffpMapping()
            : this("dbo")
        {
        }

        public OffpMapping(string schema)
        {
            ToTable("OFFP", schema);
            HasKey(x => x.Offp001);

            Property(x => x.Offp001).HasColumnName(@"OFFP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Offp010).HasColumnName(@"OFFP010").HasColumnType("int").IsRequired();
            Property(x => x.Offp011).HasColumnName(@"OFFP011").HasColumnType("datetime").IsRequired();
            Property(x => x.Offp012).HasColumnName(@"OFFP012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Offp020).HasColumnName(@"OFFP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Offp030).HasColumnName(@"OFFP030").HasColumnType("datetime").IsRequired();
            Property(x => x.Offp100).HasColumnName(@"OFFP100").HasColumnType("int").IsRequired();
            Property(x => x.Offp110).HasColumnName(@"OFFP110").HasColumnType("int").IsRequired();
            Property(x => x.Offp250).HasColumnName(@"OFFP250").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Offp300).HasColumnName(@"OFFP300").HasColumnType("datetime").IsRequired();
            Property(x => x.Offp305).HasColumnName(@"OFFP305").HasColumnType("smallint").IsRequired();
            Property(x => x.Offp307).HasColumnName(@"OFFP307").HasColumnType("smallint").IsRequired();
            Property(x => x.Offp310).HasColumnName(@"OFFP310").HasColumnType("datetime").IsRequired();
            Property(x => x.Offp400).HasColumnName(@"OFFP400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Offp500).HasColumnName(@"OFFP500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(700);
            Property(x => x.Offpdtm).HasColumnName(@"OFFPDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
