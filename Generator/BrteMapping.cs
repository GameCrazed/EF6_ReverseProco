

namespace Generator
{

    public class BrteMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Brte>
    {
        public BrteMapping()
            : this("dbo")
        {
        }

        public BrteMapping(string schema)
        {
            ToTable("BRTE", schema);
            HasKey(x => new { x.Brte010, x.Brte005 });

            Property(x => x.Brte001).HasColumnName(@"BRTE001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brte010).HasColumnName(@"BRTE010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Brte020).HasColumnName(@"BRTE020").HasColumnType("datetime").IsRequired();
            Property(x => x.Brte030).HasColumnName(@"BRTE030").HasColumnType("int").IsRequired();
            Property(x => x.Brte032).HasColumnName(@"BRTE032").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Brte034).HasColumnName(@"BRTE034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Brte035).HasColumnName(@"BRTE035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brte036).HasColumnName(@"BRTE036").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brte040).HasColumnName(@"BRTE040").HasColumnType("int").IsRequired();
            Property(x => x.Brte042).HasColumnName(@"BRTE042").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Brte044).HasColumnName(@"BRTE044").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Brte045).HasColumnName(@"BRTE045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brte046).HasColumnName(@"BRTE046").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brte048).HasColumnName(@"BRTE048").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Brte050).HasColumnName(@"BRTE050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte052).HasColumnName(@"BRTE052").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte054).HasColumnName(@"BRTE054").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brte056).HasColumnName(@"BRTE056").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brte060).HasColumnName(@"BRTE060").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte062).HasColumnName(@"BRTE062").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte064).HasColumnName(@"BRTE064").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brte066).HasColumnName(@"BRTE066").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Brte070).HasColumnName(@"BRTE070").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte075).HasColumnName(@"BRTE075").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte078).HasColumnName(@"BRTE078").HasColumnType("datetime").IsRequired();
            Property(x => x.Brte080).HasColumnName(@"BRTE080").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte085).HasColumnName(@"BRTE085").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brte088).HasColumnName(@"BRTE088").HasColumnType("datetime").IsRequired();
            Property(x => x.Brte090).HasColumnName(@"BRTE090").HasColumnType("datetime").IsRequired();
            Property(x => x.Brte100).HasColumnName(@"BRTE100").HasColumnType("datetime").IsRequired();
            Property(x => x.Brte005).HasColumnName(@"BRTE005").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Brte105).HasColumnName(@"BRTE105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brte110).HasColumnName(@"BRTE110").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
