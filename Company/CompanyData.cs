using System;

namespace Data.Company
{
    public sealed class CompanyData
    {
        #region Variables
        private string Name { get; set; }
        private DateOnly CreationDate { get; set; }
        private string EconomicActivity { get; set; }
        private CompanyTypeEnum CompanyType { get; set; }
        #endregion

        #region Enum
        public enum CompanyTypeEnum : byte
        {
            IndividualLimitedLiabilityEnterprise,     // Empresa Individual de Responsabilidad Limitada (EIRL)
            LimitedLiabilityCompany,                  // Sociedad de Responsabilidad Limitada (SRL o Ltda.)
            JointStockCompany,                        // Sociedad por Acciones (SpA)
            Corporation,                              // Sociedad Anónima (SA)
            MutualGuaranteeCorporation,               // Sociedad Anónima de Garantía Recíproca (SAGR)
            GeneralPartnership,                       // Sociedad Colectiva Comercial
            LimitedPartnership,                       // Sociedad en Comandita Simple
            PartnershipLimitedByShares,               // Sociedad en Comandita por Acciones
            None
        }
        #endregion



        #region Constructor Method
        public CompanyData()
            : base()
        {
            this.Name = string.Empty;
            this.CreationDate = new DateOnly();
            this.EconomicActivity = string.Empty;
            this.CompanyType = CompanyTypeEnum.None;
        }

        public CompanyData(string Name,
                           DateOnly CreationDate,
                           string EconomicActivity,
                           CompanyTypeEnum CompanyType)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            ArgumentNullException.ThrowIfNullOrEmpty(argument: EconomicActivity);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: EconomicActivity);
            #endregion

            #region Variables
            this.Name = Name.Trim();
            this.CreationDate = CreationDate;
            this.EconomicActivity = EconomicActivity.Trim();
            this.CompanyType = CompanyType;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~CompanyData()
        {

        }
        #endregion



        #region Getters and Setters
        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            
            this.Name = Name.Trim();
        }

        public DateOnly GetCreationDate()
        {
            return this.CreationDate;
        }

        public void SetCreationDate(DateOnly CreationDate)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            
            this.CreationDate = CreationDate;
        }

        public string GetEconomicActivity()
        {
            return this.EconomicActivity;
        }

        public void SetEconomicActivity(string EconomicActivity)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: EconomicActivity);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: EconomicActivity);
            
            this.EconomicActivity = EconomicActivity.Trim();
        }

        public CompanyTypeEnum GetCompanyType()
        {
            return this.CompanyType;
        }

        public void SetCompanyType(CompanyTypeEnum CompanyType)
        {
            this.CompanyType = CompanyType;
        }
        #endregion
    }
}