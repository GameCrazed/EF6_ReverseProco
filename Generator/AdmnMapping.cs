

namespace Generator
{

    public class AdmnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admn>
    {
        public AdmnMapping()
            : this("dbo")
        {
        }

        public AdmnMapping(string schema)
        {
            ToTable("ADMN", schema);
            HasKey(x => x.Admn001);

            Property(x => x.Admn001).HasColumnName(@"ADMN001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Admn011).HasColumnName(@"ADMN011").HasColumnType("datetime").IsRequired();
            Property(x => x.Admn012).HasColumnName(@"ADMN012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Admn051).HasColumnName(@"ADMN051").HasColumnType("datetime").IsRequired();
            Property(x => x.Admn200).HasColumnName(@"ADMN200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Admn205).HasColumnName(@"ADMN205").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Admn210).HasColumnName(@"ADMN210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Admn250).HasColumnName(@"ADMN250").HasColumnType("int").IsRequired();
            Property(x => x.Admn255).HasColumnName(@"ADMN255").HasColumnType("int").IsRequired();
            Property(x => x.Admn260).HasColumnName(@"ADMN260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Admn280).HasColumnName(@"ADMN280").HasColumnType("datetime").IsRequired();
            Property(x => x.Admn290).HasColumnName(@"ADMN290").HasColumnType("datetime").IsRequired();
            Property(x => x.Admn300).HasColumnName(@"ADMN300").HasColumnType("int").IsRequired();
            Property(x => x.Admn310).HasColumnName(@"ADMN310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Admn320).HasColumnName(@"ADMN320").HasColumnType("int").IsRequired();
            Property(x => x.Admn330).HasColumnName(@"ADMN330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Admn340).HasColumnName(@"ADMN340").HasColumnType("smallint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Admndtm).HasColumnName(@"ADMNDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
