

namespace Generator
{

    public class DiadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Diad>
    {
        public DiadMapping()
            : this("dbo")
        {
        }

        public DiadMapping(string schema)
        {
            ToTable("DIAD", schema);
            HasKey(x => x.Diad001);

            Property(x => x.Diad001).HasColumnName(@"DIAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Diad002).HasColumnName(@"DIAD002").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Diad003).HasColumnName(@"DIAD003").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Diaddtm).HasColumnName(@"DIADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Diad004).HasColumnName(@"DIAD004").HasColumnType("datetime").IsRequired();
            Property(x => x.Diad005).HasColumnName(@"DIAD005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Diad006).HasColumnName(@"DIAD006").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Diad007).HasColumnName(@"DIAD007").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Diad0201).HasColumnName(@"DIAD0201").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0202).HasColumnName(@"DIAD0202").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0203).HasColumnName(@"DIAD0203").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0204).HasColumnName(@"DIAD0204").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0205).HasColumnName(@"DIAD0205").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0206).HasColumnName(@"DIAD0206").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0207).HasColumnName(@"DIAD0207").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0208).HasColumnName(@"DIAD0208").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad0209).HasColumnName(@"DIAD0209").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad02010).HasColumnName(@"DIAD02010").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad008).HasColumnName(@"DIAD008").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad009).HasColumnName(@"DIAD009").HasColumnType("tinyint").IsRequired();
            Property(x => x.Diad010).HasColumnName(@"DIAD010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Diad011).HasColumnName(@"DIAD011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Diad012).HasColumnName(@"DIAD012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Diad100).HasColumnName(@"DIAD100").HasColumnType("int").IsRequired();
            Property(x => x.Diad140).HasColumnName(@"DIAD140").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Diad150).HasColumnName(@"DIAD150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Diad013).HasColumnName(@"DIAD013").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Diad110).HasColumnName(@"DIAD110").HasColumnType("int").IsRequired();
        }
    }

}
