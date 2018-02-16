

namespace Generator
{

    public class ReferenceDataMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReferenceData>
    {
        public ReferenceDataMapping()
            : this("dbo")
        {
        }

        public ReferenceDataMapping(string schema)
        {
            ToTable("referenceData", schema);
            HasKey(x => x.RefId);

            Property(x => x.RefId).HasColumnName(@"refID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ListName).HasColumnName(@"listName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ListValue).HasColumnName(@"listValue").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
        }
    }

}
