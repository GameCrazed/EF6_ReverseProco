

namespace Generator
{

    public class KfibMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Kfib>
    {
        public KfibMapping()
            : this("dbo")
        {
        }

        public KfibMapping(string schema)
        {
            ToTable("KFIB", schema);
            HasKey(x => x.Kfib000);

            Property(x => x.Kfib000).HasColumnName(@"KFIB000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kfib002).HasColumnName(@"KFIB002").HasColumnType("datetime").IsRequired();
            Property(x => x.Kfib005).HasColumnName(@"KFIB005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib010).HasColumnName(@"KFIB010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib015).HasColumnName(@"KFIB015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Kfib020).HasColumnName(@"KFIB020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib025).HasColumnName(@"KFIB025").HasColumnType("smallint").IsRequired();
            Property(x => x.Kfib030).HasColumnName(@"KFIB030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib035).HasColumnName(@"KFIB035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib040).HasColumnName(@"KFIB040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Kfib045).HasColumnName(@"KFIB045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfib050).HasColumnName(@"KFIB050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfib055).HasColumnName(@"KFIB055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfib060).HasColumnName(@"KFIB060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfib065).HasColumnName(@"KFIB065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib070).HasColumnName(@"KFIB070").HasColumnType("smallint").IsRequired();
            Property(x => x.Kfib075).HasColumnName(@"KFIB075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Kfib085).HasColumnName(@"KFIB085").HasColumnType("smallint").IsRequired();
            Property(x => x.Kfib090).HasColumnName(@"KFIB090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib095).HasColumnName(@"KFIB095").HasColumnType("smallint").IsRequired();
            Property(x => x.Kfib100).HasColumnName(@"KFIB100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Kfib105).HasColumnName(@"KFIB105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib115).HasColumnName(@"KFIB115").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib120).HasColumnName(@"KFIB120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfib125).HasColumnName(@"KFIB125").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib130).HasColumnName(@"KFIB130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfib140).HasColumnName(@"KFIB140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfib145).HasColumnName(@"KFIB145").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib150).HasColumnName(@"KFIB150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib1551).HasColumnName(@"KFIB1551").HasColumnType("int").IsRequired();
            Property(x => x.Kfib1552).HasColumnName(@"KFIB1552").HasColumnType("int").IsRequired();
            Property(x => x.Kfib160).HasColumnName(@"KFIB160").HasColumnType("int").IsRequired();
            Property(x => x.Kfib165).HasColumnName(@"KFIB165").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib170).HasColumnName(@"KFIB170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Kfib175).HasColumnName(@"KFIB175").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib180).HasColumnName(@"KFIB180").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Kfib185).HasColumnName(@"KFIB185").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfib190).HasColumnName(@"KFIB190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Kfib195).HasColumnName(@"KFIB195").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Kfib001).HasColumnName(@"KFIB001").HasColumnType("int").IsRequired();
        }
    }

}
