

namespace Generator
{

    public class PsbrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Psbr>
    {
        public PsbrMapping()
            : this("dbo")
        {
        }

        public PsbrMapping(string schema)
        {
            ToTable("PSBR", schema);
            HasKey(x => x.Psbr010);

            Property(x => x.Psbr010).HasColumnName(@"PSBR010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Psbr015).HasColumnName(@"PSBR015").HasColumnType("int").IsRequired();
            Property(x => x.Psbr020).HasColumnName(@"PSBR020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr025).HasColumnName(@"PSBR025").HasColumnType("datetime").IsRequired();
            Property(x => x.Psbr030).HasColumnName(@"PSBR030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr040).HasColumnName(@"PSBR040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr050).HasColumnName(@"PSBR050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr060).HasColumnName(@"PSBR060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr070).HasColumnName(@"PSBR070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr080).HasColumnName(@"PSBR080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr100).HasColumnName(@"PSBR100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr300).HasColumnName(@"PSBR300").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr310).HasColumnName(@"PSBR310").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr320).HasColumnName(@"PSBR320").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr330).HasColumnName(@"PSBR330").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr350).HasColumnName(@"PSBR350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psbr355).HasColumnName(@"PSBR355").HasColumnType("datetime").IsRequired();
            Property(x => x.Psbr370).HasColumnName(@"PSBR370").HasColumnType("datetime").IsRequired();
            Property(x => x.Psbr375).HasColumnName(@"PSBR375").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psbr400).HasColumnName(@"PSBR400").HasColumnType("int").IsRequired();
            Property(x => x.Psbr420).HasColumnName(@"PSBR420").HasColumnType("tinyint").IsRequired();
            Property(x => x.Psbr470).HasColumnName(@"PSBR470").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Psbr500).HasColumnName(@"PSBR500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Psbr380).HasColumnName(@"PSBR380").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psbrdtm).HasColumnName(@"PSBRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Psbr340).HasColumnName(@"PSBR340").HasColumnType("datetime").IsRequired();
            Property(x => x.Psbr390).HasColumnName(@"PSBR390").HasColumnType("datetime").IsRequired();
            Property(x => x.Psbr395).HasColumnName(@"PSBR395").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psbr110).HasColumnName(@"PSBR110").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
