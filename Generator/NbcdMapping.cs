

namespace Generator
{

    public class NbcdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbcd>
    {
        public NbcdMapping()
            : this("dbo")
        {
        }

        public NbcdMapping(string schema)
        {
            ToTable("NBCD", schema);
            HasKey(x => x.Nbcd001);

            Property(x => x.Nbcd001).HasColumnName(@"NBCD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbcd020).HasColumnName(@"NBCD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbcd030).HasColumnName(@"NBCD030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbcd100).HasColumnName(@"NBCD100").HasColumnType("datetime").IsRequired();
        }
    }

}
