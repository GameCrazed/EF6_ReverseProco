

namespace Generator
{

    using System.Linq;

    public class PureDataContext : System.Data.Entity.DbContext, IPureDataContext
    {
        public System.Data.Entity.DbSet<Agent> Agents { get; set; }
        public System.Data.Entity.DbSet<AgentClubMembership> AgentClubMemberships { get; set; }
        public System.Data.Entity.DbSet<AllDataWorking> AllDataWorkings { get; set; }
        public System.Data.Entity.DbSet<BenchmarkPenalty> BenchmarkPenalties { get; set; }
        public System.Data.Entity.DbSet<BrokerBdmDataDeprecated> BrokerBdmDataDeprecateds { get; set; }
        public System.Data.Entity.DbSet<BrokerClub> BrokerClubs { get; set; }
        public System.Data.Entity.DbSet<BrokerDataAdditional> BrokerDataAdditionals { get; set; }
        public System.Data.Entity.DbSet<BrokerDataLive> BrokerDataLives { get; set; }
        public System.Data.Entity.DbSet<BrokerDataView> BrokerDataViews { get; set; }
        public System.Data.Entity.DbSet<BrokerFirm> BrokerFirms { get; set; }
        public System.Data.Entity.DbSet<BrokerManager> BrokerManagers { get; set; }
        public System.Data.Entity.DbSet<BrokerNetworkData> BrokerNetworkDatas { get; set; }
        public System.Data.Entity.DbSet<BusRegDataLive> BusRegDataLives { get; set; }
        public System.Data.Entity.DbSet<BusregView> BusregViews { get; set; }
        public System.Data.Entity.DbSet<CaseFilter> CaseFilters { get; set; }
        public System.Data.Entity.DbSet<CaseFilterTaskConfiguration> CaseFilterTaskConfigurations { get; set; }
        public System.Data.Entity.DbSet<CaseState> CaseStates { get; set; }
        public System.Data.Entity.DbSet<CaseStateHistory> CaseStateHistories { get; set; }
        public System.Data.Entity.DbSet<CompletionsWallboard> CompletionsWallboards { get; set; }
        public System.Data.Entity.DbSet<Document> Documents { get; set; }
        public System.Data.Entity.DbSet<FriendlyName> FriendlyNames { get; set; }
        public System.Data.Entity.DbSet<Gush> Gushes { get; set; }
        public System.Data.Entity.DbSet<GushResult> GushResults { get; set; }
        public System.Data.Entity.DbSet<GushThreshold> GushThresholds { get; set; }
        public System.Data.Entity.DbSet<KfiData> KfiDatas { get; set; }
        public System.Data.Entity.DbSet<KfiDataLive> KfiDataLives { get; set; }
        public System.Data.Entity.DbSet<KfiDataView> KfiDataViews { get; set; }
        public System.Data.Entity.DbSet<MostRecentCaseStateHistory> MostRecentCaseStateHistories { get; set; }
        public System.Data.Entity.DbSet<Pack> Packs { get; set; }
        public System.Data.Entity.DbSet<PackVersion> PackVersions { get; set; }
        public System.Data.Entity.DbSet<PackVersionDocument> PackVersionDocuments { get; set; }
        public System.Data.Entity.DbSet<PackVersionSignOff> PackVersionSignOffs { get; set; }
        public System.Data.Entity.DbSet<PackVoid> PackVoids { get; set; }
        public System.Data.Entity.DbSet<PaymentContactDetail> PaymentContactDetails { get; set; }
        public System.Data.Entity.DbSet<PortalAuthenticationToken> PortalAuthenticationTokens { get; set; }
        public System.Data.Entity.DbSet<PortalDomain> PortalDomains { get; set; }
        public System.Data.Entity.DbSet<PortalDomainRole> PortalDomainRoles { get; set; }
        public System.Data.Entity.DbSet<PortalRole> PortalRoles { get; set; }
        public System.Data.Entity.DbSet<PostcodeData> PostcodeDatas { get; set; }
        public System.Data.Entity.DbSet<ProductNameMapDeprecated> ProductNameMapDeprecateds { get; set; }
        public System.Data.Entity.DbSet<ProductNameMapping> ProductNameMappings { get; set; }
        public System.Data.Entity.DbSet<PureCommsReport> PureCommsReports { get; set; }
        public System.Data.Entity.DbSet<PureWallboardData> PureWallboardDatas { get; set; }
        public System.Data.Entity.DbSet<ReferenceData> ReferenceDatas { get; set; }
        public System.Data.Entity.DbSet<Reportoffercommissionindividual> Reportoffercommissionindividuals { get; set; }
        public System.Data.Entity.DbSet<SgBrokerComm> SgBrokerComms { get; set; }
        public System.Data.Entity.DbSet<SgBrokerRecord> SgBrokerRecords { get; set; }
        public System.Data.Entity.DbSet<SignOff> SignOffs { get; set; }
        public System.Data.Entity.DbSet<Task> Tasks { get; set; }
        public System.Data.Entity.DbSet<TaskConfigGroup> TaskConfigGroups { get; set; }
        public System.Data.Entity.DbSet<TaskConfigSource> TaskConfigSources { get; set; }
        public System.Data.Entity.DbSet<TaskConfiguration> TaskConfigurations { get; set; }
        public System.Data.Entity.DbSet<TaskConfigurationsArchived> TaskConfigurationsArchiveds { get; set; }
        public System.Data.Entity.DbSet<TaskResult> TaskResults { get; set; }
        public System.Data.Entity.DbSet<UserActivity> UserActivities { get; set; }
        public System.Data.Entity.DbSet<UserActivityUserRoleMapping> UserActivityUserRoleMappings { get; set; }
        public System.Data.Entity.DbSet<UserRole> UserRoles { get; set; }
        public System.Data.Entity.DbSet<UserRoleGroupPrincipalMapping> UserRoleGroupPrincipalMappings { get; set; }

