

namespace Generator
{

    public class EaNoteMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaNote>
    {
        public EaNoteMapping()
            : this("dbo")
        {
        }

        public EaNoteMapping(string schema)
        {
            ToTable("ea_note", schema);
            HasKey(x => x.NoteId);

            Property(x => x.NoteId).HasColumnName(@"NoteId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FkApplicationId).HasColumnName(@"fkApplicationID").HasColumnType("int").IsRequired();
            Property(x => x.FkNoteRef).HasColumnName(@"fkNoteRef").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Note).HasColumnName(@"Note").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8000);
        }
    }

}
