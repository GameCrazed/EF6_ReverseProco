

namespace Generator
{

    public class MsqaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Msqa>
    {
        public MsqaMapping()
            : this("dbo")
        {
        }

        public MsqaMapping(string schema)
        {
            ToTable("MSQA", schema);
            HasKey(x => x.Msqa999);

            Property(x => x.Msqa001).HasColumnName(@"MSQA001").HasColumnType("int").IsRequired();
            Property(x => x.Msqa010).HasColumnName(@"MSQA010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Msqa020).HasColumnName(@"MSQA020").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Msqa030).HasColumnName(@"MSQA030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Msqa040).HasColumnName(@"MSQA040").HasColumnType("datetime").IsRequired();
            Property(x => x.Msqa050).HasColumnName(@"MSQA050").HasColumnType("int").IsRequired();
            Property(x => x.Msqa999).HasColumnName(@"MSQA999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
