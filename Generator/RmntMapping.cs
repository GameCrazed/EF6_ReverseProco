

namespace Generator
{

    public class RmntMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rmnt>
    {
        public RmntMapping()
            : this("dbo")
        {
        }

        public RmntMapping(string schema)
        {
            ToTable("RMNT", schema);
            HasKey(x => x.Rmnt001);

            Property(x => x.Rmnt001).HasColumnName(@"RMNT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Rmnt005).HasColumnName(@"RMNT005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Rmnt010).HasColumnName(@"RMNT010").HasColumnType("int").IsRequired();
            Property(x => x.Rmnt012).HasColumnName(@"RMNT012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Rmnt015).HasColumnName(@"RMNT015").HasColumnType("int").IsRequired();
            Property(x => x.Rmnt020).HasColumnName(@"RMNT020").HasColumnType("int").IsRequired();
            Property(x => x.Rmnt030).HasColumnName(@"RMNT030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rmnt040).HasColumnName(@"RMNT040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rmnt050).HasColumnName(@"RMNT050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rmnt100).HasColumnName(@"RMNT100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Rmnt110).HasColumnName(@"RMNT110").HasColumnType("datetime").IsRequired();
            Property(x => x.Rmnt300).HasColumnName(@"RMNT300").HasColumnType("tinyint").IsRequired();
            Property(x => x.Rmnt500).HasColumnName(@"RMNT500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
        }
    }

}
