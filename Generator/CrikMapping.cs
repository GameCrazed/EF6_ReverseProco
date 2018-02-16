

namespace Generator
{

    public class CrikMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Crik>
    {
        public CrikMapping()
            : this("dbo")
        {
        }

        public CrikMapping(string schema)
        {
            ToTable("CRIK", schema);
            HasKey(x => x.Crik001);

            Property(x => x.Crik001).HasColumnName(@"CRIK001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Crik105).HasColumnName(@"CRIK105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik120).HasColumnName(@"CRIK120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik125).HasColumnName(@"CRIK125").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik130).HasColumnName(@"CRIK130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik235).HasColumnName(@"CRIK235").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik250).HasColumnName(@"CRIK250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik265).HasColumnName(@"CRIK265").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik270).HasColumnName(@"CRIK270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik275).HasColumnName(@"CRIK275").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik300).HasColumnName(@"CRIK300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik305).HasColumnName(@"CRIK305").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik310).HasColumnName(@"CRIK310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik315).HasColumnName(@"CRIK315").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik320).HasColumnName(@"CRIK320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik400).HasColumnName(@"CRIK400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik405).HasColumnName(@"CRIK405").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik435).HasColumnName(@"CRIK435").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik460).HasColumnName(@"CRIK460").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik605).HasColumnName(@"CRIK605").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik620).HasColumnName(@"CRIK620").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik625).HasColumnName(@"CRIK625").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik630).HasColumnName(@"CRIK630").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik735).HasColumnName(@"CRIK735").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik750).HasColumnName(@"CRIK750").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik765).HasColumnName(@"CRIK765").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik770).HasColumnName(@"CRIK770").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik775).HasColumnName(@"CRIK775").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik800).HasColumnName(@"CRIK800").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik805).HasColumnName(@"CRIK805").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik810).HasColumnName(@"CRIK810").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik815).HasColumnName(@"CRIK815").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik820).HasColumnName(@"CRIK820").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik900).HasColumnName(@"CRIK900").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik905).HasColumnName(@"CRIK905").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik935).HasColumnName(@"CRIK935").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik960).HasColumnName(@"CRIK960").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Crik121).HasColumnName(@"CRIK121").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik131).HasColumnName(@"CRIK131").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik240).HasColumnName(@"CRIK240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik277).HasColumnName(@"CRIK277").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik280).HasColumnName(@"CRIK280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik281).HasColumnName(@"CRIK281").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik282).HasColumnName(@"CRIK282").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik410).HasColumnName(@"CRIK410").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik470).HasColumnName(@"CRIK470").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik471).HasColumnName(@"CRIK471").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik472).HasColumnName(@"CRIK472").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik473).HasColumnName(@"CRIK473").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik474).HasColumnName(@"CRIK474").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik475).HasColumnName(@"CRIK475").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik476).HasColumnName(@"CRIK476").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik477).HasColumnName(@"CRIK477").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik621).HasColumnName(@"CRIK621").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik740).HasColumnName(@"CRIK740").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik631).HasColumnName(@"CRIK631").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik777).HasColumnName(@"CRIK777").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik780).HasColumnName(@"CRIK780").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik781).HasColumnName(@"CRIK781").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik782).HasColumnName(@"CRIK782").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik910).HasColumnName(@"CRIK910").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik970).HasColumnName(@"CRIK970").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik971).HasColumnName(@"CRIK971").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik972).HasColumnName(@"CRIK972").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik973).HasColumnName(@"CRIK973").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik974).HasColumnName(@"CRIK974").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik975).HasColumnName(@"CRIK975").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik976).HasColumnName(@"CRIK976").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik977).HasColumnName(@"CRIK977").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik020).HasColumnName(@"CRIK020").HasColumnType("int").IsRequired();
            Property(x => x.Crik030).HasColumnName(@"CRIK030").HasColumnType("datetime").IsRequired();
            Property(x => x.Crik122).HasColumnName(@"CRIK122").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik622).HasColumnName(@"CRIK622").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik478).HasColumnName(@"CRIK478").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik978).HasColumnName(@"CRIK978").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik483).HasColumnName(@"CRIK483").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik983).HasColumnName(@"CRIK983").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik485).HasColumnName(@"CRIK485").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik486).HasColumnName(@"CRIK486").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik487).HasColumnName(@"CRIK487").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik488).HasColumnName(@"CRIK488").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik489).HasColumnName(@"CRIK489").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik985).HasColumnName(@"CRIK985").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik986).HasColumnName(@"CRIK986").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik987).HasColumnName(@"CRIK987").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik988).HasColumnName(@"CRIK988").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik989).HasColumnName(@"CRIK989").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik312).HasColumnName(@"CRIK312").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik812).HasColumnName(@"CRIK812").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik340).HasColumnName(@"CRIK340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik840).HasColumnName(@"CRIK840").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik490).HasColumnName(@"CRIK490").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik990).HasColumnName(@"CRIK990").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik491).HasColumnName(@"CRIK491").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik991).HasColumnName(@"CRIK991").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Crik492).HasColumnName(@"CRIK492").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik992).HasColumnName(@"CRIK992").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(130);
            Property(x => x.Crik290).HasColumnName(@"CRIK290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Crik790).HasColumnName(@"CRIK790").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
        }
    }

}
