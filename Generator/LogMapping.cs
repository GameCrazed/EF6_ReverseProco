

namespace Generator
{

    public class LogMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Log>
    {
        public LogMapping()
            : this("dbo")
        {
        }

        public LogMapping(string schema)
        {
            ToTable("LOGS", schema);
            HasKey(x => new { x.Logs001, x.Logs011, x.Logs100 });

            Property(x => x.Logs001).HasColumnName(@"LOGS001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Logs002).HasColumnName(@"LOGS002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Logs003).HasColumnName(@"LOGS003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Logs010).HasColumnName(@"LOGS010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Logs011).HasColumnName(@"LOGS011").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Logs050).HasColumnName(@"LOGS050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Logs051).HasColumnName(@"LOGS051").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Logs052).HasColumnName(@"LOGS052").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Logs055).HasColumnName(@"LOGS055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Logs100).HasColumnName(@"LOGS100").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Logs730).HasColumnName(@"LOGS730").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Logs808).HasColumnName(@"LOGS808").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Logs811).HasColumnName(@"LOGS811").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Logs819).HasColumnName(@"LOGS819").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Logs820).HasColumnName(@"LOGS820").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Logs850).HasColumnName(@"LOGS850").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Logs860).HasColumnName(@"LOGS860").HasColumnType("datetime").IsRequired();
            Property(x => x.Logs999).HasColumnName(@"LOGS999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
