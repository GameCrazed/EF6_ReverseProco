

namespace Generator
{

    public class SubpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Subp>
    {
        public SubpMapping()
            : this("dbo")
        {
        }

        public SubpMapping(string schema)
        {
            ToTable("SUBP", schema);
            HasKey(x => new { x.Subp001, x.Subp020 });

            Property(x => x.Subp001).HasColumnName(@"SUBP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Subp0101).HasColumnName(@"SUBP0101").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0102).HasColumnName(@"SUBP0102").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0103).HasColumnName(@"SUBP0103").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0104).HasColumnName(@"SUBP0104").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0105).HasColumnName(@"SUBP0105").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0106).HasColumnName(@"SUBP0106").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0107).HasColumnName(@"SUBP0107").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0108).HasColumnName(@"SUBP0108").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp0109).HasColumnName(@"SUBP0109").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp01010).HasColumnName(@"SUBP01010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp01011).HasColumnName(@"SUBP01011").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp01012).HasColumnName(@"SUBP01012").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Subp020).HasColumnName(@"SUBP020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Subpdtm).HasColumnName(@"SUBPDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Subp050).HasColumnName(@"SUBP050").HasColumnType("int").IsRequired();
            Property(x => x.Subp040).HasColumnName(@"SUBP040").HasColumnType("tinyint").IsRequired();
        }
    }

}
