

namespace Generator
{

    public class EaOccupantdetailMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaOccupantdetail>
    {
        public EaOccupantdetailMapping()
            : this("dbo")
        {
        }

        public EaOccupantdetailMapping(string schema)
        {
            ToTable("ea_occupantdetails", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationID").HasColumnType("int").IsRequired();
            Property(x => x.OccupantNameId).HasColumnName(@"OccupantNameID").HasColumnType("int").IsRequired();
            Property(x => x.Relationship).HasColumnName(@"Relationship").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Ordinal).HasColumnName(@"Ordinal").HasColumnType("int").IsRequired();
        }
    }

}
