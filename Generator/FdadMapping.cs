

namespace Generator
{

    public class FdadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fdad>
    {
        public FdadMapping()
            : this("dbo")
        {
        }

        public FdadMapping(string schema)
        {
            ToTable("FDAD", schema);
            HasKey(x => x.Fdad001);

            Property(x => x.Fdad001).HasColumnName(@"FDAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fdad010).HasColumnName(@"FDAD010").HasColumnType("datetime").IsRequired();
            Property(x => x.Fdad020).HasColumnName(@"FDAD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fdad046).HasColumnName(@"FDAD046").HasColumnType("int").IsRequired();
            Property(x => x.Fdad120).HasColumnName(@"FDAD120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fdad350).HasColumnName(@"FDAD350").HasColumnType("tinyint").IsRequired();
            Property(x => x.Fdad360).HasColumnName(@"FDAD360").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fdaddtm).HasColumnName(@"FDADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Fdad300).HasColumnName(@"FDAD300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fdad301).HasColumnName(@"FDAD301").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fdad200).HasColumnName(@"FDAD200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
