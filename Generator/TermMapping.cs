

namespace Generator
{

    public class TermMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Term>
    {
        public TermMapping()
            : this("dbo")
        {
        }

        public TermMapping(string schema)
        {
            ToTable("TERM", schema);
            HasKey(x => x.Term999);

            Property(x => x.Term001).HasColumnName(@"TERM001").HasColumnType("int").IsRequired();
            Property(x => x.Term011).HasColumnName(@"TERM011").HasColumnType("datetime").IsRequired();
            Property(x => x.Term012).HasColumnName(@"TERM012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Term016).HasColumnName(@"TERM016").HasColumnType("datetime").IsRequired();
            Property(x => x.Term017).HasColumnName(@"TERM017").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Term050).HasColumnName(@"TERM050").HasColumnType("datetime").IsRequired();
            Property(x => x.Term060).HasColumnName(@"TERM060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Term070).HasColumnName(@"TERM070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Term080).HasColumnName(@"TERM080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Term090).HasColumnName(@"TERM090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Term200).HasColumnName(@"TERM200").HasColumnType("int").IsRequired();
            Property(x => x.Term210).HasColumnName(@"TERM210").HasColumnType("int").IsRequired();
            Property(x => x.Term220).HasColumnName(@"TERM220").HasColumnType("int").IsRequired();
            Property(x => x.Term300).HasColumnName(@"TERM300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Term310).HasColumnName(@"TERM310").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Term320).HasColumnName(@"TERM320").HasColumnType("int").IsRequired();
            Property(x => x.Term335).HasColumnName(@"TERM335").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Term337).HasColumnName(@"TERM337").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Term500).HasColumnName(@"TERM500").HasColumnType("int").IsRequired();
            Property(x => x.Term501).HasColumnName(@"TERM501").HasColumnType("int").IsRequired();
            Property(x => x.Term600).HasColumnName(@"TERM600").HasColumnType("int").IsRequired();
            Property(x => x.Term800).HasColumnName(@"TERM800").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Term850).HasColumnName(@"TERM850").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Term999).HasColumnName(@"TERM999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Term400).HasColumnName(@"TERM400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Term401).HasColumnName(@"TERM401").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Term416).HasColumnName(@"TERM416").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Term360).HasColumnName(@"TERM360").HasColumnType("int").IsRequired();
            Property(x => x.Term361).HasColumnName(@"TERM361").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
