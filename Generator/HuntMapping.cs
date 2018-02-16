

namespace Generator
{

    public class HuntMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Hunt>
    {
        public HuntMapping()
            : this("dbo")
        {
        }

        public HuntMapping(string schema)
        {
            ToTable("HUNT", schema);
            HasKey(x => new { x.Hunt001, x.Hunt010, x.Hunt030 });

            Property(x => x.Hunt001).HasColumnName(@"HUNT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Hunt010).HasColumnName(@"HUNT010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Hunt020).HasColumnName(@"HUNT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Hunt030).HasColumnName(@"HUNT030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Hunt040).HasColumnName(@"HUNT040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Hunt050).HasColumnName(@"HUNT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Hunt060).HasColumnName(@"HUNT060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Hunt070).HasColumnName(@"HUNT070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Hunt080).HasColumnName(@"HUNT080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Hunt090).HasColumnName(@"HUNT090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(16);
            Property(x => x.Hunt100).HasColumnName(@"HUNT100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Hunt110).HasColumnName(@"HUNT110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Hunt120).HasColumnName(@"HUNT120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Hunt130).HasColumnName(@"HUNT130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Hunt140).HasColumnName(@"HUNT140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Hunt150).HasColumnName(@"HUNT150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Hunt160).HasColumnName(@"HUNT160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Hunt170).HasColumnName(@"HUNT170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Hunt180).HasColumnName(@"HUNT180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Hunt190).HasColumnName(@"HUNT190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Hunt200).HasColumnName(@"HUNT200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(35);
            Property(x => x.Hunt210).HasColumnName(@"HUNT210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(35);
            Property(x => x.Hunt220).HasColumnName(@"HUNT220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(35);
            Property(x => x.Hunt230).HasColumnName(@"HUNT230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(35);
            Property(x => x.Hunt240).HasColumnName(@"HUNT240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(35);
            Property(x => x.Hunt250).HasColumnName(@"HUNT250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(35);
            Property(x => x.Hunt260).HasColumnName(@"HUNT260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Hunt270).HasColumnName(@"HUNT270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Hunt280).HasColumnName(@"HUNT280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Hunt290).HasColumnName(@"HUNT290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Hunt300).HasColumnName(@"HUNT300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Hunt310).HasColumnName(@"HUNT310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Hunt000).HasColumnName(@"HUNT000").HasColumnType("int").IsRequired();
        }
    }

}
