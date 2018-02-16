

namespace Generator
{

    public class FsadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fsad>
    {
        public FsadMapping()
            : this("dbo")
        {
        }

        public FsadMapping(string schema)
        {
            ToTable("FSAD", schema);
            HasKey(x => x.Fsad000);

            Property(x => x.Fsad000).HasColumnName(@"FSAD000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fsad001).HasColumnName(@"FSAD001").HasColumnType("datetime").IsRequired();
            Property(x => x.Fsad002).HasColumnName(@"FSAD002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Fsad003).HasColumnName(@"FSAD003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Fsad901).HasColumnName(@"FSAD901").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad902).HasColumnName(@"FSAD902").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad903).HasColumnName(@"FSAD903").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad905).HasColumnName(@"FSAD905").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad907).HasColumnName(@"FSAD907").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad909).HasColumnName(@"FSAD909").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad910).HasColumnName(@"FSAD910").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad912).HasColumnName(@"FSAD912").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Fsad007).HasColumnName(@"FSAD007").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
