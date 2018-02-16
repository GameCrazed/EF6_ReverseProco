

namespace Generator
{

    public class McluMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mclu>
    {
        public McluMapping()
            : this("dbo")
        {
        }

        public McluMapping(string schema)
        {
            ToTable("MCLU", schema);
            HasKey(x => new { x.Mclu000, x.Mclu010, x.Mclu020 });

            Property(x => x.Mclu000).HasColumnName(@"MCLU000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mclu010).HasColumnName(@"MCLU010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mclu020).HasColumnName(@"MCLU020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mclu030).HasColumnName(@"MCLU030").HasColumnType("int").IsRequired();
            Property(x => x.Mclu040).HasColumnName(@"MCLU040").HasColumnType("datetime").IsRequired();
        }
    }

}
