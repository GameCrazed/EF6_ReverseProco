

namespace Generator
{

    public class KinMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Kin>
    {
        public KinMapping()
            : this("dbo")
        {
        }

        public KinMapping(string schema)
        {
            ToTable("KINS", schema);
            HasKey(x => new { x.Kins010, x.Kins020 });

            Property(x => x.Kins001).HasColumnName(@"KINS001").HasColumnType("int").IsRequired();
            Property(x => x.Kins010).HasColumnName(@"KINS010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kins020).HasColumnName(@"KINS020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kins021).HasColumnName(@"KINS021").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Kins030).HasColumnName(@"KINS030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins035).HasColumnName(@"KINS035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins040).HasColumnName(@"KINS040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins050).HasColumnName(@"KINS050").HasColumnType("smallint").IsRequired();
            Property(x => x.Kins060).HasColumnName(@"KINS060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins061).HasColumnName(@"KINS061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Kins070).HasColumnName(@"KINS070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kins080).HasColumnName(@"KINS080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Kins090).HasColumnName(@"KINS090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins091).HasColumnName(@"KINS091").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kins092).HasColumnName(@"KINS092").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Kins100).HasColumnName(@"KINS100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kins120).HasColumnName(@"KINS120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Kins130).HasColumnName(@"KINS130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins150).HasColumnName(@"KINS150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins065).HasColumnName(@"KINS065").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kins067).HasColumnName(@"KINS067").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kins140).HasColumnName(@"KINS140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kins160).HasColumnName(@"KINS160").HasColumnType("int").IsRequired();
            Property(x => x.Kins170).HasColumnName(@"KINS170").HasColumnType("int").IsRequired();
            Property(x => x.Kins180).HasColumnName(@"KINS180").HasColumnType("int").IsRequired();
            Property(x => x.Kins190).HasColumnName(@"KINS190").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
