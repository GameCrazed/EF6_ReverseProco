

namespace Generator
{

    public class EaMessageholderMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaMessageholder>
    {
        public EaMessageholderMapping()
            : this("dbo")
        {
        }

        public EaMessageholderMapping(string schema)
        {
            ToTable("ea_messageholder", schema);
            HasKey(x => x.MessageHolderId);

            Property(x => x.MessageHolderId).HasColumnName(@"MessageHolderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FromDate).HasColumnName(@"FromDate").HasColumnType("datetime").IsRequired();
            Property(x => x.Descrption).HasColumnName(@"Descrption").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Data).HasColumnName(@"Data").HasColumnType("varbinary(max)").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FkMessageTypeRef).HasColumnName(@"fkMessageTypeRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
        }
    }

}
