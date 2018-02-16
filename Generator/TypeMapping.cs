

namespace Generator
{

    public class TypeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Type>
    {
        public TypeMapping()
            : this("dbo")
        {
        }

        public TypeMapping(string schema)
        {
            ToTable("TYPE", schema);
            HasKey(x => x.Type001);

            Property(x => x.Type001).HasColumnName(@"TYPE001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Type010).HasColumnName(@"TYPE010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Type100).HasColumnName(@"TYPE100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Typedtm).HasColumnName(@"TYPEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
