

namespace Generator
{

    public class LogdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Logd>
    {
        public LogdMapping()
            : this("dbo")
        {
        }

        public LogdMapping(string schema)
        {
            ToTable("LOGD", schema);
            HasKey(x => x.Logd001);

            Property(x => x.Logd001).HasColumnName(@"LOGD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Logd003).HasColumnName(@"LOGD003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd004).HasColumnName(@"LOGD004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd005).HasColumnName(@"LOGD005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Logd006).HasColumnName(@"LOGD006").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd007).HasColumnName(@"LOGD007").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd008).HasColumnName(@"LOGD008").HasColumnType("int").IsRequired();
            Property(x => x.Logd009).HasColumnName(@"LOGD009").HasColumnType("tinyint").IsRequired();
            Property(x => x.Logd010).HasColumnName(@"LOGD010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd011).HasColumnName(@"LOGD011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Logd020).HasColumnName(@"LOGD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Logd021).HasColumnName(@"LOGD021").HasColumnType("smallint").IsRequired();
            Property(x => x.Logd022).HasColumnName(@"LOGD022").HasColumnType("int").IsRequired();
            Property(x => x.Logd030).HasColumnName(@"LOGD030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Logd040).HasColumnName(@"LOGD040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd041).HasColumnName(@"LOGD041").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd042).HasColumnName(@"LOGD042").HasColumnType("datetime").IsRequired();
            Property(x => x.Logd050).HasColumnName(@"LOGD050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd051).HasColumnName(@"LOGD051").HasColumnType("datetime").IsRequired();
            Property(x => x.Logd060).HasColumnName(@"LOGD060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(17);
            Property(x => x.Logd061).HasColumnName(@"LOGD061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd062).HasColumnName(@"LOGD062").HasColumnType("datetime").IsRequired();
            Property(x => x.Logd070).HasColumnName(@"LOGD070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd071).HasColumnName(@"LOGD071").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logd072).HasColumnName(@"LOGD072").HasColumnType("datetime").IsRequired();
        }
    }

}
