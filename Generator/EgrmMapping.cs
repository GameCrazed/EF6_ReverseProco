

namespace Generator
{

    public class EgrmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Egrm>
    {
        public EgrmMapping()
            : this("dbo")
        {
        }

        public EgrmMapping(string schema)
        {
            ToTable("EGRM", schema);
            HasKey(x => x.Egrm010);

            Property(x => x.Egrm010).HasColumnName(@"EGRM010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Egrm030).HasColumnName(@"EGRM030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Egrm040).HasColumnName(@"EGRM040").HasColumnType("int").IsRequired();
            Property(x => x.Egrm050).HasColumnName(@"EGRM050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Egrm060).HasColumnName(@"EGRM060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Egrm080).HasColumnName(@"EGRM080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Egrm090).HasColumnName(@"EGRM090").HasColumnType("datetime").IsRequired();
            Property(x => x.Egrm100).HasColumnName(@"EGRM100").HasColumnType("int").IsRequired();
            Property(x => x.Egrm105).HasColumnName(@"EGRM105").HasColumnType("datetime").IsRequired();
            Property(x => x.Egrm110).HasColumnName(@"EGRM110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm130).HasColumnName(@"EGRM130").HasColumnType("datetime").IsRequired();
            Property(x => x.Egrm135).HasColumnName(@"EGRM135").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1401).HasColumnName(@"EGRM1401").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1402).HasColumnName(@"EGRM1402").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1403).HasColumnName(@"EGRM1403").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1404).HasColumnName(@"EGRM1404").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1405).HasColumnName(@"EGRM1405").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1406).HasColumnName(@"EGRM1406").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1407).HasColumnName(@"EGRM1407").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1408).HasColumnName(@"EGRM1408").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm1409).HasColumnName(@"EGRM1409").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm14010).HasColumnName(@"EGRM14010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm14011).HasColumnName(@"EGRM14011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm14012).HasColumnName(@"EGRM14012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrm150).HasColumnName(@"EGRM150").HasColumnType("int").IsRequired();
            Property(x => x.Egrm155).HasColumnName(@"EGRM155").HasColumnType("int").IsRequired();
            Property(x => x.Egrm190).HasColumnName(@"EGRM190").HasColumnType("int").IsRequired();
            Property(x => x.Egrm191).HasColumnName(@"EGRM191").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Egrm192).HasColumnName(@"EGRM192").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Egrm200).HasColumnName(@"EGRM200").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Egrmdtm).HasColumnName(@"EGRMDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Egrm115).HasColumnName(@"EGRM115").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
