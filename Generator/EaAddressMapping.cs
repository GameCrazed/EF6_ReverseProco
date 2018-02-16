

namespace Generator
{

    public class EaAddressMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaAddress>
    {
        public EaAddressMapping()
            : this("dbo")
        {
        }

        public EaAddressMapping(string schema)
        {
            ToTable("ea_address", schema);
            HasKey(x => x.AddressId);

            Property(x => x.AddressId).HasColumnName(@"AddressID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Organisation).HasColumnName(@"Organisation").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FlatNo).HasColumnName(@"FlatNo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.BuildingNo).HasColumnName(@"BuildingNo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.HouseNumber).HasColumnName(@"HouseNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Street).HasColumnName(@"Street").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Locality).HasColumnName(@"Locality").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Town).HasColumnName(@"Town").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.County).HasColumnName(@"County").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PostCode).HasColumnName(@"PostCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FromDate).HasColumnName(@"FromDate").HasColumnType("datetime").IsOptional();
        }
    }

}
