

namespace Generator
{

    public class ErrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Err>
    {
        public ErrMapping()
            : this("dbo")
        {
        }

        public ErrMapping(string schema)
        {
            ToTable("ERRS", schema);
            HasKey(x => x.Errs999);

            Property(x => x.Errs020).HasColumnName(@"ERRS020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Errs025).HasColumnName(@"ERRS025").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Errs030).HasColumnName(@"ERRS030").HasColumnType("datetime").IsRequired();
            Property(x => x.Errs035).HasColumnName(@"ERRS035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Errs050).HasColumnName(@"ERRS050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Errs999).HasColumnName(@"ERRS999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
