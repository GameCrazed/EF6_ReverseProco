

namespace Generator
{

    public class PmanMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pman>
    {
        public PmanMapping()
            : this("dbo")
        {
        }

        public PmanMapping(string schema)
        {
            ToTable("PMAN", schema);
            HasKey(x => x.Pman030);

            Property(x => x.Pman010).HasColumnName(@"PMAN010").HasColumnType("int").IsRequired();
            Property(x => x.Pman020).HasColumnName(@"PMAN020").HasColumnType("int").IsRequired();
            Property(x => x.Pman030).HasColumnName(@"PMAN030").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pman040).HasColumnName(@"PMAN040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Pman050).HasColumnName(@"PMAN050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Pman060).HasColumnName(@"PMAN060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pman070).HasColumnName(@"PMAN070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pman080).HasColumnName(@"PMAN080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Pman090).HasColumnName(@"PMAN090").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pman100).HasColumnName(@"PMAN100").HasColumnType("datetime").IsRequired();
            Property(x => x.Pman110).HasColumnName(@"PMAN110").HasColumnType("smallint").IsRequired();
            Property(x => x.Pmandtm).HasColumnName(@"PMANDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Pman230).HasColumnName(@"PMAN230").HasColumnType("int").IsRequired();
        }
    }

}
