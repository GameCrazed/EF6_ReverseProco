

namespace Generator
{

    public class DeveMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Deve>
    {
        public DeveMapping()
            : this("dbo")
        {
        }

        public DeveMapping(string schema)
        {
            ToTable("DEVE", schema);
            HasKey(x => x.Deve001);

            Property(x => x.Deve001).HasColumnName(@"DEVE001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Deve005).HasColumnName(@"DEVE005").HasColumnType("int").IsRequired();
            Property(x => x.Deve006).HasColumnName(@"DEVE006").HasColumnType("int").IsRequired();
            Property(x => x.Deve010).HasColumnName(@"DEVE010").HasColumnType("int").IsRequired();
            Property(x => x.Deve011).HasColumnName(@"DEVE011").HasColumnType("datetime").IsRequired();
            Property(x => x.Deve012).HasColumnName(@"DEVE012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Deve020).HasColumnName(@"DEVE020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Deve030).HasColumnName(@"DEVE030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Deve050).HasColumnName(@"DEVE050").HasColumnType("int").IsRequired();
            Property(x => x.Deve051).HasColumnName(@"DEVE051").HasColumnType("int").IsRequired();
            Property(x => x.Deve200).HasColumnName(@"DEVE200").HasColumnType("int").IsRequired();
            Property(x => x.Deve210).HasColumnName(@"DEVE210").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Deve290).HasColumnName(@"DEVE290").HasColumnType("smallint").IsRequired();
            Property(x => x.Deve291).HasColumnName(@"DEVE291").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Deve3501).HasColumnName(@"DEVE3501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3502).HasColumnName(@"DEVE3502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3503).HasColumnName(@"DEVE3503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3504).HasColumnName(@"DEVE3504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3505).HasColumnName(@"DEVE3505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3506).HasColumnName(@"DEVE3506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3507).HasColumnName(@"DEVE3507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3508).HasColumnName(@"DEVE3508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve3509).HasColumnName(@"DEVE3509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve35010).HasColumnName(@"DEVE35010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve360).HasColumnName(@"DEVE360").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve370).HasColumnName(@"DEVE370").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deve400).HasColumnName(@"DEVE400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Deve450).HasColumnName(@"DEVE450").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(180);
            Property(x => x.Deve500).HasColumnName(@"DEVE500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Devedtm).HasColumnName(@"DEVEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