        static PureDataContext()
        {
            System.Data.Entity.Database.SetInitializer<PureDataContext>(null);
        }

        public PureDataContext()
            : base("Name=MyDbContext")
        {
        }

        public PureDataContext(string connectionString)
            : base(connectionString)
        {
        }

        public PureDataContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public PureDataContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public PureDataContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AgentMapping());
            modelBuilder.Configurations.Add(new AgentClubMembershipMapping());
            modelBuilder.Configurations.Add(new AllDataWorkingMapping());
            modelBuilder.Configurations.Add(new BenchmarkPenaltyMapping());
            modelBuilder.Configurations.Add(new BrokerBdmDataDeprecatedMapping());
            modelBuilder.Configurations.Add(new BrokerClubMapping());
            modelBuilder.Configurations.Add(new BrokerDataAdditionalMapping());
            modelBuilder.Configurations.Add(new BrokerDataLiveMapping());
            modelBuilder.Configurations.Add(new BrokerDataViewMapping());
            modelBuilder.Configurations.Add(new BrokerFirmMapping());
            modelBuilder.Configurations.Add(new BrokerManagerMapping());
            modelBuilder.Configurations.Add(new BrokerNetworkDataMapping());
            modelBuilder.Configurations.Add(new BusRegDataLiveMapping());
            modelBuilder.Configurations.Add(new BusregViewMapping());
            modelBuilder.Configurations.Add(new CaseFilterMapping());
            modelBuilder.Configurations.Add(new CaseFilterTaskConfigurationMapping());
            modelBuilder.Configurations.Add(new CaseStateMapping());
            modelBuilder.Configurations.Add(new CaseStateHistoryMapping());
            modelBuilder.Configurations.Add(new CompletionsWallboardMapping());
            modelBuilder.Configurations.Add(new DocumentMapping());
            modelBuilder.Configurations.Add(new FriendlyNameMapping());
            modelBuilder.Configurations.Add(new GushMapping());
            modelBuilder.Configurations.Add(new GushResultMapping());
            modelBuilder.Configurations.Add(new GushThresholdMapping());
            modelBuilder.Configurations.Add(new KfiDataMapping());
            modelBuilder.Configurations.Add(new KfiDataLiveMapping());
            modelBuilder.Configurations.Add(new KfiDataViewMapping());
            modelBuilder.Configurations.Add(new MostRecentCaseStateHistoryMapping());
            modelBuilder.Configurations.Add(new PackMapping());
            modelBuilder.Configurations.Add(new PackVersionMapping());
            modelBuilder.Configurations.Add(new PackVersionDocumentMapping());
            modelBuilder.Configurations.Add(new PackVersionSignOffMapping());
            modelBuilder.Configurations.Add(new PackVoidMapping());
            modelBuilder.Configurations.Add(new PaymentContactDetailMapping());
            modelBuilder.Configurations.Add(new PortalAuthenticationTokenMapping());
            modelBuilder.Configurations.Add(new PortalDomainMapping());
            modelBuilder.Configurations.Add(new PortalDomainRoleMapping());
            modelBuilder.Configurations.Add(new PortalRoleMapping());
            modelBuilder.Configurations.Add(new PostcodeDataMapping());
            modelBuilder.Configurations.Add(new ProductNameMapDeprecatedMapping());
            modelBuilder.Configurations.Add(new ProductNameMappingMapping());
            modelBuilder.Configurations.Add(new PureCommsReportMapping());
            modelBuilder.Configurations.Add(new PureWallboardDataMapping());
            modelBuilder.Configurations.Add(new ReferenceDataMapping());
            modelBuilder.Configurations.Add(new ReportoffercommissionindividualMapping());
            modelBuilder.Configurations.Add(new SgBrokerCommMapping());
            modelBuilder.Configurations.Add(new SgBrokerRecordMapping());
            modelBuilder.Configurations.Add(new SignOffMapping());
            modelBuilder.Configurations.Add(new TaskMapping());
            modelBuilder.Configurations.Add(new TaskConfigGroupMapping());
            modelBuilder.Configurations.Add(new TaskConfigSourceMapping());
            modelBuilder.Configurations.Add(new TaskConfigurationMapping());
            modelBuilder.Configurations.Add(new TaskConfigurationsArchivedMapping());
            modelBuilder.Configurations.Add(new TaskResultMapping());
            modelBuilder.Configurations.Add(new UserActivityMapping());
            modelBuilder.Configurations.Add(new UserActivityUserRoleMappingMapping());
            modelBuilder.Configurations.Add(new UserRoleMapping());
            modelBuilder.Configurations.Add(new UserRoleGroupPrincipalMappingMapping());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AgentMapping(schema));
            modelBuilder.Configurations.Add(new AgentClubMembershipMapping(schema));
            modelBuilder.Configurations.Add(new AllDataWorkingMapping(schema));
            modelBuilder.Configurations.Add(new BenchmarkPenaltyMapping(schema));
            modelBuilder.Configurations.Add(new BrokerBdmDataDeprecatedMapping(schema));
            modelBuilder.Configurations.Add(new BrokerClubMapping(schema));
            modelBuilder.Configurations.Add(new BrokerDataAdditionalMapping(schema));
            modelBuilder.Configurations.Add(new BrokerDataLiveMapping(schema));
            modelBuilder.Configurations.Add(new BrokerDataViewMapping(schema));
            modelBuilder.Configurations.Add(new BrokerFirmMapping(schema));
            modelBuilder.Configurations.Add(new BrokerManagerMapping(schema));
            modelBuilder.Configurations.Add(new BrokerNetworkDataMapping(schema));
            modelBuilder.Configurations.Add(new BusRegDataLiveMapping(schema));
            modelBuilder.Configurations.Add(new BusregViewMapping(schema));
            modelBuilder.Configurations.Add(new CaseFilterMapping(schema));
            modelBuilder.Configurations.Add(new CaseFilterTaskConfigurationMapping(schema));
            modelBuilder.Configurations.Add(new CaseStateMapping(schema));
            modelBuilder.Configurations.Add(new CaseStateHistoryMapping(schema));
            modelBuilder.Configurations.Add(new CompletionsWallboardMapping(schema));
            modelBuilder.Configurations.Add(new DocumentMapping(schema));
            modelBuilder.Configurations.Add(new FriendlyNameMapping(schema));
            modelBuilder.Configurations.Add(new GushMapping(schema));
            modelBuilder.Configurations.Add(new GushResultMapping(schema));
            modelBuilder.Configurations.Add(new GushThresholdMapping(schema));
            modelBuilder.Configurations.Add(new KfiDataMapping(schema));
            modelBuilder.Configurations.Add(new KfiDataLiveMapping(schema));
            modelBuilder.Configurations.Add(new KfiDataViewMapping(schema));
            modelBuilder.Configurations.Add(new MostRecentCaseStateHistoryMapping(schema));
            modelBuilder.Configurations.Add(new PackMapping(schema));
            modelBuilder.Configurations.Add(new PackVersionMapping(schema));
            modelBuilder.Configurations.Add(new PackVersionDocumentMapping(schema));
            modelBuilder.Configurations.Add(new PackVersionSignOffMapping(schema));
            modelBuilder.Configurations.Add(new PackVoidMapping(schema));
            modelBuilder.Configurations.Add(new PaymentContactDetailMapping(schema));
            modelBuilder.Configurations.Add(new PortalAuthenticationTokenMapping(schema));
            modelBuilder.Configurations.Add(new PortalDomainMapping(schema));
            modelBuilder.Configurations.Add(new PortalDomainRoleMapping(schema));
            modelBuilder.Configurations.Add(new PortalRoleMapping(schema));
            modelBuilder.Configurations.Add(new PostcodeDataMapping(schema));
            modelBuilder.Configurations.Add(new ProductNameMapDeprecatedMapping(schema));
            modelBuilder.Configurations.Add(new ProductNameMappingMapping(schema));
            modelBuilder.Configurations.Add(new PureCommsReportMapping(schema));
            modelBuilder.Configurations.Add(new PureWallboardDataMapping(schema));
            modelBuilder.Configurations.Add(new ReferenceDataMapping(schema));
            modelBuilder.Configurations.Add(new ReportoffercommissionindividualMapping(schema));
            modelBuilder.Configurations.Add(new SgBrokerCommMapping(schema));
            modelBuilder.Configurations.Add(new SgBrokerRecordMapping(schema));
            modelBuilder.Configurations.Add(new SignOffMapping(schema));
            modelBuilder.Configurations.Add(new TaskMapping(schema));
            modelBuilder.Configurations.Add(new TaskConfigGroupMapping(schema));
            modelBuilder.Configurations.Add(new TaskConfigSourceMapping(schema));
            modelBuilder.Configurations.Add(new TaskConfigurationMapping(schema));
            modelBuilder.Configurations.Add(new TaskConfigurationsArchivedMapping(schema));
            modelBuilder.Configurations.Add(new TaskResultMapping(schema));
            modelBuilder.Configurations.Add(new UserActivityMapping(schema));
            modelBuilder.Configurations.Add(new UserActivityUserRoleMappingMapping(schema));
            modelBuilder.Configurations.Add(new UserRoleMapping(schema));
            modelBuilder.Configurations.Add(new UserRoleGroupPrincipalMappingMapping(schema));
            return modelBuilder;
        }

        // Stored Procedures
        public System.Collections.Generic.List<UpdateProductCodesReturnModel> UpdateProductCodes()
        {
            int procResult;
            return UpdateProductCodes(out procResult);
        }

        public System.Collections.Generic.List<UpdateProductCodesReturnModel> UpdateProductCodes(out int procResult)
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpdateProductCodesReturnModel>("EXEC @procResult = [dbo].[updateProductCodes] ", procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<UpdateProductCodesReturnModel>> UpdateProductCodesAsync()
        {
            var procResultData = await Database.SqlQuery<UpdateProductCodesReturnModel>("EXEC [dbo].[updateProductCodes] ").ToListAsync();

            return procResultData;
        }

    }
}
