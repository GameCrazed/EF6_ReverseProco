

namespace Generator
{

    public class MlarMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mlar>
    {
        public MlarMapping()
            : this("dbo")
        {
        }

        public MlarMapping(string schema)
        {
            ToTable("MLAR", schema);
            HasKey(x => x.Mlar000);

            Property(x => x.Mlar000).HasColumnName(@"MLAR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Mlar001).HasColumnName(@"MLAR001").HasColumnType("int").IsRequired();
            Property(x => x.Mlar002).HasColumnName(@"MLAR002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Mlar005).HasColumnName(@"MLAR005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Mlar006).HasColumnName(@"MLAR006").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Mlar008).HasColumnName(@"MLAR008").HasColumnType("datetime").IsRequired();
            Property(x => x.Mlar009).HasColumnName(@"MLAR009").HasColumnType("datetime").IsRequired();
            Property(x => x.Mlar011).HasColumnName(@"MLAR011").HasColumnType("int").IsRequired();
            Property(x => x.Mlar015).HasColumnName(@"MLAR015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mlar020).HasColumnName(@"MLAR020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar021).HasColumnName(@"MLAR021").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar022).HasColumnName(@"MLAR022").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar023).HasColumnName(@"MLAR023").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar024).HasColumnName(@"MLAR024").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar025).HasColumnName(@"MLAR025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar026).HasColumnName(@"MLAR026").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar027).HasColumnName(@"MLAR027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar028).HasColumnName(@"MLAR028").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar029).HasColumnName(@"MLAR029").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar030).HasColumnName(@"MLAR030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar031).HasColumnName(@"MLAR031").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar040).HasColumnName(@"MLAR040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mlar050).HasColumnName(@"MLAR050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar051).HasColumnName(@"MLAR051").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mlar070).HasColumnName(@"MLAR070").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Mlar075).HasColumnName(@"MLAR075").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mlar080).HasColumnName(@"MLAR080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar160).HasColumnName(@"MLAR160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar161).HasColumnName(@"MLAR161").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar162).HasColumnName(@"MLAR162").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar164).HasColumnName(@"MLAR164").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar165).HasColumnName(@"MLAR165").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar200).HasColumnName(@"MLAR200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mlar201).HasColumnName(@"MLAR201").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mlar202).HasColumnName(@"MLAR202").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mlar203).HasColumnName(@"MLAR203").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mlar250).HasColumnName(@"MLAR250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mlar270).HasColumnName(@"MLAR270").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mlar280).HasColumnName(@"MLAR280").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mlar290).HasColumnName(@"MLAR290").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar295).HasColumnName(@"MLAR295").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar034).HasColumnName(@"MLAR034").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar035).HasColumnName(@"MLAR035").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar036).HasColumnName(@"MLAR036").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar033).HasColumnName(@"MLAR033").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar038).HasColumnName(@"MLAR038").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar039).HasColumnName(@"MLAR039").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mlar003).HasColumnName(@"MLAR003").HasColumnType("int").IsRequired();
            Property(x => x.Mlar007).HasColumnName(@"MLAR007").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
