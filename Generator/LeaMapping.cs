

namespace Generator
{

    public class LeaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Lea>
    {
        public LeaMapping()
            : this("dbo")
        {
        }

        public LeaMapping(string schema)
        {
            ToTable("LEAS", schema);
            HasKey(x => x.Leas001);

            Property(x => x.Leas001).HasColumnName(@"LEAS001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Leas310).HasColumnName(@"LEAS310").HasColumnType("datetime").IsRequired();
            Property(x => x.Leas320).HasColumnName(@"LEAS320").HasColumnType("int").IsRequired();
            Property(x => x.Leas340).HasColumnName(@"LEAS340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Leas350).HasColumnName(@"LEAS350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas370).HasColumnName(@"LEAS370").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Leas380).HasColumnName(@"LEAS380").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Leasdtm).HasColumnName(@"LEASDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Leas330).HasColumnName(@"LEAS330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Leas390).HasColumnName(@"LEAS390").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas400).HasColumnName(@"LEAS400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas410).HasColumnName(@"LEAS410").HasColumnType("tinyint").IsRequired();
            Property(x => x.Leas420).HasColumnName(@"LEAS420").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas500).HasColumnName(@"LEAS500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas510).HasColumnName(@"LEAS510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas520).HasColumnName(@"LEAS520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas530).HasColumnName(@"LEAS530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas540).HasColumnName(@"LEAS540").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas415).HasColumnName(@"LEAS415").HasColumnType("tinyint").IsRequired();
            Property(x => x.Leas360).HasColumnName(@"LEAS360").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas100).HasColumnName(@"LEAS100").HasColumnType("datetime").IsRequired();
            Property(x => x.Leas110).HasColumnName(@"LEAS110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas335).HasColumnName(@"LEAS335").HasColumnType("datetime").IsRequired();
            Property(x => x.Leas430).HasColumnName(@"LEAS430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas440).HasColumnName(@"LEAS440").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas460).HasColumnName(@"LEAS460").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas600).HasColumnName(@"LEAS600").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Leas609).HasColumnName(@"LEAS609").HasColumnType("tinyint").IsRequired();
            Property(x => x.Leas610).HasColumnName(@"LEAS610").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
