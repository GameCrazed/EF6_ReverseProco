

namespace Generator
{

    public class WfliMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Wfli>
    {
        public WfliMapping()
            : this("dbo")
        {
        }

        public WfliMapping(string schema)
        {
            ToTable("WFLI", schema);
            HasKey(x => x.Wfli001);

            Property(x => x.Wfli010).HasColumnName(@"WFLI010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfli020).HasColumnName(@"WFLI020").HasColumnType("int").IsRequired();
            Property(x => x.Wfli025).HasColumnName(@"WFLI025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Wfli040).HasColumnName(@"WFLI040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfli050).HasColumnName(@"WFLI050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Wfli060).HasColumnName(@"WFLI060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Wfli070).HasColumnName(@"WFLI070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfli080).HasColumnName(@"WFLI080").HasColumnType("int").IsRequired();
            Property(x => x.Wfli100).HasColumnName(@"WFLI100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Wfli150).HasColumnName(@"WFLI150").HasColumnType("tinyint").IsRequired();
            Property(x => x.Wfli160).HasColumnName(@"WFLI160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfli030).HasColumnName(@"WFLI030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Wfli090).HasColumnName(@"WFLI090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Wfli110).HasColumnName(@"WFLI110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Wfli170).HasColumnName(@"WFLI170").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Wfli001).HasColumnName(@"WFLI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Wflidtm).HasColumnName(@"WFLIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Wfli310).HasColumnName(@"WFLI310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfli350).HasColumnName(@"WFLI350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Wfli360).HasColumnName(@"WFLI360").HasColumnType("smallint").IsRequired();
            Property(x => x.Wfli370).HasColumnName(@"WFLI370").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfli400).HasColumnName(@"WFLI400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfli410).HasColumnName(@"WFLI410").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
        }
    }

}
