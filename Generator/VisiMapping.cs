

namespace Generator
{

    public class VisiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Visi>
    {
        public VisiMapping()
            : this("dbo")
        {
        }

        public VisiMapping(string schema)
        {
            ToTable("VISI", schema);
            HasKey(x => x.Visi000);

            Property(x => x.Visi000).HasColumnName(@"VISI000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Visi010).HasColumnName(@"VISI010").HasColumnType("int").IsRequired();
            Property(x => x.Visi015).HasColumnName(@"VISI015").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi020).HasColumnName(@"VISI020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Visi025).HasColumnName(@"VISI025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Visi030).HasColumnName(@"VISI030").HasColumnType("int").IsRequired();
            Property(x => x.Visi035).HasColumnName(@"VISI035").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi040).HasColumnName(@"VISI040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi050).HasColumnName(@"VISI050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Visi060).HasColumnName(@"VISI060").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi070).HasColumnName(@"VISI070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi075).HasColumnName(@"VISI075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi080).HasColumnName(@"VISI080").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi085).HasColumnName(@"VISI085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Visi100).HasColumnName(@"VISI100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi105).HasColumnName(@"VISI105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi110).HasColumnName(@"VISI110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi1151).HasColumnName(@"VISI1151").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi1152).HasColumnName(@"VISI1152").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi1153).HasColumnName(@"VISI1153").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi1154).HasColumnName(@"VISI1154").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi1155).HasColumnName(@"VISI1155").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi120).HasColumnName(@"VISI120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi125).HasColumnName(@"VISI125").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi130).HasColumnName(@"VISI130").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi200).HasColumnName(@"VISI200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi210).HasColumnName(@"VISI210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi220).HasColumnName(@"VISI220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi230).HasColumnName(@"VISI230").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi300).HasColumnName(@"VISI300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi310).HasColumnName(@"VISI310").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi390).HasColumnName(@"VISI390").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Visi122).HasColumnName(@"VISI122").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi600).HasColumnName(@"VISI600").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi610).HasColumnName(@"VISI610").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi630).HasColumnName(@"VISI630").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi631).HasColumnName(@"VISI631").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi635).HasColumnName(@"VISI635").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi640).HasColumnName(@"VISI640").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi642).HasColumnName(@"VISI642").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi645).HasColumnName(@"VISI645").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi650).HasColumnName(@"VISI650").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi651).HasColumnName(@"VISI651").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi655).HasColumnName(@"VISI655").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi660).HasColumnName(@"VISI660").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Visi665).HasColumnName(@"VISI665").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi670).HasColumnName(@"VISI670").HasColumnType("tinyint").IsRequired();
            Property(x => x.Visi680).HasColumnName(@"VISI680").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi682).HasColumnName(@"VISI682").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi685).HasColumnName(@"VISI685").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi021).HasColumnName(@"VISI021").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi690).HasColumnName(@"VISI690").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi691).HasColumnName(@"VISI691").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi692).HasColumnName(@"VISI692").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi693).HasColumnName(@"VISI693").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi637).HasColumnName(@"VISI637").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi657).HasColumnName(@"VISI657").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi695).HasColumnName(@"VISI695").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Visi697).HasColumnName(@"VISI697").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Visi106).HasColumnName(@"VISI106").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Visi636).HasColumnName(@"VISI636").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi656).HasColumnName(@"VISI656").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Visi700).HasColumnName(@"VISI700").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Visi701).HasColumnName(@"VISI701").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Visi702).HasColumnName(@"VISI702").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi703).HasColumnName(@"VISI703").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi704).HasColumnName(@"VISI704").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Visi705).HasColumnName(@"VISI705").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Visi706).HasColumnName(@"VISI706").HasColumnType("datetime").IsRequired();
            Property(x => x.Visi707).HasColumnName(@"VISI707").HasColumnType("datetime").IsRequired();
        }
    }

}
