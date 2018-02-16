

namespace Generator
{

    public class CodeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Code>
    {
        public CodeMapping()
            : this("dbo")
        {
        }

        public CodeMapping(string schema)
        {
            ToTable("CODE", schema);
            HasKey(x => new { x.Code030, x.Code010 });

            Property(x => x.Code010).HasColumnName(@"CODE010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code020).HasColumnName(@"CODE020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Code030).HasColumnName(@"CODE030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Codedtm).HasColumnName(@"CODEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Code060).HasColumnName(@"CODE060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
