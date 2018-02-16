

namespace Generator
{

    public class XIrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XIr>
    {
        public XIrMapping()
            : this("dbo")
        {
        }

        public XIrMapping(string schema)
        {
            ToTable("X__IR", schema);
            HasKey(x => x.XIr999);

            Property(x => x.XIr006).HasColumnName(@"X__IR006").HasColumnType("int").IsRequired();
            Property(x => x.XIr005).HasColumnName(@"X__IR005").HasColumnType("int").IsRequired();
            Property(x => x.XIr004).HasColumnName(@"X__IR004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.XIr003).HasColumnName(@"X__IR003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.XIr002).HasColumnName(@"X__IR002").HasColumnType("int").IsRequired();
            Property(x => x.XIr001).HasColumnName(@"X__IR001").HasColumnType("int").IsRequired();
            Property(x => x.XIr999).HasColumnName(@"X__IR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XIr007).HasColumnName(@"X__IR007").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XIrdtm).HasColumnName(@"X__IRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
