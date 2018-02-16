

namespace Generator
{

    public class NbchMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbch>
    {
        public NbchMapping()
            : this("dbo")
        {
        }

        public NbchMapping(string schema)
        {
            ToTable("NBCH", schema);
            HasKey(x => x.Nbch999);

            Property(x => x.Nbch001).HasColumnName(@"NBCH001").HasColumnType("int").IsRequired();
            Property(x => x.Nbch005).HasColumnName(@"NBCH005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbch015).HasColumnName(@"NBCH015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbch020).HasColumnName(@"NBCH020").HasColumnType("int").IsRequired();
            Property(x => x.Nbch035).HasColumnName(@"NBCH035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbch040).HasColumnName(@"NBCH040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbch050).HasColumnName(@"NBCH050").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbch060).HasColumnName(@"NBCH060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbch062).HasColumnName(@"NBCH062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbch070).HasColumnName(@"NBCH070").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbch075).HasColumnName(@"NBCH075").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbch076).HasColumnName(@"NBCH076").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbch080).HasColumnName(@"NBCH080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Nbch100).HasColumnName(@"NBCH100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(13);
            Property(x => x.Nbch110).HasColumnName(@"NBCH110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbch999).HasColumnName(@"NBCH999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
