

namespace Generator
{

    public class PurcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Purc>
    {
        public PurcMapping()
            : this("dbo")
        {
        }

        public PurcMapping(string schema)
        {
            ToTable("PURC", schema);
            HasKey(x => x.Purc001);

            Property(x => x.Purc001).HasColumnName(@"PURC001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Purc010).HasColumnName(@"PURC010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Purc030).HasColumnName(@"PURC030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Purc040).HasColumnName(@"PURC040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Purc050).HasColumnName(@"PURC050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Purc060).HasColumnName(@"PURC060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Purcdtm).HasColumnName(@"PURCDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
