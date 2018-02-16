

namespace Generator
{

    public class AtjdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Atjd>
    {
        public AtjdMapping()
            : this("dbo")
        {
        }

        public AtjdMapping(string schema)
        {
            ToTable("ATJD", schema);
            HasKey(x => x.Atjd999);

            Property(x => x.Atjd001).HasColumnName(@"ATJD001").HasColumnType("int").IsRequired();
            Property(x => x.Atjd010).HasColumnName(@"ATJD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Atjd020).HasColumnName(@"ATJD020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Atjd030).HasColumnName(@"ATJD030").HasColumnType("datetime").IsRequired();
            Property(x => x.Atjd999).HasColumnName(@"ATJD999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Atjd032).HasColumnName(@"ATJD032").HasColumnType("datetime").IsRequired();
            Property(x => x.Atjd034).HasColumnName(@"ATJD034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Atjd036).HasColumnName(@"ATJD036").HasColumnType("int").IsRequired();
        }
    }

}
