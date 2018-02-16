

namespace Generator
{

    public class JobMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Job>
    {
        public JobMapping()
            : this("dbo")
        {
        }

        public JobMapping(string schema)
        {
            ToTable("JOBS", schema);
            HasKey(x => x.Jobs010);

            Property(x => x.Jobs010).HasColumnName(@"JOBS010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Jobs020).HasColumnName(@"JOBS020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs030).HasColumnName(@"JOBS030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs040).HasColumnName(@"JOBS040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs050).HasColumnName(@"JOBS050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Jobs055).HasColumnName(@"JOBS055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs060).HasColumnName(@"JOBS060").HasColumnType("smallint").IsRequired();
            Property(x => x.Jobs061).HasColumnName(@"JOBS061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Jobs070).HasColumnName(@"JOBS070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Jobs090).HasColumnName(@"JOBS090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs100).HasColumnName(@"JOBS100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Jobs120).HasColumnName(@"JOBS120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Jobs130).HasColumnName(@"JOBS130").HasColumnType("int").IsRequired();
            Property(x => x.Jobs140).HasColumnName(@"JOBS140").HasColumnType("int").IsRequired();
            Property(x => x.Jobs080).HasColumnName(@"JOBS080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Jobsdtm).HasColumnName(@"JOBSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Jobs150).HasColumnName(@"JOBS150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Jobs160).HasColumnName(@"JOBS160").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Jobs065).HasColumnName(@"JOBS065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs085).HasColumnName(@"JOBS085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs170).HasColumnName(@"JOBS170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs035).HasColumnName(@"JOBS035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs062).HasColumnName(@"JOBS062").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Jobs075).HasColumnName(@"JOBS075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Jobs110).HasColumnName(@"JOBS110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs056).HasColumnName(@"JOBS056").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs077).HasColumnName(@"JOBS077").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs190).HasColumnName(@"JOBS190").HasColumnType("int").IsRequired();
            Property(x => x.Jobs175).HasColumnName(@"JOBS175").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Jobs300).HasColumnName(@"JOBS300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Jobs310).HasColumnName(@"JOBS310").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Jobs320).HasColumnName(@"JOBS320").HasColumnType("tinyint").IsRequired();
            Property(x => x.Jobs330).HasColumnName(@"JOBS330").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
