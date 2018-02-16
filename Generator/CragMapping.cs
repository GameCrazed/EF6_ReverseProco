

namespace Generator
{

    public class CragMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Crag>
    {
        public CragMapping()
            : this("dbo")
        {
        }

        public CragMapping(string schema)
        {
            ToTable("CRAG", schema);
            HasKey(x => x.Crag000);

            Property(x => x.Crag000).HasColumnName(@"CRAG000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Crag031).HasColumnName(@"CRAG031").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag032).HasColumnName(@"CRAG032").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag033).HasColumnName(@"CRAG033").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag034).HasColumnName(@"CRAG034").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag035).HasColumnName(@"CRAG035").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag036).HasColumnName(@"CRAG036").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Crag050).HasColumnName(@"CRAG050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crag060).HasColumnName(@"CRAG060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Crag061).HasColumnName(@"CRAG061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag062).HasColumnName(@"CRAG062").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag063).HasColumnName(@"CRAG063").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag064).HasColumnName(@"CRAG064").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag065).HasColumnName(@"CRAG065").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag066).HasColumnName(@"CRAG066").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Crag067).HasColumnName(@"CRAG067").HasColumnType("datetime").IsRequired();
            Property(x => x.Crag070).HasColumnName(@"CRAG070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Crag075).HasColumnName(@"CRAG075").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag080).HasColumnName(@"CRAG080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag081).HasColumnName(@"CRAG081").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag082).HasColumnName(@"CRAG082").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Crag085).HasColumnName(@"CRAG085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Crag086).HasColumnName(@"CRAG086").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Crag087).HasColumnName(@"CRAG087").HasColumnType("tinyint").IsRequired();
            Property(x => x.Crag100).HasColumnName(@"CRAG100").HasColumnType("tinyint").IsRequired();
        }
    }

}
