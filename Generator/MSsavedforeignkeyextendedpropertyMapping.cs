

namespace Generator
{

    public class MSsavedforeignkeyextendedpropertyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MSsavedforeignkeyextendedproperty>
    {
        public MSsavedforeignkeyextendedpropertyMapping()
            : this("dbo")
        {
        }

        public MSsavedforeignkeyextendedpropertyMapping(string schema)
        {
            ToTable("MSsavedforeignkeyextendedproperties", schema);
            HasKey(x => new { x.ProgramName, x.ConstraintName, x.ParentSchema, x.PropertyName, x.Timestamp });

            Property(x => x.ProgramName).HasColumnName(@"program_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ConstraintName).HasColumnName(@"constraint_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentSchema).HasColumnName(@"parent_schema").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PropertyName).HasColumnName(@"property_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PropertyValue).HasColumnName(@"property_value").HasColumnType("sql_variant").IsOptional();
            Property(x => x.Timestamp).HasColumnName(@"timestamp").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
