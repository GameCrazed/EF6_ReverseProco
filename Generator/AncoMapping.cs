

namespace Generator
{

    public class AncoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Anco>
    {
        public AncoMapping()
            : this("dbo")
        {
        }

        public AncoMapping(string schema)
        {
            ToTable("ANCO", schema);
            HasKey(x => x.Anco010);

            Property(x => x.Anco010).HasColumnName(@"ANCO010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Anco030).HasColumnName(@"ANCO030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Anco020).HasColumnName(@"ANCO020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Ancodtm).HasColumnName(@"ANCODTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Anco040).HasColumnName(@"ANCO040").HasColumnType("int").IsRequired();
            Property(x => x.Anco050).HasColumnName(@"ANCO050").HasColumnType("int").IsRequired();
        }
    }

}
