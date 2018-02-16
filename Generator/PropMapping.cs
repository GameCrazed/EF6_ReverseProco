

namespace Generator
{

    public class PropMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prop>
    {
        public PropMapping()
            : this("dbo")
        {
        }

        public PropMapping(string schema)
        {
            ToTable("PROP", schema);
            HasKey(x => x.Prop010);

            Property(x => x.Prop010).HasColumnName(@"PROP010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prop020).HasColumnName(@"PROP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Prop030).HasColumnName(@"PROP030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prop040).HasColumnName(@"PROP040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prop050).HasColumnName(@"PROP050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Prop060).HasColumnName(@"PROP060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Propdtm).HasColumnName(@"PROPDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Prop070).HasColumnName(@"PROP070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Prop080).HasColumnName(@"PROP080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prop090).HasColumnName(@"PROP090").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prop095).HasColumnName(@"PROP095").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prop150).HasColumnName(@"PROP150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prop155).HasColumnName(@"PROP155").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
