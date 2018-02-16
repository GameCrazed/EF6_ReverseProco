

namespace Generator
{

    public class NbdpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbdp>
    {
        public NbdpMapping()
            : this("dbo")
        {
        }

        public NbdpMapping(string schema)
        {
            ToTable("NBDP", schema);
            HasKey(x => x.Nbdp001);

            Property(x => x.Nbdp001).HasColumnName(@"NBDP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbdp020).HasColumnName(@"NBDP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdp030).HasColumnName(@"NBDP030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbdp100).HasColumnName(@"NBDP100").HasColumnType("datetime").IsRequired();
        }
    }

}
