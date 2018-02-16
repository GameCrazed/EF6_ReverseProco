

namespace Generator
{

    public class StodMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Stod>
    {
        public StodMapping()
            : this("dbo")
        {
        }

        public StodMapping(string schema)
        {
            ToTable("STOD", schema);
            HasKey(x => x.Stod000);

            Property(x => x.Stod000).HasColumnName(@"STOD000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Stod001).HasColumnName(@"STOD001").HasColumnType("int").IsRequired();
            Property(x => x.Stod002).HasColumnName(@"STOD002").HasColumnType("smallint").IsRequired();
            Property(x => x.Stod003).HasColumnName(@"STOD003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Stod004).HasColumnName(@"STOD004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stod005).HasColumnName(@"STOD005").HasColumnType("int").IsRequired();
            Property(x => x.Stod006).HasColumnName(@"STOD006").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Stod007).HasColumnName(@"STOD007").HasColumnType("datetime").IsRequired();
            Property(x => x.Stod008).HasColumnName(@"STOD008").HasColumnType("datetime").IsRequired();
            Property(x => x.Stod009).HasColumnName(@"STOD009").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Stod010).HasColumnName(@"STOD010").HasColumnType("smallint").IsRequired();
            Property(x => x.Stod999).HasColumnName(@"STOD999").HasColumnType("int").IsRequired();
        }
    }

}
