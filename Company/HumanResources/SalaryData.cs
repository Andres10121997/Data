using System;

namespace Data.Company.HumanResources
{
    public sealed class SalaryData
    {
        #region Variables
        private float V_BaseSalary;
        private float V_Gratification;
        private float V_SnackBonus;
        private float V_MobilizationBonus;
        private DateOnly V_StartDate;
        private DateOnly? V_EndDate;
        private float V_IncomeTax;
        #endregion

        #region Arrays
        private float[] A_BonusList;
        #endregion



        #region Constructor Method
        public SalaryData()
            : base()
        {
            #region Variables
            this.V_BaseSalary = float.MinValue;
            this.V_Gratification = float.MinValue;
            this.V_SnackBonus = float.MinValue;
            this.V_MobilizationBonus = float.MinValue;
            this.V_StartDate = DateOnly.MinValue;
            this.V_EndDate = null;
            this.V_IncomeTax = 0;
            #endregion

            #region Arrays
            this.A_BonusList = Array.Empty<float>();
            #endregion
        }

        public SalaryData(float BaseSalary,
                          float Gratification,
                          float SnackBonus,
                          float MobilizationBonus,
                          DateOnly StartDate,
                          DateOnly? EndDate,
                          float IncomeTax,
                          float[] BonusList)
            : base()
        {
            #region Exception
            ArgumentOutOfRangeException.ThrowIfEqual<float>(value: BaseSalary, other: float.NaN);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero<float>(value: BaseSalary);
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: Gratification);
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: SnackBonus);
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: MobilizationBonus);
            ArgumentOutOfRangeException.ThrowIfEqual<float>(value: IncomeTax, other: float.NaN);
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: IncomeTax);
            #endregion

            #region Variables
            this.V_BaseSalary = BaseSalary;
            this.V_Gratification = Gratification;
            this.V_SnackBonus = SnackBonus;
            this.V_MobilizationBonus = MobilizationBonus;
            this.V_StartDate = StartDate;
            this.V_EndDate = EndDate;
            this.V_IncomeTax = IncomeTax;
            #endregion

            #region Arrays
            this.A_BonusList = BonusList;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public float BaseSalary
        {
            get => this.V_BaseSalary;
            set
            {
                ArgumentOutOfRangeException.ThrowIfEqual<float>(
                    value: value,
                    other: float.NaN
                );
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<float>(value: value);

                this.V_BaseSalary = value;
            }
        }

        public float Gratification
        {
            get => this.V_Gratification;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative<float>(value: value);

                this.V_Gratification = value;
            }
        }

        public float SnackBonus
        {
            get => this.V_SnackBonus;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative<float>(value: value);

                this.V_SnackBonus = value;
            }
        }

        public float MobilizationBonus
        {
            get => this.V_MobilizationBonus;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative<float>(value: value);

                this.V_MobilizationBonus = value;
            }
        }

        public DateOnly StartDate
        {
            get => this.V_StartDate;
            set => this.V_StartDate = value;
        }

        public DateOnly? EndDate
        {
            get => this.V_EndDate;
            set => this.V_EndDate = value;
        }

        public float IncomeTax
        {
            get => this.V_IncomeTax;
            set
            {
                ArgumentOutOfRangeException.ThrowIfEqual<float>(
                    value: value,
                    other: float.NaN
                );
                ArgumentOutOfRangeException.ThrowIfNegative<float>(value: value);

                this.V_IncomeTax = value;
            }
        }
        #endregion

        #region Arrays
        public float[] BonusList
        {
            get => this.A_BonusList;
            set
            {
                this.A_BonusList = value;
            }
        }
        #endregion
        #endregion
    }
}