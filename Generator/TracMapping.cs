

namespace Generator
{

    public class TracMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trac>
    {
        public TracMapping()
            : this("dbo")
        {
        }

        public TracMapping(string schema)
        {
            ToTable("TRAC", schema);
            HasKey(x => new { x.Trac999, x.Trac020, x.Trac010 });

            Property(x => x.Trac010).HasColumnName(@"TRAC010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trac020).HasColumnName(@"TRAC020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trac025).HasColumnName(@"TRAC025").HasColumnType("datetime").IsRequired();
            Property(x => x.Trac030).HasColumnName(@"TRAC030").HasColumnType("smallint").IsRequired();
            Property(x => x.Trac040).HasColumnName(@"TRAC040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trac045).HasColumnName(@"TRAC045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trac999).HasColumnName(@"TRAC999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
