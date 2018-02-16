

namespace Generator
{

    public class CrchMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Crch>
    {
        public CrchMapping()
            : this("dbo")
        {
        }

        public CrchMapping(string schema)
        {
            ToTable("CRCH", schema);
            HasKey(x => new { x.Crch001, x.Crch010 });

            Property(x => x.Crch001).HasColumnName(@"CRCH001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Crch010).HasColumnName(@"CRCH010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Crch020).HasColumnName(@"CRCH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crch030).HasColumnName(@"CRCH030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Crch040).HasColumnName(@"CRCH040").HasColumnType("tinyint").IsRequired();
        }
    }

}
