

namespace Generator
{

    public class EaStatusrefMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaStatusref>
    {
        public EaStatusrefMapping()
            : this("dbo")
        {
        }

        public EaStatusrefMapping(string schema)
        {
            ToTable("ea_statusref", schema);
            HasKey(x => x.StatusCode);

            Property(x => x.StatusCode).HasColumnName(@"StatusCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descrption).HasColumnName(@"Descrption").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ShortDescription).HasColumnName(@"ShortDescription").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
        }
    }

}
