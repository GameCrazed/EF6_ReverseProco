

namespace Generator
{

    public class AladMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Alad>
    {
        public AladMapping()
            : this("dbo")
        {
        }

        public AladMapping(string schema)
        {
            ToTable("ALAD", schema);
            HasKey(x => x.Alad001);

            Property(x => x.Alad001).HasColumnName(@"ALAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Alad010).HasColumnName(@"ALAD010").HasColumnType("datetime").IsRequired();
            Property(x => x.Alad020).HasColumnName(@"ALAD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Alad220).HasColumnName(@"ALAD220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Alad240).HasColumnName(@"ALAD240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Alad310).HasColumnName(@"ALAD310").HasColumnType("datetime").IsRequired();
            Property(x => x.Alad320).HasColumnName(@"ALAD320").HasColumnType("int").IsRequired();
            Property(x => x.Alad330).HasColumnName(@"ALAD330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Alad340).HasColumnName(@"ALAD340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Alad350).HasColumnName(@"ALAD350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad360).HasColumnName(@"ALAD360").HasColumnType("int").IsRequired();
            Property(x => x.Alad370).HasColumnName(@"ALAD370").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Alad380).HasColumnName(@"ALAD380").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad390).HasColumnName(@"ALAD390").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad400).HasColumnName(@"ALAD400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad410).HasColumnName(@"ALAD410").HasColumnType("tinyint").IsRequired();
            Property(x => x.Alad420).HasColumnName(@"ALAD420").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad500).HasColumnName(@"ALAD500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad510).HasColumnName(@"ALAD510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad520).HasColumnName(@"ALAD520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad530).HasColumnName(@"ALAD530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad540).HasColumnName(@"ALAD540").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Alad210).HasColumnName(@"ALAD210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Aladdtm).HasColumnName(@"ALADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
