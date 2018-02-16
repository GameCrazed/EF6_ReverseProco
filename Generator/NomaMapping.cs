

namespace Generator
{

    public class NomaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Noma>
    {
        public NomaMapping()
            : this("dbo")
        {
        }

        public NomaMapping(string schema)
        {
            ToTable("NOMA", schema);
            HasKey(x => x.Noma010);

            Property(x => x.Noma010).HasColumnName(@"NOMA010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Noma030).HasColumnName(@"NOMA030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Noma035).HasColumnName(@"NOMA035").HasColumnType("int").IsRequired();
            Property(x => x.Noma040).HasColumnName(@"NOMA040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Noma050).HasColumnName(@"NOMA050").HasColumnType("int").IsRequired();
            Property(x => x.Noma060).HasColumnName(@"NOMA060").HasColumnType("datetime").IsRequired();
            Property(x => x.Noma070).HasColumnName(@"NOMA070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Noma075).HasColumnName(@"NOMA075").HasColumnType("int").IsRequired();
            Property(x => x.Noma080).HasColumnName(@"NOMA080").HasColumnType("int").IsRequired();
            Property(x => x.Noma085).HasColumnName(@"NOMA085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Noma090).HasColumnName(@"NOMA090").HasColumnType("datetime").IsRequired();
            Property(x => x.Noma110).HasColumnName(@"NOMA110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1201).HasColumnName(@"NOMA1201").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1202).HasColumnName(@"NOMA1202").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1203).HasColumnName(@"NOMA1203").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1204).HasColumnName(@"NOMA1204").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1205).HasColumnName(@"NOMA1205").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1206).HasColumnName(@"NOMA1206").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1207).HasColumnName(@"NOMA1207").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1208).HasColumnName(@"NOMA1208").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1209).HasColumnName(@"NOMA1209").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma12010).HasColumnName(@"NOMA12010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma12011).HasColumnName(@"NOMA12011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma12012).HasColumnName(@"NOMA12012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma12013).HasColumnName(@"NOMA12013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1301).HasColumnName(@"NOMA1301").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1302).HasColumnName(@"NOMA1302").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1303).HasColumnName(@"NOMA1303").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1304).HasColumnName(@"NOMA1304").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1305).HasColumnName(@"NOMA1305").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1306).HasColumnName(@"NOMA1306").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1307).HasColumnName(@"NOMA1307").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1308).HasColumnName(@"NOMA1308").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma1309).HasColumnName(@"NOMA1309").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma13010).HasColumnName(@"NOMA13010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma13011).HasColumnName(@"NOMA13011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma13012).HasColumnName(@"NOMA13012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma13013).HasColumnName(@"NOMA13013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma140).HasColumnName(@"NOMA140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Noma150).HasColumnName(@"NOMA150").HasColumnType("int").IsRequired();
            Property(x => x.Noma160).HasColumnName(@"NOMA160").HasColumnType("datetime").IsRequired();
            Property(x => x.Noma170).HasColumnName(@"NOMA170").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nomadtm).HasColumnName(@"NOMADTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Noma990).HasColumnName(@"NOMA990").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
