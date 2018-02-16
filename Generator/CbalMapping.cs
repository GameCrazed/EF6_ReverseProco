

namespace Generator
{

    public class CbalMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cbal>
    {
        public CbalMapping()
            : this("dbo")
        {
        }

        public CbalMapping(string schema)
        {
            ToTable("CBAL", schema);
            HasKey(x => x.Cbal001);

            Property(x => x.Cbal001).HasColumnName(@"CBAL001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cbal025).HasColumnName(@"CBAL025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal027).HasColumnName(@"CBAL027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0501).HasColumnName(@"CBAL0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0502).HasColumnName(@"CBAL0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0503).HasColumnName(@"CBAL0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0504).HasColumnName(@"CBAL0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0505).HasColumnName(@"CBAL0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0506).HasColumnName(@"CBAL0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0507).HasColumnName(@"CBAL0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0508).HasColumnName(@"CBAL0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0509).HasColumnName(@"CBAL0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal05010).HasColumnName(@"CBAL05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal05011).HasColumnName(@"CBAL05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal05012).HasColumnName(@"CBAL05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal05013).HasColumnName(@"CBAL05013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal05014).HasColumnName(@"CBAL05014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal05015).HasColumnName(@"CBAL05015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0701).HasColumnName(@"CBAL0701").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0702).HasColumnName(@"CBAL0702").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0703).HasColumnName(@"CBAL0703").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0704).HasColumnName(@"CBAL0704").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0705).HasColumnName(@"CBAL0705").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0706).HasColumnName(@"CBAL0706").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0707).HasColumnName(@"CBAL0707").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0708).HasColumnName(@"CBAL0708").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal0709).HasColumnName(@"CBAL0709").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal07010).HasColumnName(@"CBAL07010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal07011).HasColumnName(@"CBAL07011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal07012).HasColumnName(@"CBAL07012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal07013).HasColumnName(@"CBAL07013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal07014).HasColumnName(@"CBAL07014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cbal07015).HasColumnName(@"CBAL07015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cbaldtm).HasColumnName(@"CBALDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
