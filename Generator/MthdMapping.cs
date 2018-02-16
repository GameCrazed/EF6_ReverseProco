

namespace Generator
{

    public class MthdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mthd>
    {
        public MthdMapping()
            : this("dbo")
        {
        }

        public MthdMapping(string schema)
        {
            ToTable("MTHD", schema);
            HasKey(x => new { x.Mthd010, x.Mthd020, x.Mthd030, x.Mthd040 });

            Property(x => x.Mthd010).HasColumnName(@"MTHD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthd020).HasColumnName(@"MTHD020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthd030).HasColumnName(@"MTHD030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthd040).HasColumnName(@"MTHD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthd1001).HasColumnName(@"MTHD1001").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1002).HasColumnName(@"MTHD1002").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1003).HasColumnName(@"MTHD1003").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1004).HasColumnName(@"MTHD1004").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1005).HasColumnName(@"MTHD1005").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1006).HasColumnName(@"MTHD1006").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1007).HasColumnName(@"MTHD1007").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1008).HasColumnName(@"MTHD1008").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd1009).HasColumnName(@"MTHD1009").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd10010).HasColumnName(@"MTHD10010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd10011).HasColumnName(@"MTHD10011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd10012).HasColumnName(@"MTHD10012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mthd110).HasColumnName(@"MTHD110").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Mthddtm).HasColumnName(@"MTHDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
