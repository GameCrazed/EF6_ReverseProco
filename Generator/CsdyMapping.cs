

namespace Generator
{

    public class CsdyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Csdy>
    {
        public CsdyMapping()
            : this("dbo")
        {
        }

        public CsdyMapping(string schema)
        {
            ToTable("CSDY", schema);
            HasKey(x => x.Csdy001);

            Property(x => x.Csdy001).HasColumnName(@"CSDY001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Csdy005).HasColumnName(@"CSDY005").HasColumnType("smallint").IsRequired();
            Property(x => x.Csdy010).HasColumnName(@"CSDY010").HasColumnType("smallint").IsRequired();
            Property(x => x.Csdy020).HasColumnName(@"CSDY020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Csdy030).HasColumnName(@"CSDY030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Csdy040).HasColumnName(@"CSDY040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
