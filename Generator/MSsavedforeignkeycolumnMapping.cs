

namespace Generator
{

    public class MSsavedforeignkeycolumnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MSsavedforeignkeycolumn>
    {
        public MSsavedforeignkeycolumnMapping()
            : this("dbo")
        {
        }

        public MSsavedforeignkeycolumnMapping(string schema)
        {
            ToTable("MSsavedforeignkeycolumns", schema);
            HasKey(x => new { x.ProgramName, x.ConstraintName, x.ParentSchema, x.ConstraintColumnId, x.ReferencingColumnName, x.ReferencedColumnName, x.Timestamp });

            Property(x => x.ProgramName).HasColumnName(@"program_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ConstraintName).HasColumnName(@"constraint_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentSchema).HasColumnName(@"parent_schema").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ConstraintColumnId).HasColumnName(@"constraint_column_id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ReferencingColumnName).HasColumnName(@"referencing_column_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ReferencedColumnName).HasColumnName(@"referenced_column_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Timestamp).HasColumnName(@"timestamp").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
