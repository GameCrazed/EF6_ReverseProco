

namespace Generator
{

    public class CparMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cpar>
    {
        public CparMapping()
            : this("dbo")
        {
        }

        public CparMapping(string schema)
        {
            ToTable("CPAR", schema);
            HasKey(x => x.Cpar010);

            Property(x => x.Cpar010).HasColumnName(@"CPAR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cpar020).HasColumnName(@"CPAR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Cpar030).HasColumnName(@"CPAR030").HasColumnType("int").IsRequired();
            Property(x => x.Cpar040).HasColumnName(@"CPAR040").HasColumnType("int").IsRequired();
            Property(x => x.Cpar050).HasColumnName(@"CPAR050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cpar060).HasColumnName(@"CPAR060").HasColumnType("datetime").IsRequired();
            Property(x => x.Cpar070).HasColumnName(@"CPAR070").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar100).HasColumnName(@"CPAR100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cpar110).HasColumnName(@"CPAR110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cpar120).HasColumnName(@"CPAR120").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar130).HasColumnName(@"CPAR130").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar140).HasColumnName(@"CPAR140").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar150).HasColumnName(@"CPAR150").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar160).HasColumnName(@"CPAR160").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar170).HasColumnName(@"CPAR170").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar180).HasColumnName(@"CPAR180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cpar190).HasColumnName(@"CPAR190").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar200).HasColumnName(@"CPAR200").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar210).HasColumnName(@"CPAR210").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cpar400).HasColumnName(@"CPAR400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cpar410).HasColumnName(@"CPAR410").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
