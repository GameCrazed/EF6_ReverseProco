

namespace Generator
{

    public class IratMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Irat>
    {
        public IratMapping()
            : this("dbo")
        {
        }

        public IratMapping(string schema)
        {
            ToTable("IRAT", schema);
            HasKey(x => new { x.Irat001, x.Irat010 });

            Property(x => x.Irat001).HasColumnName(@"IRAT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Irat010).HasColumnName(@"IRAT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Irat020).HasColumnName(@"IRAT020").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
        }
    }

}
