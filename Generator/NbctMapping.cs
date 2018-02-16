

namespace Generator
{

    public class NbctMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbct>
    {
        public NbctMapping()
            : this("dbo")
        {
        }

        public NbctMapping(string schema)
        {
            ToTable("NBCT", schema);
            HasKey(x => x.Nbct001);

            Property(x => x.Nbct001).HasColumnName(@"NBCT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbct005).HasColumnName(@"NBCT005").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct007).HasColumnName(@"NBCT007").HasColumnType("int").IsRequired();
            Property(x => x.Nbct010).HasColumnName(@"NBCT010").HasColumnType("int").IsRequired();
            Property(x => x.Nbct020).HasColumnName(@"NBCT020").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbct030).HasColumnName(@"NBCT030").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbct040).HasColumnName(@"NBCT040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Nbct075).HasColumnName(@"NBCT075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Nbct100).HasColumnName(@"NBCT100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbct150).HasColumnName(@"NBCT150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbct200).HasColumnName(@"NBCT200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbct210).HasColumnName(@"NBCT210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbct220).HasColumnName(@"NBCT220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbct275).HasColumnName(@"NBCT275").HasColumnType("int").IsRequired();
            Property(x => x.Nbct276).HasColumnName(@"NBCT276").HasColumnType("int").IsRequired();
            Property(x => x.Nbct300).HasColumnName(@"NBCT300").HasColumnType("int").IsRequired();
            Property(x => x.Nbct301).HasColumnName(@"NBCT301").HasColumnType("int").IsRequired();
            Property(x => x.Nbct350).HasColumnName(@"NBCT350").HasColumnType("int").IsRequired();
            Property(x => x.Nbct375).HasColumnName(@"NBCT375").HasColumnType("int").IsRequired();
            Property(x => x.Nbct380).HasColumnName(@"NBCT380").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbct500).HasColumnName(@"NBCT500").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct501).HasColumnName(@"NBCT501").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct502).HasColumnName(@"NBCT502").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct503).HasColumnName(@"NBCT503").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct504).HasColumnName(@"NBCT504").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct505).HasColumnName(@"NBCT505").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct506).HasColumnName(@"NBCT506").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct507).HasColumnName(@"NBCT507").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct508).HasColumnName(@"NBCT508").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct509).HasColumnName(@"NBCT509").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct510).HasColumnName(@"NBCT510").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct511).HasColumnName(@"NBCT511").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct512).HasColumnName(@"NBCT512").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct513).HasColumnName(@"NBCT513").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct514).HasColumnName(@"NBCT514").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct515).HasColumnName(@"NBCT515").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct516).HasColumnName(@"NBCT516").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct517).HasColumnName(@"NBCT517").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct518).HasColumnName(@"NBCT518").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct519).HasColumnName(@"NBCT519").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct600).HasColumnName(@"NBCT600").HasColumnType("int").IsRequired();
            Property(x => x.Nbct601).HasColumnName(@"NBCT601").HasColumnType("int").IsRequired();
            Property(x => x.Nbct602).HasColumnName(@"NBCT602").HasColumnType("int").IsRequired();
            Property(x => x.Nbct603).HasColumnName(@"NBCT603").HasColumnType("int").IsRequired();
            Property(x => x.Nbct604).HasColumnName(@"NBCT604").HasColumnType("int").IsRequired();
            Property(x => x.Nbct605).HasColumnName(@"NBCT605").HasColumnType("int").IsRequired();
            Property(x => x.Nbct606).HasColumnName(@"NBCT606").HasColumnType("int").IsRequired();
            Property(x => x.Nbct607).HasColumnName(@"NBCT607").HasColumnType("int").IsRequired();
            Property(x => x.Nbct608).HasColumnName(@"NBCT608").HasColumnType("int").IsRequired();
            Property(x => x.Nbct609).HasColumnName(@"NBCT609").HasColumnType("int").IsRequired();
            Property(x => x.Nbct610).HasColumnName(@"NBCT610").HasColumnType("int").IsRequired();
            Property(x => x.Nbct611).HasColumnName(@"NBCT611").HasColumnType("int").IsRequired();
            Property(x => x.Nbct612).HasColumnName(@"NBCT612").HasColumnType("int").IsRequired();
            Property(x => x.Nbct613).HasColumnName(@"NBCT613").HasColumnType("int").IsRequired();
            Property(x => x.Nbct614).HasColumnName(@"NBCT614").HasColumnType("int").IsRequired();
            Property(x => x.Nbct615).HasColumnName(@"NBCT615").HasColumnType("int").IsRequired();
            Property(x => x.Nbct616).HasColumnName(@"NBCT616").HasColumnType("int").IsRequired();
            Property(x => x.Nbct617).HasColumnName(@"NBCT617").HasColumnType("int").IsRequired();
            Property(x => x.Nbct618).HasColumnName(@"NBCT618").HasColumnType("int").IsRequired();
            Property(x => x.Nbct620).HasColumnName(@"NBCT620").HasColumnType("int").IsRequired();
            Property(x => x.Nbct621).HasColumnName(@"NBCT621").HasColumnType("int").IsRequired();
            Property(x => x.Nbct700).HasColumnName(@"NBCT700").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct701).HasColumnName(@"NBCT701").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct702).HasColumnName(@"NBCT702").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct703).HasColumnName(@"NBCT703").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct704).HasColumnName(@"NBCT704").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct705).HasColumnName(@"NBCT705").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct706).HasColumnName(@"NBCT706").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct707).HasColumnName(@"NBCT707").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct708).HasColumnName(@"NBCT708").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct709).HasColumnName(@"NBCT709").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct710).HasColumnName(@"NBCT710").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct711).HasColumnName(@"NBCT711").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct712).HasColumnName(@"NBCT712").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct713).HasColumnName(@"NBCT713").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct714).HasColumnName(@"NBCT714").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct715).HasColumnName(@"NBCT715").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct716).HasColumnName(@"NBCT716").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct717).HasColumnName(@"NBCT717").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct718).HasColumnName(@"NBCT718").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct800).HasColumnName(@"NBCT800").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct900).HasColumnName(@"NBCT900").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nbct901).HasColumnName(@"NBCT901").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nbct390).HasColumnName(@"NBCT390").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct520).HasColumnName(@"NBCT520").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct521).HasColumnName(@"NBCT521").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct522).HasColumnName(@"NBCT522").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct523).HasColumnName(@"NBCT523").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct524).HasColumnName(@"NBCT524").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct525).HasColumnName(@"NBCT525").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct526).HasColumnName(@"NBCT526").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct527).HasColumnName(@"NBCT527").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct528).HasColumnName(@"NBCT528").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct619).HasColumnName(@"NBCT619").HasColumnType("int").IsRequired();
            Property(x => x.Nbct622).HasColumnName(@"NBCT622").HasColumnType("int").IsRequired();
            Property(x => x.Nbct623).HasColumnName(@"NBCT623").HasColumnType("int").IsRequired();
            Property(x => x.Nbct624).HasColumnName(@"NBCT624").HasColumnType("int").IsRequired();
            Property(x => x.Nbct625).HasColumnName(@"NBCT625").HasColumnType("int").IsRequired();
            Property(x => x.Nbct626).HasColumnName(@"NBCT626").HasColumnType("int").IsRequired();
            Property(x => x.Nbct627).HasColumnName(@"NBCT627").HasColumnType("int").IsRequired();
            Property(x => x.Nbct628).HasColumnName(@"NBCT628").HasColumnType("int").IsRequired();
            Property(x => x.Nbct530).HasColumnName(@"NBCT530").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct630).HasColumnName(@"NBCT630").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbct003).HasColumnName(@"NBCT003").HasColumnType("tinyint").IsRequired();
        }
    }

}
