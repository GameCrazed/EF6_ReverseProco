

namespace Generator
{

    public class NbnoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbno>
    {
        public NbnoMapping()
            : this("dbo")
        {
        }

        public NbnoMapping(string schema)
        {
            ToTable("NBNO", schema);
            HasKey(x => x.Nbno999);

            Property(x => x.Nbno001).HasColumnName(@"NBNO001").HasColumnType("int").IsRequired();
            Property(x => x.Nbno002).HasColumnName(@"NBNO002").HasColumnType("int").IsRequired();
            Property(x => x.Nbno010).HasColumnName(@"NBNO010").HasColumnType("int").IsRequired();
            Property(x => x.Nbno020).HasColumnName(@"NBNO020").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbno021).HasColumnName(@"NBNO021").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbno030).HasColumnName(@"NBNO030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbno060).HasColumnName(@"NBNO060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbno070).HasColumnName(@"NBNO070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbno080).HasColumnName(@"NBNO080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbno100).HasColumnName(@"NBNO100").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Nbno150).HasColumnName(@"NBNO150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbno160).HasColumnName(@"NBNO160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbno170).HasColumnName(@"NBNO170").HasColumnType("int").IsRequired();
            Property(x => x.Nbno175).HasColumnName(@"NBNO175").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbno180).HasColumnName(@"NBNO180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Nbno190).HasColumnName(@"NBNO190").HasColumnType("int").IsRequired();
            Property(x => x.Nbno200).HasColumnName(@"NBNO200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbno999).HasColumnName(@"NBNO999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbno995).HasColumnName(@"NBNO995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
