

namespace Generator
{

    public class JobdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Jobd>
    {
        public JobdMapping()
            : this("dbo")
        {
        }

        public JobdMapping(string schema)
        {
            ToTable("JOBD", schema);
            HasKey(x => new { x.Jobd010, x.Jobd020 });

            Property(x => x.Jobd010).HasColumnName(@"JOBD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Jobd020).HasColumnName(@"JOBD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Jobd030).HasColumnName(@"JOBD030").HasColumnType("datetime").IsRequired();
            Property(x => x.Jobd040).HasColumnName(@"JOBD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Jobd050).HasColumnName(@"JOBD050").HasColumnType("int").IsRequired();
        }
    }

}
