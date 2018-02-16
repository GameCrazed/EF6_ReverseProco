

namespace Generator
{

    public class TrcdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trcd>
    {
        public TrcdMapping()
            : this("dbo")
        {
        }

        public TrcdMapping(string schema)
        {
            ToTable("TRCD", schema);
            HasKey(x => x.Trcd010);

            Property(x => x.Trcd010).HasColumnName(@"TRCD010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trcd020).HasColumnName(@"TRCD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd040).HasColumnName(@"TRCD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd050).HasColumnName(@"TRCD050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd051).HasColumnName(@"TRCD051").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd055).HasColumnName(@"TRCD055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd060).HasColumnName(@"TRCD060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Trcd070).HasColumnName(@"TRCD070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Trcd090).HasColumnName(@"TRCD090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd1001).HasColumnName(@"TRCD1001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1002).HasColumnName(@"TRCD1002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1003).HasColumnName(@"TRCD1003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1004).HasColumnName(@"TRCD1004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1005).HasColumnName(@"TRCD1005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1006).HasColumnName(@"TRCD1006").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1007).HasColumnName(@"TRCD1007").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1008).HasColumnName(@"TRCD1008").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd1009).HasColumnName(@"TRCD1009").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10010).HasColumnName(@"TRCD10010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10011).HasColumnName(@"TRCD10011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10012).HasColumnName(@"TRCD10012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10013).HasColumnName(@"TRCD10013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10014).HasColumnName(@"TRCD10014").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10015).HasColumnName(@"TRCD10015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10016).HasColumnName(@"TRCD10016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10017).HasColumnName(@"TRCD10017").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10018).HasColumnName(@"TRCD10018").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10019).HasColumnName(@"TRCD10019").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd10020).HasColumnName(@"TRCD10020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd110).HasColumnName(@"TRCD110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd120).HasColumnName(@"TRCD120").HasColumnType("datetime").IsRequired();
            Property(x => x.Trcd130).HasColumnName(@"TRCD130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trcd140).HasColumnName(@"TRCD140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd030).HasColumnName(@"TRCD030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Trcddtm).HasColumnName(@"TRCDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Trcd200).HasColumnName(@"TRCD200").HasColumnType("int").IsRequired();
            Property(x => x.Trcd210).HasColumnName(@"TRCD210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd080).HasColumnName(@"TRCD080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Trcd056).HasColumnName(@"TRCD056").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd085).HasColumnName(@"TRCD085").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Trcd052).HasColumnName(@"TRCD052").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Trcd095).HasColumnName(@"TRCD095").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trcd150).HasColumnName(@"TRCD150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
