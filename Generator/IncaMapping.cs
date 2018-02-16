

namespace Generator
{

    public class IncaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Inca>
    {
        public IncaMapping()
            : this("dbo")
        {
        }

        public IncaMapping(string schema)
        {
            ToTable("INCA", schema);
            HasKey(x => x.Inca001);

            Property(x => x.Inca001).HasColumnName(@"INCA001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Inca004).HasColumnName(@"INCA004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Inca010).HasColumnName(@"INCA010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Inca020).HasColumnName(@"INCA020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca025).HasColumnName(@"INCA025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca030).HasColumnName(@"INCA030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca035).HasColumnName(@"INCA035").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca040).HasColumnName(@"INCA040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Inca090).HasColumnName(@"INCA090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca095).HasColumnName(@"INCA095").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Inca190).HasColumnName(@"INCA190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca195).HasColumnName(@"INCA195").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Inca220).HasColumnName(@"INCA220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca225).HasColumnName(@"INCA225").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca290).HasColumnName(@"INCA290").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca295).HasColumnName(@"INCA295").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Inca325).HasColumnName(@"INCA325").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca345).HasColumnName(@"INCA345").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca390).HasColumnName(@"INCA390").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca395).HasColumnName(@"INCA395").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Inca050).HasColumnName(@"INCA050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca150).HasColumnName(@"INCA150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca145).HasColumnName(@"INCA145").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inca330).HasColumnName(@"INCA330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
