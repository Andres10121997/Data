using System;

namespace Data.Company
{
    public sealed class CompanyData
    {
        #region Variables
        private string V_Name;
        private DateOnly V_CreationDate;
        private string V_EconomicActivity;
        private CompanyTypeEnum V_CompanyType;
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
            this.V_Name = string.Empty;
            this.V_CreationDate = new DateOnly();
            this.V_EconomicActivity = string.Empty;
            this.V_CompanyType = CompanyTypeEnum.None;
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
            this.V_Name = Name.Trim();
            this.V_CreationDate = CreationDate;
            this.V_EconomicActivity = EconomicActivity.Trim();
            this.V_CompanyType = CompanyType;
            #endregion
        }
        #endregion



        #region Getters and Setters
        public string Name
        {
            get => this.V_Name.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Name = value.Trim();
            }
        }

        public DateOnly CreationDate
        {
            get => this.V_CreationDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(
                    value: value,
                    other: DateOnly.FromDateTime(dateTime: DateTime.Now)
                );

                this.V_CreationDate = value;
            }
        }

        public string EconomicActivity
        {
            get => this.V_EconomicActivity.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_EconomicActivity = value;
            }
        }

        public CompanyTypeEnum CompanyType
        {
            get => this.V_CompanyType;
            set => this.V_CompanyType = value;
        }
        #endregion
    }
}