

namespace Generator
{

    public class EaNameMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaName>
    {
        public EaNameMapping()
            : this("dbo")
        {
        }

        public EaNameMapping(string schema)
        {
            ToTable("ea_name", schema);
            HasKey(x => x.NameId);

            Property(x => x.NameId).HasColumnName(@"NameID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Surname).HasColumnName(@"Surname").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Gender).HasColumnName(@"Gender").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.DateOfBirth).HasColumnName(@"DateOfBirth").HasColumnType("datetime").IsOptional();
        }
    }

}
