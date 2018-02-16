

namespace Generator
{

    public class RedpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Redp>
    {
        public RedpMapping()
            : this("dbo")
        {
        }

        public RedpMapping(string schema)
        {
            ToTable("REDP", schema);
            HasKey(x => x.Redp001);

            Property(x => x.Redp001).HasColumnName(@"REDP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Redp020).HasColumnName(@"REDP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Redp030).HasColumnName(@"REDP030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Redp040).HasColumnName(@"REDP040").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp050).HasColumnName(@"REDP050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Redp060).HasColumnName(@"REDP060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp600).HasColumnName(@"REDP600").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp6051).HasColumnName(@"REDP6051").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6052).HasColumnName(@"REDP6052").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6053).HasColumnName(@"REDP6053").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6054).HasColumnName(@"REDP6054").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6055).HasColumnName(@"REDP6055").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6056).HasColumnName(@"REDP6056").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6057).HasColumnName(@"REDP6057").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6058).HasColumnName(@"REDP6058").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6059).HasColumnName(@"REDP6059").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp60510).HasColumnName(@"REDP60510").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp6101).HasColumnName(@"REDP6101").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6102).HasColumnName(@"REDP6102").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6103).HasColumnName(@"REDP6103").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6104).HasColumnName(@"REDP6104").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6105).HasColumnName(@"REDP6105").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6106).HasColumnName(@"REDP6106").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6107).HasColumnName(@"REDP6107").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6108).HasColumnName(@"REDP6108").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6109).HasColumnName(@"REDP6109").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp61010).HasColumnName(@"REDP61010").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6121).HasColumnName(@"REDP6121").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6122).HasColumnName(@"REDP6122").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6123).HasColumnName(@"REDP6123").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6124).HasColumnName(@"REDP6124").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6125).HasColumnName(@"REDP6125").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6151).HasColumnName(@"REDP6151").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6152).HasColumnName(@"REDP6152").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6153).HasColumnName(@"REDP6153").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6154).HasColumnName(@"REDP6154").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6155).HasColumnName(@"REDP6155").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6156).HasColumnName(@"REDP6156").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6157).HasColumnName(@"REDP6157").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6158).HasColumnName(@"REDP6158").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6159).HasColumnName(@"REDP6159").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp61510).HasColumnName(@"REDP61510").HasColumnType("datetime").IsRequired();
            Property(x => x.Redp6161).HasColumnName(@"REDP6161").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6162).HasColumnName(@"REDP6162").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6163).HasColumnName(@"REDP6163").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6164).HasColumnName(@"REDP6164").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp6165).HasColumnName(@"REDP6165").HasColumnType("smallint").IsRequired();
            Property(x => x.Redp617).HasColumnName(@"REDP617").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Redp618).HasColumnName(@"REDP618").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp620).HasColumnName(@"REDP620").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redp625).HasColumnName(@"REDP625").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp630).HasColumnName(@"REDP630").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp635).HasColumnName(@"REDP635").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp640).HasColumnName(@"REDP640").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp645).HasColumnName(@"REDP645").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp650).HasColumnName(@"REDP650").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp655).HasColumnName(@"REDP655").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp660).HasColumnName(@"REDP660").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp990).HasColumnName(@"REDP990").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Redp989).HasColumnName(@"REDP989").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp651).HasColumnName(@"REDP651").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp665).HasColumnName(@"REDP665").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redp670).HasColumnName(@"REDP670").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redp675).HasColumnName(@"REDP675").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp690).HasColumnName(@"REDP690").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp695).HasColumnName(@"REDP695").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp700).HasColumnName(@"REDP700").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp992).HasColumnName(@"REDP992").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp680).HasColumnName(@"REDP680").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp619).HasColumnName(@"REDP619").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp621).HasColumnName(@"REDP621").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redp622).HasColumnName(@"REDP622").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp623).HasColumnName(@"REDP623").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp626).HasColumnName(@"REDP626").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp627).HasColumnName(@"REDP627").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp800).HasColumnName(@"REDP800").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp810).HasColumnName(@"REDP810").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp692).HasColumnName(@"REDP692").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp694).HasColumnName(@"REDP694").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp750).HasColumnName(@"REDP750").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp820).HasColumnName(@"REDP820").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp760).HasColumnName(@"REDP760").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Redp763).HasColumnName(@"REDP763").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp764).HasColumnName(@"REDP764").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp765).HasColumnName(@"REDP765").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp766).HasColumnName(@"REDP766").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Redp7671).HasColumnName(@"REDP7671").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Redp7672).HasColumnName(@"REDP7672").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Redp7673).HasColumnName(@"REDP7673").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Redp7674).HasColumnName(@"REDP7674").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Redp901).HasColumnName(@"REDP901").HasColumnType("tinyint").IsRequired();
            Property(x => x.Redp902).HasColumnName(@"REDP902").HasColumnType("tinyint").IsRequired();
        }
    }

}
