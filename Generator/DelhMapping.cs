

namespace Generator
{

    public class DelhMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Delh>
    {
        public DelhMapping()
            : this("dbo")
        {
        }

        public DelhMapping(string schema)
        {
            ToTable("DELH", schema);
            HasKey(x => new { x.Delh001, x.Delh010 });

            Property(x => x.Delh001).HasColumnName(@"DELH001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Delh010).HasColumnName(@"DELH010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Delh0501).HasColumnName(@"DELH0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0502).HasColumnName(@"DELH0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0503).HasColumnName(@"DELH0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0504).HasColumnName(@"DELH0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0505).HasColumnName(@"DELH0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0506).HasColumnName(@"DELH0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0507).HasColumnName(@"DELH0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0508).HasColumnName(@"DELH0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh0509).HasColumnName(@"DELH0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh05010).HasColumnName(@"DELH05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh05011).HasColumnName(@"DELH05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh05012).HasColumnName(@"DELH05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Delh060).HasColumnName(@"DELH060").HasColumnType("smallint").IsRequired();
            Property(x => x.Delh070).HasColumnName(@"DELH070").HasColumnType("smallint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Delhdtm).HasColumnName(@"DELHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
