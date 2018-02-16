

namespace Generator
{

    public class MbalMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mbal>
    {
        public MbalMapping()
            : this("dbo")
        {
        }

        public MbalMapping(string schema)
        {
            ToTable("MBAL", schema);
            HasKey(x => new { x.Mbal001, x.Mbal010 });

            Property(x => x.Mbal001).HasColumnName(@"MBAL001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mbal010).HasColumnName(@"MBAL010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mbal025).HasColumnName(@"MBAL025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal027).HasColumnName(@"MBAL027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0501).HasColumnName(@"MBAL0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0502).HasColumnName(@"MBAL0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0503).HasColumnName(@"MBAL0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0504).HasColumnName(@"MBAL0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0505).HasColumnName(@"MBAL0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0506).HasColumnName(@"MBAL0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0507).HasColumnName(@"MBAL0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0508).HasColumnName(@"MBAL0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0509).HasColumnName(@"MBAL0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal05010).HasColumnName(@"MBAL05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal05011).HasColumnName(@"MBAL05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal05012).HasColumnName(@"MBAL05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal05013).HasColumnName(@"MBAL05013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal05014).HasColumnName(@"MBAL05014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal05015).HasColumnName(@"MBAL05015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0701).HasColumnName(@"MBAL0701").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0702).HasColumnName(@"MBAL0702").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0703).HasColumnName(@"MBAL0703").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0704).HasColumnName(@"MBAL0704").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0705).HasColumnName(@"MBAL0705").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0706).HasColumnName(@"MBAL0706").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0707).HasColumnName(@"MBAL0707").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0708).HasColumnName(@"MBAL0708").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal0709).HasColumnName(@"MBAL0709").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal07010).HasColumnName(@"MBAL07010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal07011).HasColumnName(@"MBAL07011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal07012).HasColumnName(@"MBAL07012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal07013).HasColumnName(@"MBAL07013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal07014).HasColumnName(@"MBAL07014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal07015).HasColumnName(@"MBAL07015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal090).HasColumnName(@"MBAL090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal095).HasColumnName(@"MBAL095").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Mbal100).HasColumnName(@"MBAL100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Mbaldtm).HasColumnName(@"MBALDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
