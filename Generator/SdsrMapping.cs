

namespace Generator
{

    public class SdsrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sdsr>
    {
        public SdsrMapping()
            : this("dbo")
        {
        }

        public SdsrMapping(string schema)
        {
            ToTable("SDSR", schema);
            HasKey(x => x.Sdsr001);

            Property(x => x.Sdsr001).HasColumnName(@"SDSR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sdsr010).HasColumnName(@"SDSR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Sdsr020).HasColumnName(@"SDSR020").HasColumnType("int").IsRequired();
        }
    }

}
