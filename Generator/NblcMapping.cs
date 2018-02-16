

namespace Generator
{

    public class NblcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nblc>
    {
        public NblcMapping()
            : this("dbo")
        {
        }

        public NblcMapping(string schema)
        {
            ToTable("NBLC", schema);
            HasKey(x => x.Nblc020);

            Property(x => x.Nblc010).HasColumnName(@"NBLC010").HasColumnType("int").IsRequired();
            Property(x => x.Nblc020).HasColumnName(@"NBLC020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nblc030).HasColumnName(@"NBLC030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
