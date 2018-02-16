

namespace Generator
{

    public class EaMessagetyperefMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaMessagetyperef>
    {
        public EaMessagetyperefMapping()
            : this("dbo")
        {
        }

        public EaMessagetyperefMapping(string schema)
        {
            ToTable("ea_messagetyperef", schema);
            HasKey(x => x.MessageTypeRef);

            Property(x => x.MessageTypeRef).HasColumnName(@"MessageTypeRef").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Descrption).HasColumnName(@"Descrption").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.ShortDescrption).HasColumnName(@"ShortDescrption").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
        }
    }

}
