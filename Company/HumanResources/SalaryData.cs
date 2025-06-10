using System;

namespace Data.Company.HumanResources
{
    public sealed class SalaryData
    {
        #region Variables
        private float BaseSalary { get; set; }
        private float Gratification { get; set; }
        private float SnackBonus { get; set; }
        private float MobilizationBonus { get; set; }
        private DateOnly StartDate { get; set; }
        private DateOnly? EndDate { get; set; }
        private float IncomeTax { get; set; }
        #endregion

        #region Arrays
        private float[] BonusList { get; set; }
        #endregion



        #region Constructor Method
        public SalaryData()
            : base()
        {
            #region Variables
            this.BaseSalary = float.MinValue;
            this.Gratification = float.MinValue;
            this.SnackBonus = float.MinValue;
            this.MobilizationBonus = float.MinValue;
            this.StartDate = DateOnly.MinValue;
            this.EndDate = null;
            this.IncomeTax = 0;
            #endregion

            #region Arrays
            this.BonusList = Array.Empty<float>();
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
            this.BaseSalary = BaseSalary;
            this.Gratification = Gratification;
            this.SnackBonus = SnackBonus;
            this.MobilizationBonus = MobilizationBonus;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IncomeTax = IncomeTax;
            #endregion

            #region Arrays
            this.BonusList = BonusList;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~SalaryData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public float GetBaseSalary()
        {
            return this.BaseSalary;
        }

        public void SetBaseSalary(float BaseSalary)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<float>(value: BaseSalary, other: float.NaN);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero<float>(value: BaseSalary);

            this.BaseSalary = BaseSalary;
        }

        public float GetGratification()
        {
            return this.Gratification;
        }

        public void SetGratification(float Gratification)
        {
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: Gratification);

            this.Gratification = Gratification;
        }

        public float GetSnackBonus()
        {
            return this.SnackBonus;
        }

        public void SetSnackBonus(float SnackBonus)
        {
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: SnackBonus);

            this.SnackBonus = SnackBonus;
        }

        public float GetMobilizationBonus()
        {
            return this.MobilizationBonus;
        }

        public void SetMobilizationBonus(float MobilizationBonus)
        {
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: MobilizationBonus);

            this.MobilizationBonus = MobilizationBonus;
        }

        public DateOnly GetStartDate()
        {
            return this.StartDate;
        }

        public void SetStartDate(DateOnly StartDate)
        {
            this.StartDate = StartDate;
        }

        public DateOnly? GetEndDate()
        {
            return this.EndDate;
        }

        public void SetEndDate(DateOnly? EndDate)
        {
            this.EndDate = EndDate;
        }

        public float GetIncomeTax()
        {
            return this.IncomeTax;
        }

        public void SetIncomeTax(float IncomeTax)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<float>(value: IncomeTax, other: float.NaN);
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: IncomeTax);

            this.IncomeTax = IncomeTax;
        }
        #endregion

        #region Arrays
        public float[] GetBonusList()
        {
            return this.BonusList;
        }

        public void SetBonusList(float[] BonusList)
        {
            this.BonusList = BonusList;
        }
        #endregion
        #endregion
    }
}