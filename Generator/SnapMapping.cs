

namespace Generator
{

    public class SnapMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Snap>
    {
        public SnapMapping()
            : this("dbo")
        {
        }

        public SnapMapping(string schema)
        {
            ToTable("SNAP", schema);
            HasKey(x => new { x.Snap010, x.Snap020 });

            Property(x => x.Snap010).HasColumnName(@"SNAP010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Snap020).HasColumnName(@"SNAP020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Snap0501).HasColumnName(@"SNAP0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0502).HasColumnName(@"SNAP0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0503).HasColumnName(@"SNAP0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0504).HasColumnName(@"SNAP0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0505).HasColumnName(@"SNAP0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0506).HasColumnName(@"SNAP0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0507).HasColumnName(@"SNAP0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0508).HasColumnName(@"SNAP0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap0509).HasColumnName(@"SNAP0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap05010).HasColumnName(@"SNAP05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap05011).HasColumnName(@"SNAP05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap05012).HasColumnName(@"SNAP05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap060).HasColumnName(@"SNAP060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap070).HasColumnName(@"SNAP070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap080).HasColumnName(@"SNAP080").HasColumnType("datetime").IsRequired();
            Property(x => x.Snap090).HasColumnName(@"SNAP090").HasColumnType("smallint").IsRequired();
            Property(x => x.Snap095).HasColumnName(@"SNAP095").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap100).HasColumnName(@"SNAP100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap120).HasColumnName(@"SNAP120").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap130).HasColumnName(@"SNAP130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap140).HasColumnName(@"SNAP140").HasColumnType("datetime").IsRequired();
            Property(x => x.Snap150).HasColumnName(@"SNAP150").HasColumnType("datetime").IsRequired();
            Property(x => x.Snap160).HasColumnName(@"SNAP160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap170).HasColumnName(@"SNAP170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap180).HasColumnName(@"SNAP180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap200).HasColumnName(@"SNAP200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap220).HasColumnName(@"SNAP220").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap230).HasColumnName(@"SNAP230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap240).HasColumnName(@"SNAP240").HasColumnType("datetime").IsRequired();
            Property(x => x.Snap250).HasColumnName(@"SNAP250").HasColumnType("datetime").IsRequired();
            Property(x => x.Snap270).HasColumnName(@"SNAP270").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap280).HasColumnName(@"SNAP280").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap330).HasColumnName(@"SNAP330").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap340).HasColumnName(@"SNAP340").HasColumnType("datetime").IsRequired();
            Property(x => x.Snap350).HasColumnName(@"SNAP350").HasColumnType("datetime").IsRequired();
            Property(x => x.Snap370).HasColumnName(@"SNAP370").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap700).HasColumnName(@"SNAP700").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Snap730).HasColumnName(@"SNAP730").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snapdtm).HasColumnName(@"SNAPDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Snap800).HasColumnName(@"SNAP800").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap810).HasColumnName(@"SNAP810").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap820).HasColumnName(@"SNAP820").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap830).HasColumnName(@"SNAP830").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap840).HasColumnName(@"SNAP840").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Snap850).HasColumnName(@"SNAP850").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap600).HasColumnName(@"SNAP600").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap605).HasColumnName(@"SNAP605").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Snap335).HasColumnName(@"SNAP335").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap337).HasColumnName(@"SNAP337").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap338).HasColumnName(@"SNAP338").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap372).HasColumnName(@"SNAP372").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap374).HasColumnName(@"SNAP374").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap400).HasColumnName(@"SNAP400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap405).HasColumnName(@"SNAP405").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap410).HasColumnName(@"SNAP410").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap420).HasColumnName(@"SNAP420").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap425).HasColumnName(@"SNAP425").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap450).HasColumnName(@"SNAP450").HasColumnType("smallint").IsRequired();
            Property(x => x.Snap455).HasColumnName(@"SNAP455").HasColumnType("int").IsRequired();
            Property(x => x.Snap870).HasColumnName(@"SNAP870").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap401).HasColumnName(@"SNAP401").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap406).HasColumnName(@"SNAP406").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Snap422).HasColumnName(@"SNAP422").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Snap375).HasColumnName(@"SNAP375").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
