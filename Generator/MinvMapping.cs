

namespace Generator
{

    public class MinvMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Minv>
    {
        public MinvMapping()
            : this("dbo")
        {
        }

        public MinvMapping(string schema)
        {
            ToTable("MINV", schema);
            HasKey(x => x.Minv050);

            Property(x => x.Minv010).HasColumnName(@"MINV010").HasColumnType("int").IsRequired();
            Property(x => x.Minv020).HasColumnName(@"MINV020").HasColumnType("datetime").IsRequired();
            Property(x => x.Minv030).HasColumnName(@"MINV030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Minv040).HasColumnName(@"MINV040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Minv050).HasColumnName(@"MINV050").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Minv060).HasColumnName(@"MINV060").HasColumnType("datetime").IsRequired();
            Property(x => x.Minv070).HasColumnName(@"MINV070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Minv080).HasColumnName(@"MINV080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Minv090).HasColumnName(@"MINV090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Minv100).HasColumnName(@"MINV100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Minv110).HasColumnName(@"MINV110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Minv120).HasColumnName(@"MINV120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Minv130).HasColumnName(@"MINV130").HasColumnType("int").IsRequired();
            Property(x => x.Minv1401).HasColumnName(@"MINV1401").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Minv1402).HasColumnName(@"MINV1402").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Minv1403).HasColumnName(@"MINV1403").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Minv150).HasColumnName(@"MINV150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Minv1601).HasColumnName(@"MINV1601").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Minv1602).HasColumnName(@"MINV1602").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Minv1603).HasColumnName(@"MINV1603").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Minv1604).HasColumnName(@"MINV1604").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Minv1605).HasColumnName(@"MINV1605").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Minvdtm).HasColumnName(@"MINVDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Minv065).HasColumnName(@"MINV065").HasColumnType("int").IsRequired();
            Property(x => x.Minv115).HasColumnName(@"MINV115").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Minv117).HasColumnName(@"MINV117").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
