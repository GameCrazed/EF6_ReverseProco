

namespace Generator
{

    public class AfprMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Afpr>
    {
        public AfprMapping()
            : this("dbo")
        {
        }

        public AfprMapping(string schema)
        {
            ToTable("AFPR", schema);
            HasKey(x => new { x.Afpr010, x.Afpr020, x.Afpr025 });

            Property(x => x.Afpr010).HasColumnName(@"AFPR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Afpr020).HasColumnName(@"AFPR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Afpr025).HasColumnName(@"AFPR025").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Afpr030).HasColumnName(@"AFPR030").HasColumnType("smallint").IsRequired();
            Property(x => x.Afpr040).HasColumnName(@"AFPR040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Afpr041).HasColumnName(@"AFPR041").HasColumnType("datetime").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Afprdtm).HasColumnName(@"AFPRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
