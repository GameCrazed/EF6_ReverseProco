

namespace Generator
{

    public class ExcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Exc>
    {
        public ExcMapping()
            : this("dbo")
        {
        }

        public ExcMapping(string schema)
        {
            ToTable("EXCS", schema);
            HasKey(x => new { x.Excs000, x.Excs001 });

            Property(x => x.Excs000).HasColumnName(@"EXCS000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Excs001).HasColumnName(@"EXCS001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Excs003).HasColumnName(@"EXCS003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Excs005).HasColumnName(@"EXCS005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Excs011).HasColumnName(@"EXCS011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs012).HasColumnName(@"EXCS012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs013).HasColumnName(@"EXCS013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs014).HasColumnName(@"EXCS014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs015).HasColumnName(@"EXCS015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs016).HasColumnName(@"EXCS016").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs017).HasColumnName(@"EXCS017").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs018).HasColumnName(@"EXCS018").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs019).HasColumnName(@"EXCS019").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs020).HasColumnName(@"EXCS020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs021).HasColumnName(@"EXCS021").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs022).HasColumnName(@"EXCS022").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs023).HasColumnName(@"EXCS023").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs024).HasColumnName(@"EXCS024").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs025).HasColumnName(@"EXCS025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs026).HasColumnName(@"EXCS026").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs027).HasColumnName(@"EXCS027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs028).HasColumnName(@"EXCS028").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs029).HasColumnName(@"EXCS029").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs030).HasColumnName(@"EXCS030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Excs100).HasColumnName(@"EXCS100").HasColumnType("datetime").IsRequired();
            Property(x => x.Excs500).HasColumnName(@"EXCS500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
        }
    }

}
