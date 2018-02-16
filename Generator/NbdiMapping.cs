

namespace Generator
{

    public class NbdiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbdi>
    {
        public NbdiMapping()
            : this("dbo")
        {
        }

        public NbdiMapping(string schema)
        {
            ToTable("NBDI", schema);
            HasKey(x => x.Nbdi001);

            Property(x => x.Nbdi001).HasColumnName(@"NBDI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbdi002).HasColumnName(@"NBDI002").HasColumnType("int").IsRequired();
            Property(x => x.Nbdi003).HasColumnName(@"NBDI003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nbdi004).HasColumnName(@"NBDI004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Nbdi005).HasColumnName(@"NBDI005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Nbdi006).HasColumnName(@"NBDI006").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Nbdi007).HasColumnName(@"NBDI007").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbdi008).HasColumnName(@"NBDI008").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdi999).HasColumnName(@"NBDI999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
