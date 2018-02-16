

namespace Generator
{

    public class DisbMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Disb>
    {
        public DisbMapping()
            : this("dbo")
        {
        }

        public DisbMapping(string schema)
        {
            ToTable("DISB", schema);
            HasKey(x => new { x.Disb001, x.Disb010, x.Disb000 });

            Property(x => x.Disb000).HasColumnName(@"DISB000").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Disb001).HasColumnName(@"DISB001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Disb005).HasColumnName(@"DISB005").HasColumnType("datetime").IsRequired();
            Property(x => x.Disb006).HasColumnName(@"DISB006").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Disb010).HasColumnName(@"DISB010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Disb020).HasColumnName(@"DISB020").HasColumnType("int").IsRequired();
            Property(x => x.Disb025).HasColumnName(@"DISB025").HasColumnType("tinyint").IsRequired();
            Property(x => x.Disb030).HasColumnName(@"DISB030").HasColumnType("int").IsRequired();
            Property(x => x.Disb040).HasColumnName(@"DISB040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Disb060).HasColumnName(@"DISB060").HasColumnType("int").IsRequired();
            Property(x => x.Disb090).HasColumnName(@"DISB090").HasColumnType("datetime").IsRequired();
            Property(x => x.Disb070).HasColumnName(@"DISB070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Disb080).HasColumnName(@"DISB080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Disb100).HasColumnName(@"DISB100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Disb200).HasColumnName(@"DISB200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Disb150).HasColumnName(@"DISB150").HasColumnType("datetime").IsRequired();
            Property(x => x.Disb110).HasColumnName(@"DISB110").HasColumnType("int").IsRequired();
        }
    }

}
