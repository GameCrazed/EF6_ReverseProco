

namespace Generator
{

    public class SctyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Scty>
    {
        public SctyMapping()
            : this("dbo")
        {
        }

        public SctyMapping(string schema)
        {
            ToTable("SCTY", schema);
            HasKey(x => x.Scty001);

            Property(x => x.Scty001).HasColumnName(@"SCTY001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Scty010).HasColumnName(@"SCTY010").HasColumnType("int").IsRequired();
            Property(x => x.Scty011).HasColumnName(@"SCTY011").HasColumnType("datetime").IsRequired();
            Property(x => x.Scty012).HasColumnName(@"SCTY012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Scty015).HasColumnName(@"SCTY015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Scty020).HasColumnName(@"SCTY020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Scty040).HasColumnName(@"SCTY040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Scty050).HasColumnName(@"SCTY050").HasColumnType("datetime").IsRequired();
            Property(x => x.Scty055).HasColumnName(@"SCTY055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Scty060).HasColumnName(@"SCTY060").HasColumnType("datetime").IsRequired();
            Property(x => x.Scty100).HasColumnName(@"SCTY100").HasColumnType("int").IsRequired();
            Property(x => x.Scty105).HasColumnName(@"SCTY105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Scty110).HasColumnName(@"SCTY110").HasColumnType("int").IsRequired();
            Property(x => x.Scty115).HasColumnName(@"SCTY115").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Scty120).HasColumnName(@"SCTY120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Scty130).HasColumnName(@"SCTY130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Scty030).HasColumnName(@"SCTY030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scty500).HasColumnName(@"SCTY500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Sctydtm).HasColumnName(@"SCTYDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
