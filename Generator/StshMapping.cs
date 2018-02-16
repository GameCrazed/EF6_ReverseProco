

namespace Generator
{

    public class StshMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Stsh>
    {
        public StshMapping()
            : this("dbo")
        {
        }

        public StshMapping(string schema)
        {
            ToTable("STSH", schema);
            HasKey(x => new { x.Stsh010, x.Stsh020, x.Stsh030 });

            Property(x => x.Stsh010).HasColumnName(@"STSH010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Stsh020).HasColumnName(@"STSH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Stsh030).HasColumnName(@"STSH030").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Stsh060).HasColumnName(@"STSH060").HasColumnType("datetime").IsRequired();
            Property(x => x.Stsh090).HasColumnName(@"STSH090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh100).HasColumnName(@"STSH100").HasColumnType("datetime").IsRequired();
            Property(x => x.Stsh110).HasColumnName(@"STSH110").HasColumnType("int").IsRequired();
            Property(x => x.Stsh120).HasColumnName(@"STSH120").HasColumnType("int").IsRequired();
            Property(x => x.Stsh130).HasColumnName(@"STSH130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh140).HasColumnName(@"STSH140").HasColumnType("datetime").IsRequired();
            Property(x => x.Stsh150).HasColumnName(@"STSH150").HasColumnType("datetime").IsRequired();
            Property(x => x.Stsh160).HasColumnName(@"STSH160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stsh300).HasColumnName(@"stsh300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(400);
            Property(x => x.Stty300).HasColumnName(@"stty300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(400);
            Property(x => x.Stsh320).HasColumnName(@"STSH320").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Stsh040).HasColumnName(@"STSH040").HasColumnType("int").IsRequired();
            Property(x => x.Stshdtm).HasColumnName(@"STSHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Stsh170).HasColumnName(@"STSH170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh180).HasColumnName(@"STSH180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh190).HasColumnName(@"STSH190").HasColumnType("int").IsRequired();
            Property(x => x.Stsh400).HasColumnName(@"STSH400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh410).HasColumnName(@"STSH410").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh420).HasColumnName(@"STSH420").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh430).HasColumnName(@"STSH430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh440).HasColumnName(@"STSH440").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh450).HasColumnName(@"STSH450").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh500).HasColumnName(@"STSH500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh510).HasColumnName(@"STSH510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh520).HasColumnName(@"STSH520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stsh600).HasColumnName(@"STSH600").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
