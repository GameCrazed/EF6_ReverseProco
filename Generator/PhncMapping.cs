

namespace Generator
{

    public class PhncMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Phnc>
    {
        public PhncMapping()
            : this("dbo")
        {
        }

        public PhncMapping(string schema)
        {
            ToTable("PHNC", schema);
            HasKey(x => new { x.Phnc001, x.Phnc010, x.Phnc020 });

            Property(x => x.Phnc001).HasColumnName(@"PHNC001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Phnc010).HasColumnName(@"PHNC010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Phnc020).HasColumnName(@"PHNC020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Phnc030).HasColumnName(@"PHNC030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Phnc040).HasColumnName(@"PHNC040").HasColumnType("datetime").IsRequired();
            Property(x => x.Phnc050).HasColumnName(@"PHNC050").HasColumnType("smallint").IsRequired();
        }
    }

}
