

namespace Generator
{

    public class MoanMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Moan>
    {
        public MoanMapping()
            : this("dbo")
        {
        }

        public MoanMapping(string schema)
        {
            ToTable("MOAN", schema);
            HasKey(x => new { x.Moan010, x.Moan020, x.Moan030, x.Moan040 });

            Property(x => x.Moan010).HasColumnName(@"MOAN010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Moan020).HasColumnName(@"MOAN020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Moan030).HasColumnName(@"MOAN030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Moan040).HasColumnName(@"MOAN040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Moan0501).HasColumnName(@"MOAN0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0502).HasColumnName(@"MOAN0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0503).HasColumnName(@"MOAN0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0504).HasColumnName(@"MOAN0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0505).HasColumnName(@"MOAN0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0506).HasColumnName(@"MOAN0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0507).HasColumnName(@"MOAN0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0508).HasColumnName(@"MOAN0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan0509).HasColumnName(@"MOAN0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan05010).HasColumnName(@"MOAN05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan05011).HasColumnName(@"MOAN05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Moan05012).HasColumnName(@"MOAN05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Moandtm).HasColumnName(@"MOANDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
