

namespace Generator
{

    public class IregMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ireg>
    {
        public IregMapping()
            : this("dbo")
        {
        }

        public IregMapping(string schema)
        {
            ToTable("IREG", schema);
            HasKey(x => x.Ireg010);

            Property(x => x.Ireg010).HasColumnName(@"IREG010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ireg020).HasColumnName(@"IREG020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ireg030).HasColumnName(@"IREG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ireg040).HasColumnName(@"IREG040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Ireg050).HasColumnName(@"IREG050").HasColumnType("int").IsRequired();
            Property(x => x.Ireg060).HasColumnName(@"IREG060").HasColumnType("datetime").IsRequired();
            Property(x => x.Ireg070).HasColumnName(@"IREG070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ireg090).HasColumnName(@"IREG090").HasColumnType("datetime").IsRequired();
            Property(x => x.Ireg100).HasColumnName(@"IREG100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ireg110).HasColumnName(@"IREG110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ireg120).HasColumnName(@"IREG120").HasColumnType("datetime").IsRequired();
            Property(x => x.Ireg130).HasColumnName(@"IREG130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ireg150).HasColumnName(@"IREG150").HasColumnType("int").IsRequired();
            Property(x => x.Ireg080).HasColumnName(@"IREG080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Ireg140).HasColumnName(@"IREG140").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Iregdtm).HasColumnName(@"IREGDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ireg160).HasColumnName(@"IREG160").HasColumnType("int").IsRequired();
            Property(x => x.Ireg075).HasColumnName(@"IREG075").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ireg170).HasColumnName(@"IREG170").HasColumnType("int").IsRequired();
            Property(x => x.Ireg115).HasColumnName(@"IREG115").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
