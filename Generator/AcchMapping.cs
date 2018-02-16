

namespace Generator
{

    public class AcchMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acch>
    {
        public AcchMapping()
            : this("dbo")
        {
        }

        public AcchMapping(string schema)
        {
            ToTable("ACCH", schema);
            HasKey(x => x.Acch999);

            Property(x => x.Acch010).HasColumnName(@"ACCH010").HasColumnType("int").IsRequired();
            Property(x => x.Acch040).HasColumnName(@"ACCH040").HasColumnType("datetime").IsRequired();
            Property(x => x.Acch050).HasColumnName(@"ACCH050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acch060).HasColumnName(@"ACCH060").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Acch070).HasColumnName(@"ACCH070").HasColumnType("int").IsRequired();
            Property(x => x.Acch090).HasColumnName(@"ACCH090").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acch100).HasColumnName(@"ACCH100").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acch110).HasColumnName(@"ACCH110").HasColumnType("smallint").IsRequired();
            Property(x => x.Acch120).HasColumnName(@"ACCH120").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Acch130).HasColumnName(@"ACCH130").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Acch999).HasColumnName(@"ACCH999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Acchdtm).HasColumnName(@"ACCHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
