

namespace Generator
{

    public interface IPureDataContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Agent> Agents { get; set; }
        System.Data.Entity.DbSet<AgentClubMembership> AgentClubMemberships { get; set; }
        System.Data.Entity.DbSet<AllDataWorking> AllDataWorkings { get; set; }
        System.Data.Entity.DbSet<BenchmarkPenalty> BenchmarkPenalties { get; set; }
        System.Data.Entity.DbSet<BrokerBdmDataDeprecated> BrokerBdmDataDeprecateds { get; set; }
        System.Data.Entity.DbSet<BrokerClub> BrokerClubs { get; set; }
        System.Data.Entity.DbSet<BrokerDataAdditional> BrokerDataAdditionals { get; set; }
        System.Data.Entity.DbSet<BrokerDataLive> BrokerDataLives { get; set; }
        System.Data.Entity.DbSet<BrokerDataView> BrokerDataViews { get; set; }
        System.Data.Entity.DbSet<BrokerFirm> BrokerFirms { get; set; }
        System.Data.Entity.DbSet<BrokerManager> BrokerManagers { get; set; }
        System.Data.Entity.DbSet<BrokerNetworkData> BrokerNetworkDatas { get; set; }
        System.Data.Entity.DbSet<BusRegDataLive> BusRegDataLives { get; set; }
        System.Data.Entity.DbSet<BusregView> BusregViews { get; set; }
        System.Data.Entity.DbSet<CaseFilter> CaseFilters { get; set; }
        System.Data.Entity.DbSet<CaseFilterTaskConfiguration> CaseFilterTaskConfigurations { get; set; }
        System.Data.Entity.DbSet<CaseState> CaseStates { get; set; }
        System.Data.Entity.DbSet<CaseStateHistory> CaseStateHistories { get; set; }
        System.Data.Entity.DbSet<CompletionsWallboard> CompletionsWallboards { get; set; }
        System.Data.Entity.DbSet<Document> Documents { get; set; }
        System.Data.Entity.DbSet<FriendlyName> FriendlyNames { get; set; }
        System.Data.Entity.DbSet<Gush> Gushes { get; set; }
        System.Data.Entity.DbSet<GushResult> GushResults { get; set; }
        System.Data.Entity.DbSet<GushThreshold> GushThresholds { get; set; }
        System.Data.Entity.DbSet<KfiData> KfiDatas { get; set; }
        System.Data.Entity.DbSet<KfiDataLive> KfiDataLives { get; set; }
        System.Data.Entity.DbSet<KfiDataView> KfiDataViews { get; set; }
        System.Data.Entity.DbSet<MostRecentCaseStateHistory> MostRecentCaseStateHistories { get; set; }
        System.Data.Entity.DbSet<Pack> Packs { get; set; }
        System.Data.Entity.DbSet<PackVersion> PackVersions { get; set; }
        System.Data.Entity.DbSet<PackVersionDocument> PackVersionDocuments { get; set; }
        System.Data.Entity.DbSet<PackVersionSignOff> PackVersionSignOffs { get; set; }
        System.Data.Entity.DbSet<PackVoid> PackVoids { get; set; }
        System.Data.Entity.DbSet<PaymentContactDetail> PaymentContactDetails { get; set; }
        System.Data.Entity.DbSet<PortalAuthenticationToken> PortalAuthenticationTokens { get; set; }
        System.Data.Entity.DbSet<PortalDomain> PortalDomains { get; set; }
        System.Data.Entity.DbSet<PortalDomainRole> PortalDomainRoles { get; set; }
        System.Data.Entity.DbSet<PortalRole> PortalRoles { get; set; }
        System.Data.Entity.DbSet<PostcodeData> PostcodeDatas { get; set; }
        System.Data.Entity.DbSet<ProductNameMapDeprecated> ProductNameMapDeprecateds { get; set; }
        System.Data.Entity.DbSet<ProductNameMapping> ProductNameMappings { get; set; }
        System.Data.Entity.DbSet<PureCommsReport> PureCommsReports { get; set; }
        System.Data.Entity.DbSet<PureWallboardData> PureWallboardDatas { get; set; }
        System.Data.Entity.DbSet<ReferenceData> ReferenceDatas { get; set; }
        System.Data.Entity.DbSet<Reportoffercommissionindividual> Reportoffercommissionindividuals { get; set; }
        System.Data.Entity.DbSet<SgBrokerComm> SgBrokerComms { get; set; }
        System.Data.Entity.DbSet<SgBrokerRecord> SgBrokerRecords { get; set; }
        System.Data.Entity.DbSet<SignOff> SignOffs { get; set; }
        System.Data.Entity.DbSet<Task> Tasks { get; set; }
        System.Data.Entity.DbSet<TaskConfigGroup> TaskConfigGroups { get; set; }
        System.Data.Entity.DbSet<TaskConfigSource> TaskConfigSources { get; set; }
        System.Data.Entity.DbSet<TaskConfiguration> TaskConfigurations { get; set; }
        System.Data.Entity.DbSet<TaskConfigurationsArchived> TaskConfigurationsArchiveds { get; set; }
        System.Data.Entity.DbSet<TaskResult> TaskResults { get; set; }
        System.Data.Entity.DbSet<UserActivity> UserActivities { get; set; }
        System.Data.Entity.DbSet<UserActivityUserRoleMapping> UserActivityUserRoleMappings { get; set; }
        System.Data.Entity.DbSet<UserRole> UserRoles { get; set; }
        System.Data.Entity.DbSet<UserRoleGroupPrincipalMapping> UserRoleGroupPrincipalMappings { get; set; }

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<UpdateProductCodesReturnModel> UpdateProductCodes();
        System.Collections.Generic.List<UpdateProductCodesReturnModel> UpdateProductCodes(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UpdateProductCodesReturnModel>> UpdateProductCodesAsync();

    }

}
