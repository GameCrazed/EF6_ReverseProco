

namespace Generator
{

    public class InsrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Insr>
    {
        public InsrMapping()
            : this("dbo")
        {
        }

        public InsrMapping(string schema)
        {
            ToTable("INSR", schema);
            HasKey(x => x.Insr010);

            Property(x => x.Insr010).HasColumnName(@"INSR010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Insr020).HasColumnName(@"INSR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
