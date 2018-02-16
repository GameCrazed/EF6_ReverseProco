

namespace Generator
{

    public class InstMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Inst>
    {
        public InstMapping()
            : this("dbo")
        {
        }

        public InstMapping(string schema)
        {
            ToTable("INST", schema);
            HasKey(x => new { x.Inst010, x.Inst100 });

            Property(x => x.Inst010).HasColumnName(@"INST010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Inst015).HasColumnName(@"INST015").HasColumnType("int").IsRequired();
            Property(x => x.Inst020).HasColumnName(@"INST020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Inst030).HasColumnName(@"INST030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Inst040).HasColumnName(@"INST040").HasColumnType("int").IsRequired();
            Property(x => x.Inst050).HasColumnName(@"INST050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Inst060).HasColumnName(@"INST060").HasColumnType("int").IsRequired();
            Property(x => x.Inst070).HasColumnName(@"INST070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Inst080).HasColumnName(@"INST080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Inst090).HasColumnName(@"INST090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Inst100).HasColumnName(@"INST100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
