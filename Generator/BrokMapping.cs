

namespace Generator
{

    public class BrokMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Brok>
    {
        public BrokMapping()
            : this("dbo")
        {
        }

        public BrokMapping(string schema)
        {
            ToTable("BROK", schema);
            HasKey(x => x.Brok010);

            Property(x => x.Brok010).HasColumnName(@"BROK010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Brok0201).HasColumnName(@"BROK0201").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Brok0202).HasColumnName(@"BROK0202").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Brok0203).HasColumnName(@"BROK0203").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Brok0204).HasColumnName(@"BROK0204").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Brok0205).HasColumnName(@"BROK0205").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Brok030).HasColumnName(@"BROK030").HasColumnType("datetime").IsRequired();
            Property(x => x.Brok050).HasColumnName(@"BROK050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Brok240).HasColumnName(@"BROK240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok500).HasColumnName(@"BROK500").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Brokdtm).HasColumnName(@"BROKDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Brok015).HasColumnName(@"BROK015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Brok040).HasColumnName(@"BROK040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok060).HasColumnName(@"BROK060").HasColumnType("int").IsRequired();
            Property(x => x.Brok100).HasColumnName(@"BROK100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok110).HasColumnName(@"BROK110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok250).HasColumnName(@"BROK250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok300).HasColumnName(@"BROK300").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brok255).HasColumnName(@"BROK255").HasColumnType("int").IsRequired();
            Property(x => x.Brok256).HasColumnName(@"BROK256").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brok350).HasColumnName(@"BROK350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok360).HasColumnName(@"BROK360").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok370).HasColumnName(@"BROK370").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brok380).HasColumnName(@"BROK380").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brok390).HasColumnName(@"BROK390").HasColumnType("int").IsRequired();
            Property(x => x.Brok400).HasColumnName(@"BROK400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brok305).HasColumnName(@"BROK305").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Brok310).HasColumnName(@"BROK310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Brok308).HasColumnName(@"BROK308").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Brok410).HasColumnName(@"BROK410").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Brok115).HasColumnName(@"BROK115").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brok116).HasColumnName(@"BROK116").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brok117).HasColumnName(@"BROK117").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brok118).HasColumnName(@"BROK118").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brok119).HasColumnName(@"BROK119").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brok075).HasColumnName(@"BROK075").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brok420).HasColumnName(@"BROK420").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brok121).HasColumnName(@"BROK121").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brok076).HasColumnName(@"BROK076").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brok600).HasColumnName(@"BROK600").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Brok601).HasColumnName(@"BROK601").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brok125).HasColumnName(@"BROK125").HasColumnType("int").IsRequired();
        }
    }

}
