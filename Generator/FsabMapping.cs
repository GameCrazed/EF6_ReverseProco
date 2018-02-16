

namespace Generator
{

    public class FsabMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fsab>
    {
        public FsabMapping()
            : this("dbo")
        {
        }

        public FsabMapping(string schema)
        {
            ToTable("FSAB", schema);
            HasKey(x => x.Fsab000);

            Property(x => x.Fsab000).HasColumnName(@"FSAB000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fsab001).HasColumnName(@"FSAB001").HasColumnType("datetime").IsRequired();
            Property(x => x.Fsab002).HasColumnName(@"FSAB002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Fsab007).HasColumnName(@"FSAB007").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fsab010).HasColumnName(@"FSAB010").HasColumnType("int").IsRequired();
            Property(x => x.Fsab011).HasColumnName(@"FSAB011").HasColumnType("int").IsRequired();
            Property(x => x.Fsab012).HasColumnName(@"FSAB012").HasColumnType("int").IsRequired();
            Property(x => x.Fsab020).HasColumnName(@"FSAB020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsab021).HasColumnName(@"FSAB021").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsab022).HasColumnName(@"FSAB022").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsab013).HasColumnName(@"FSAB013").HasColumnType("int").IsRequired();
            Property(x => x.Fsab014).HasColumnName(@"FSAB014").HasColumnType("int").IsRequired();
            Property(x => x.Fsab015).HasColumnName(@"FSAB015").HasColumnType("int").IsRequired();
            Property(x => x.Fsab023).HasColumnName(@"FSAB023").HasColumnType("int").IsRequired();
            Property(x => x.Fsab024).HasColumnName(@"FSAB024").HasColumnType("int").IsRequired();
            Property(x => x.Fsab025).HasColumnName(@"FSAB025").HasColumnType("int").IsRequired();
        }
    }

}
