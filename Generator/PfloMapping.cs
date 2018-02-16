

namespace Generator
{

    public class PfloMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pflo>
    {
        public PfloMapping()
            : this("dbo")
        {
        }

        public PfloMapping(string schema)
        {
            ToTable("PFLO", schema);
            HasKey(x => new { x.Pflo001, x.Pflo010 });

            Property(x => x.Pflo001).HasColumnName(@"PFLO001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pflo010).HasColumnName(@"PFLO010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pflo020).HasColumnName(@"PFLO020").HasColumnType("smallint").IsRequired();
            Property(x => x.Pflo025).HasColumnName(@"PFLO025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo027).HasColumnName(@"PFLO027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo030).HasColumnName(@"PFLO030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0501).HasColumnName(@"PFLO0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0502).HasColumnName(@"PFLO0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0503).HasColumnName(@"PFLO0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0504).HasColumnName(@"PFLO0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0505).HasColumnName(@"PFLO0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0506).HasColumnName(@"PFLO0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0507).HasColumnName(@"PFLO0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0508).HasColumnName(@"PFLO0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0509).HasColumnName(@"PFLO0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo05010).HasColumnName(@"PFLO05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo05011).HasColumnName(@"PFLO05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo05012).HasColumnName(@"PFLO05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo05013).HasColumnName(@"PFLO05013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo05014).HasColumnName(@"PFLO05014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo05015).HasColumnName(@"PFLO05015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0601).HasColumnName(@"PFLO0601").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0602).HasColumnName(@"PFLO0602").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0603).HasColumnName(@"PFLO0603").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0604).HasColumnName(@"PFLO0604").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0605).HasColumnName(@"PFLO0605").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0606).HasColumnName(@"PFLO0606").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0607).HasColumnName(@"PFLO0607").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0608).HasColumnName(@"PFLO0608").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0609).HasColumnName(@"PFLO0609").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo06010).HasColumnName(@"PFLO06010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo06011).HasColumnName(@"PFLO06011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo06012).HasColumnName(@"PFLO06012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo06013).HasColumnName(@"PFLO06013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo06014).HasColumnName(@"PFLO06014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo06015).HasColumnName(@"PFLO06015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0701).HasColumnName(@"PFLO0701").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0702).HasColumnName(@"PFLO0702").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0703).HasColumnName(@"PFLO0703").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0704).HasColumnName(@"PFLO0704").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0705).HasColumnName(@"PFLO0705").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0706).HasColumnName(@"PFLO0706").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0707).HasColumnName(@"PFLO0707").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0708).HasColumnName(@"PFLO0708").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo0709).HasColumnName(@"PFLO0709").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo07010).HasColumnName(@"PFLO07010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo07011).HasColumnName(@"PFLO07011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo07012).HasColumnName(@"PFLO07012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo07013).HasColumnName(@"PFLO07013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo07014).HasColumnName(@"PFLO07014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo07015).HasColumnName(@"PFLO07015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo080).HasColumnName(@"PFLO080").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pflo090).HasColumnName(@"PFLO090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo091).HasColumnName(@"PFLO091").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo095).HasColumnName(@"PFLO095").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo096).HasColumnName(@"PFLO096").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pflo100).HasColumnName(@"PFLO100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pflodtm).HasColumnName(@"PFLODTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
