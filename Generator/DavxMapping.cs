

namespace Generator
{

    public class DavxMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Davx>
    {
        public DavxMapping()
            : this("dbo")
        {
        }

        public DavxMapping(string schema)
        {
            ToTable("DAVX", schema);
            HasKey(x => x.Davx010);

            Property(x => x.Davx010).HasColumnName(@"DAVX010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Davx020).HasColumnName(@"DAVX020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Davx030).HasColumnName(@"DAVX030").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Davxdtm).HasColumnName(@"DAVXDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
