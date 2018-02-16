

namespace Generator
{

    public class FlabMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Flab>
    {
        public FlabMapping()
            : this("dbo")
        {
        }

        public FlabMapping(string schema)
        {
            ToTable("FLAB", schema);
            HasKey(x => new { x.Flab001, x.Flab007 });

            Property(x => x.Flab001).HasColumnName(@"FLAB001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Flab007).HasColumnName(@"FLAB007").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Flab023).HasColumnName(@"FLAB023").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
        }
    }

}
