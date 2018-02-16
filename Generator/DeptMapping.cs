

namespace Generator
{

    public class DeptMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dept>
    {
        public DeptMapping()
            : this("dbo")
        {
        }

        public DeptMapping(string schema)
        {
            ToTable("DEPT", schema);
            HasKey(x => x.Dept010);

            Property(x => x.Dept010).HasColumnName(@"DEPT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Dept020).HasColumnName(@"DEPT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Dept030).HasColumnName(@"DEPT030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Dept040).HasColumnName(@"DEPT040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dept050).HasColumnName(@"DEPT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dept200).HasColumnName(@"DEPT200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept100).HasColumnName(@"DEPT100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Dept150).HasColumnName(@"DEPT150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Dept160).HasColumnName(@"DEPT160").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Dept170).HasColumnName(@"DEPT170").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Dept210).HasColumnName(@"DEPT210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Deptdtm).HasColumnName(@"DEPTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Dept301).HasColumnName(@"DEPT301").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept302).HasColumnName(@"DEPT302").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept303).HasColumnName(@"DEPT303").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept304).HasColumnName(@"DEPT304").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept305).HasColumnName(@"DEPT305").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept306).HasColumnName(@"DEPT306").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept307).HasColumnName(@"DEPT307").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept308).HasColumnName(@"DEPT308").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept309).HasColumnName(@"DEPT309").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept310).HasColumnName(@"DEPT310").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept220).HasColumnName(@"DEPT220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Dept230).HasColumnName(@"DEPT230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Dept400).HasColumnName(@"DEPT400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Dept312).HasColumnName(@"DEPT312").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept313).HasColumnName(@"DEPT313").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept314).HasColumnName(@"DEPT314").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept315).HasColumnName(@"DEPT315").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dept180).HasColumnName(@"DEPT180").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Dept001).HasColumnName(@"DEPT001").HasColumnType("int").IsRequired();
            Property(x => x.Dept240).HasColumnName(@"DEPT240").HasColumnType("int").IsRequired();
            Property(x => x.Dept250).HasColumnName(@"DEPT250").HasColumnType("datetime").IsRequired();
            Property(x => x.Dept360).HasColumnName(@"DEPT360").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
