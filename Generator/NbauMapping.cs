

namespace Generator
{

    public class NbauMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbau>
    {
        public NbauMapping()
            : this("dbo")
        {
        }

        public NbauMapping(string schema)
        {
            ToTable("NBAU", schema);
            HasKey(x => x.Nbau999);

            Property(x => x.Nbau000).HasColumnName(@"NBAU000").HasColumnType("int").IsRequired();
            Property(x => x.Nbau001).HasColumnName(@"NBAU001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbau009).HasColumnName(@"NBAU009").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Nbau010).HasColumnName(@"NBAU010").HasColumnType("int").IsRequired();
            Property(x => x.Nbau020).HasColumnName(@"NBAU020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Nbau030).HasColumnName(@"NBAU030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbau040).HasColumnName(@"NBAU040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Nbau050).HasColumnName(@"NBAU050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbau060).HasColumnName(@"NBAU060").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbau070).HasColumnName(@"NBAU070").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbau080).HasColumnName(@"NBAU080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbau090).HasColumnName(@"NBAU090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Nbau999).HasColumnName(@"NBAU999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
