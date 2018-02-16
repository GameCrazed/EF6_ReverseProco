

namespace Generator
{

    public class ProfMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prof>
    {
        public ProfMapping()
            : this("dbo")
        {
        }

        public ProfMapping(string schema)
        {
            ToTable("PROF", schema);
            HasKey(x => new { x.Prof010, x.Prof040, x.Prof050 });

            Property(x => x.Prof010).HasColumnName(@"PROF010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prof020).HasColumnName(@"PROF020").HasColumnType("datetime").IsRequired();
            Property(x => x.Prof030).HasColumnName(@"PROF030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prof040).HasColumnName(@"PROF040").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prof050).HasColumnName(@"PROF050").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prof060).HasColumnName(@"PROF060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prof065).HasColumnName(@"PROF065").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prof070).HasColumnName(@"PROF070").HasColumnType("smallint").IsRequired();
            Property(x => x.Prof080).HasColumnName(@"PROF080").HasColumnType("int").IsRequired();
            Property(x => x.Prof090).HasColumnName(@"PROF090").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prof100).HasColumnName(@"PROF100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Profdtm).HasColumnName(@"PROFDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
