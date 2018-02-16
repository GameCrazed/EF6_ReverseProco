

namespace Generator
{

    public class CbanMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cban>
    {
        public CbanMapping()
            : this("dbo")
        {
        }

        public CbanMapping(string schema)
        {
            ToTable("CBAN", schema);
            HasKey(x => x.Cban000);

            Property(x => x.Cban000).HasColumnName(@"CBAN000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cban001).HasColumnName(@"CBAN001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cban002).HasColumnName(@"CBAN002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Cban003).HasColumnName(@"CBAN003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Cban005).HasColumnName(@"CBAN005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cban011).HasColumnName(@"CBAN011").HasColumnType("int").IsRequired();
            Property(x => x.Cban012).HasColumnName(@"CBAN012").HasColumnType("int").IsRequired();
            Property(x => x.Cban015).HasColumnName(@"CBAN015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cban020).HasColumnName(@"CBAN020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Cban100).HasColumnName(@"CBAN100").HasColumnType("datetime").IsRequired();
            Property(x => x.Cban110).HasColumnName(@"CBAN110").HasColumnType("int").IsRequired();
            Property(x => x.Cban120).HasColumnName(@"CBAN120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban121).HasColumnName(@"CBAN121").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban122).HasColumnName(@"CBAN122").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban130).HasColumnName(@"CBAN130").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cban131).HasColumnName(@"CBAN131").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cban140).HasColumnName(@"CBAN140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cban200).HasColumnName(@"CBAN200").HasColumnType("datetime").IsRequired();
            Property(x => x.Cban210).HasColumnName(@"CBAN210").HasColumnType("int").IsRequired();
            Property(x => x.Cban220).HasColumnName(@"CBAN220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban221).HasColumnName(@"CBAN221").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban222).HasColumnName(@"CBAN222").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban230).HasColumnName(@"CBAN230").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cban231).HasColumnName(@"CBAN231").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cban240).HasColumnName(@"CBAN240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cban300).HasColumnName(@"CBAN300").HasColumnType("datetime").IsRequired();
            Property(x => x.Cban310).HasColumnName(@"CBAN310").HasColumnType("int").IsRequired();
            Property(x => x.Cban320).HasColumnName(@"CBAN320").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban321).HasColumnName(@"CBAN321").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban322).HasColumnName(@"CBAN322").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cban330).HasColumnName(@"CBAN330").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cban331).HasColumnName(@"CBAN331").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cban340).HasColumnName(@"CBAN340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
