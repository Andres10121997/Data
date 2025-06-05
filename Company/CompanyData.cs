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
            this.Name = Name.Trim();
            this.CreationDate = CreationDate;
            this.EconomicActivity = EconomicActivity.Trim();
            this.CompanyType = CompanyType;
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
            if (string.IsNullOrEmpty(value: Name)
                ||
                string.IsNullOrWhiteSpace(value: Name))
            {
                throw new ArgumentNullException(paramName: nameof(Name),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Name), ClassName: nameof(CompanyData)));
            }
            
            this.Name = Name.Trim();
        }

        public DateOnly GetCreationDate()
        {
            return this.CreationDate;
        }

        public void SetCreationDate(DateOnly CreationDate)
        {
            this.CreationDate = CreationDate;
        }

        public string GetEconomicActivity()
        {
            return this.EconomicActivity;
        }

        public void SetEconomicActivity(string EconomicActivity)
        {
            if (string.IsNullOrEmpty(value: EconomicActivity)
                ||
                string.IsNullOrWhiteSpace(value: EconomicActivity))
            {
                throw new ArgumentNullException(paramName: nameof(EconomicActivity),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(EconomicActivity), ClassName: nameof(CompanyData)));
            }
            
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