

namespace Generator
{

    public class EaEsignatureMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaEsignature>
    {
        public EaEsignatureMapping()
            : this("dbo")
        {
        }

        public EaEsignatureMapping(string schema)
        {
            ToTable("ea_esignature", schema);
            HasKey(x => x.ESignatureId);

            Property(x => x.ESignatureId).HasColumnName(@"ESignatureId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationID").HasColumnType("int").IsRequired();
            Property(x => x.PinNumber).HasColumnName(@"PinNumber").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.HashCode).HasColumnName(@"HashCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.DateModified).HasColumnName(@"DateModified").HasColumnType("datetime").IsOptional();
        }
    }

}
