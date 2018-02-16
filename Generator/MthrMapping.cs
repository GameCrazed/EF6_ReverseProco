

namespace Generator
{

    public class MthrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mthr>
    {
        public MthrMapping()
            : this("dbo")
        {
        }

        public MthrMapping(string schema)
        {
            ToTable("MTHR", schema);
            HasKey(x => new { x.Mthr010, x.Mthr020, x.Mthr030, x.Mthr040 });

            Property(x => x.Mthr010).HasColumnName(@"MTHR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthr020).HasColumnName(@"MTHR020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthr030).HasColumnName(@"MTHR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthr040).HasColumnName(@"MTHR040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mthr1001).HasColumnName(@"MTHR1001").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1002).HasColumnName(@"MTHR1002").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1003).HasColumnName(@"MTHR1003").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1004).HasColumnName(@"MTHR1004").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1005).HasColumnName(@"MTHR1005").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1006).HasColumnName(@"MTHR1006").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1007).HasColumnName(@"MTHR1007").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1008).HasColumnName(@"MTHR1008").HasColumnType("int").IsRequired();
            Property(x => x.Mthr1009).HasColumnName(@"MTHR1009").HasColumnType("int").IsRequired();
            Property(x => x.Mthr10010).HasColumnName(@"MTHR10010").HasColumnType("int").IsRequired();
            Property(x => x.Mthr10011).HasColumnName(@"MTHR10011").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Mthrdtm).HasColumnName(@"MTHRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
