

namespace Generator
{

    using System.Linq;

    public class FakePureDataContext : IPureDataContext
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

        public FakePureDataContext()
        {
            Agents = new FakeDbSet<Agent>("PhoebusContactId");
            AgentClubMemberships = new FakeDbSet<AgentClubMembership>("PhoebusContactId", "BrokerClubId");
            AllDataWorkings = new FakeDbSet<AllDataWorking>("Product", "PaReferenceNumber", "NewPaReference", "PegPercentage", "OnAppRegister", "RealCount", "LatestVersion", "Status", "Blank", "Withdrawn", "Declined", "Complete", "CompletionDateSet", "Offer", "ApplicationReceived", "Kfi6030Days", "Kfi6230Days", "DateChangeToday", "LastAction622MonthsAgo", "FriendlyName", "BdmName", "IsFieldBased", "PackagerMortgageId");
            BenchmarkPenalties = new FakeDbSet<BenchmarkPenalty>("Id");
            BrokerBdmDataDeprecateds = new FakeDbSet<BrokerBdmDataDeprecated>("BdmId");
            BrokerClubs = new FakeDbSet<BrokerClub>("BrokerClubId");
            BrokerDataAdditionals = new FakeDbSet<BrokerDataAdditional>("BrokerAdditionalId");
            BrokerDataLives = new FakeDbSet<BrokerDataLive>("OpenOrClosed", "FcaNumber", "AgencyNumber", "CommissionBand", "ProductFiltersCurrentlyAssigned", "DirectlyAuthorisedFirmFcaNumber", "DirectlyAuthorised", "ClubMembers");
            BrokerDataViews = new FakeDbSet<BrokerDataView>("BdmName", "CompanyType");
            BrokerFirms = new FakeDbSet<BrokerFirm>("BrokerFirmId");
            BrokerManagers = new FakeDbSet<BrokerManager>("BrokerManagerId");
            BrokerNetworkDatas = new FakeDbSet<BrokerNetworkData>("NetworkId");
            BusRegDataLives = new FakeDbSet<BusRegDataLive>("AppType", "Division", "KfiNumber", "PolicyNumber", "AccountNo", "DateKfiCreated", "DateAppReceived", "InitialLoanAmountRequested", "ArrangementFeeAddedToLoan", "ArrangementFee", "RetentionBalanceReleased", "MaximumDrawdownLimit", "ChosenDrawdownLimit", "TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees", "DrawdownsMade", "ValuationFee", "FreeVal", "RefundOfValuationFee", "UploadedBy", "Underwriter", "InternalRefNumber", "InterestAppliedToDate", "RedemptionsToDate", "AccountStatus");
            BusregViews = new FakeDbSet<BusregView>("AppType", "Division", "KfiNumber", "PolicyNumber", "AccountNo", "DateKfiCreated", "DateAppReceived", "InitialLoanAmountRequested", "ArrangementFeeAddedToLoan", "ArrangementFee", "RetentionBalanceReleased", "MaximumDrawdownLimit", "ChosenDrawdownLimit", "TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees", "DrawdownsMade", "ValuationFee", "FreeVal", "RefundOfValuationFee", "UploadedBy", "Underwriter", "InternalRefNumber", "InterestAppliedToDate", "RedemptionsToDate", "AccountStatus", "FriendlyName", "BdmName");
            CaseFilters = new FakeDbSet<CaseFilter>("CaseFilterId");
            CaseFilterTaskConfigurations = new FakeDbSet<CaseFilterTaskConfiguration>("CaseFilterId", "TaskConfigurationId");
            CaseStates = new FakeDbSet<CaseState>("CaseStateId");
            CaseStateHistories = new FakeDbSet<CaseStateHistory>("KfiId", "CaseStateId");
            CompletionsWallboards = new FakeDbSet<CompletionsWallboard>("AccountNumber", "Customer1Surname", "Customer2Surname", "AnticipatedCompletionDate");
            Documents = new FakeDbSet<Document>("DocumentId");
            FriendlyNames = new FakeDbSet<FriendlyName>("FriendlyNameId");
            Gushes = new FakeDbSet<Gush>("GushId");
            GushResults = new FakeDbSet<GushResult>("GushId");
            GushThresholds = new FakeDbSet<GushThreshold>("GushThresholdId");
            KfiDatas = new FakeDbSet<KfiData>("PackagerMortgageId");
            KfiDataLives = new FakeDbSet<KfiDataLive>("Kfiid", "IssueBy", "Brokerref", "PlanRef", "KfiDate", "CcjNumber", "CcjValue", "IvaDetails", "BankruptcyDetails", "NetLoanAmount", "FeesToBeAdded", "FeesToBePaid", "ValuationFee", "ApplicationFee", "ApplicationFeeAddedFlag", "AcceptanceFee", "AcceptanceFeeAddedFlag", "CompletionFee", "CompletionFeeAddedFlag", "LasiFee", "LasiFeeAddedFlag", "FundTransferFee", "FundTransferFeeAddedFlag", "OtherCompletionFee", "LoanRedemptionFee", "SolicitorFee", "SolicitorFeeAddedFlag", "AdvisorFee", "AdvisorFeeAddedFlag", "PropertyValue", "AprRate", "GrossLoanAmount", "TotalAllFees", "PackagerMortgageId");
            KfiDataViews = new FakeDbSet<KfiDataView>("Kfiid", "IssueBy", "Brokerref", "PlanRef", "KfiDate", "CcjNumber", "CcjValue", "IvaDetails", "BankruptcyDetails", "NetLoanAmount", "FeesToBeAdded", "FeesToBePaid", "ValuationFee", "ApplicationFee", "ApplicationFeeAddedFlag", "AcceptanceFee", "AcceptanceFeeAddedFlag", "CompletionFee", "CompletionFeeAddedFlag", "LasiFee", "LasiFeeAddedFlag", "FundTransferFee", "FundTransferFeeAddedFlag", "OtherCompletionFee", "LoanRedemptionFee", "SolicitorFee", "SolicitorFeeAddedFlag", "AdvisorFee", "AdvisorFeeAddedFlag", "PropertyValue", "AprRate", "GrossLoanAmount", "TotalAllFees", "PackagerMortgageId", "FriendlyName", "BdmName", "IsFieldBased");
            MostRecentCaseStateHistories = new FakeDbSet<MostRecentCaseStateHistory>("KfiId", "CaseStateId", "Created");
            Packs = new FakeDbSet<Pack>("PackId");
            PackVersions = new FakeDbSet<PackVersion>("PackId", "VersionId");
            PackVersionDocuments = new FakeDbSet<PackVersionDocument>("PackId", "VersionId", "DocumentId");
            PackVersionSignOffs = new FakeDbSet<PackVersionSignOff>("PackId", "VersionId", "SignOffId");
            PackVoids = new FakeDbSet<PackVoid>("PackId");
            PaymentContactDetails = new FakeDbSet<PaymentContactDetail>("CompanyAddress3", "CompanyContactEmail", "CompanyContactTelephone", "CompanyType", "CompanyInSage");
            PortalAuthenticationTokens = new FakeDbSet<PortalAuthenticationToken>("Username");
            PortalDomains = new FakeDbSet<PortalDomain>("PortalDomainId");
            PortalDomainRoles = new FakeDbSet<PortalDomainRole>("PortalRoleId", "PortalDomainId");
            PortalRoles = new FakeDbSet<PortalRole>("PortalRoleId");
            PostcodeDatas = new FakeDbSet<PostcodeData>("Id", "PartialPostcode", "X", "Y", "Latitude", "Longitude", "Town", "County", "Region");
            ProductNameMapDeprecateds = new FakeDbSet<ProductNameMapDeprecated>("TableId");
            ProductNameMappings = new FakeDbSet<ProductNameMapping>("ProductCode");
            PureCommsReports = new FakeDbSet<PureCommsReport>("AccountNumber");
            PureWallboardDatas = new FakeDbSet<PureWallboardData>("Desc");
            ReferenceDatas = new FakeDbSet<ReferenceData>("RefId");
            Reportoffercommissionindividuals = new FakeDbSet<Reportoffercommissionindividual>("AccountNumber", "OfferDate", "Postcode", "LoanAmount", "Commission", "BrokerIndividualName");
            SgBrokerComms = new FakeDbSet<SgBrokerComm>("Type", "NominalA47CRef", "DepartmentCode", "TaxCode", "TaxAmount");
            SgBrokerRecords = new FakeDbSet<SgBrokerRecord>("DefaultNominal", "TaxCode", "TermsAgreed63");
            SignOffs = new FakeDbSet<SignOff>("SignOffId");
            Tasks = new FakeDbSet<Task>("KfiId", "TaskId");
            TaskConfigGroups = new FakeDbSet<TaskConfigGroup>("TaskConfigGroupId");
            TaskConfigSources = new FakeDbSet<TaskConfigSource>("TaskConfigGroupId", "TaskConfigurationId");
            TaskConfigurations = new FakeDbSet<TaskConfiguration>("TaskConfigurationId");
            TaskConfigurationsArchiveds = new FakeDbSet<TaskConfigurationsArchived>("TaskConfigurationId");
            TaskResults = new FakeDbSet<TaskResult>("KfiId", "TaskId");
            UserActivities = new FakeDbSet<UserActivity>("UserActivityId");
            UserActivityUserRoleMappings = new FakeDbSet<UserActivityUserRoleMapping>("UserActivityId", "UserRoleId");
            UserRoles = new FakeDbSet<UserRole>("UserRoleId");
            UserRoleGroupPrincipalMappings = new FakeDbSet<UserRoleGroupPrincipalMapping>("UserRoleId", "GroupPrincipalGuid");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public System.Collections.Generic.List<UpdateProductCodesReturnModel> UpdateProductCodes()
        {
            int procResult;
            return UpdateProductCodes(out procResult);
        }

        public System.Collections.Generic.List<UpdateProductCodesReturnModel> UpdateProductCodes(out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<UpdateProductCodesReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<UpdateProductCodesReturnModel>> UpdateProductCodesAsync()
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(UpdateProductCodes(out procResult));
        }

    }
}
