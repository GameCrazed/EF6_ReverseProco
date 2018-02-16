

namespace Generator
{

    public class EaNoterefMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaNoteref>
    {
        public EaNoterefMapping()
            : this("dbo")
        {
        }

        public EaNoterefMapping(string schema)
        {
            ToTable("ea_noteref", schema);
            HasKey(x => x.NoteCode);

            Property(x => x.NoteCode).HasColumnName(@"NoteCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.ShortDescription).HasColumnName(@"ShortDescription").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
        }
    }

}
