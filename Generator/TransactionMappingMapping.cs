

namespace Generator
{

    public class TransactionMappingMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TransactionMapping>
    {
        public TransactionMappingMapping()
            : this("dbo")
        {
        }

        public TransactionMappingMapping(string schema)
        {
            ToTable("TransactionMapping", schema);
            HasKey(x => x.SourceCode);

            Property(x => x.SourceCode).HasColumnName(@"SourceCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SourceDescription).HasColumnName(@"SourceDescription").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.PhoebusCode).HasColumnName(@"PhoebusCode").HasColumnType("int").IsRequired();
            Property(x => x.PhoebusSubAccount).HasColumnName(@"PhoebusSubAccount").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
