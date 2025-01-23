using System;

namespace Data.HumanResources
{
    public class SalaryData
    {
        #region Variables
        private ulong? ID { get; set; }
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
            this.ID = null;
            this.BaseSalary = float.MinValue;
            this.Gratification = float.MinValue;
            this.SnackBonus = float.MinValue;
            this.MobilizationBonus = float.MinValue;
            this.StartDate = DateOnly.MinValue;
            this.EndDate = null;
            this.IncomeTax = 0;
            this.BonusList = Array.Empty<float>();
        }

        public SalaryData(ulong? ID,
                          float BaseSalary,
                          float Gratification,
                          float SnackBonus,
                          float MobilizationBonus,
                          DateOnly StartDate,
                          DateOnly? EndDate,
                          float IncomeTax,
                          float[] BonusList)
            : base()
        {
            this.ID = ID;
            this.BaseSalary = BaseSalary;
            this.Gratification = Gratification;
            this.SnackBonus = SnackBonus;
            this.MobilizationBonus = MobilizationBonus;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IncomeTax = IncomeTax;
            this.BonusList = BonusList;
        }
        #endregion



        #region Destroyer Method
        ~SalaryData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong? GetID()
        {
            return ID;
        }

        public void SetSalaryID(ulong? ID)
        {
            this.ID = ID;
        }
        
        public float GetBaseSalary()
        {
            return this.BaseSalary;
        }

        public void SetBaseSalary(float BaseSalary)
        {
            if (float.IsNaN(f: BaseSalary))
            {
                throw new Exception(nameof(BaseSalary));
            }
            else
            if (float.IsNegative(f: BaseSalary))
            {
                throw new Exception(nameof(BaseSalary));
            }
            
            this.BaseSalary = BaseSalary;
        }

        public float GetGratification()
        {
            return this.Gratification;
        }

        public void SetGratification(float Gratification)
        {
            if (float.IsNegative(f: Gratification))
            {
                throw new ArithmeticException(message: nameof(Gratification));
            }
            
            this.Gratification = Gratification;
        }

        public float GetSnackBonus()
        {
            return this.SnackBonus;
        }

        public void SetSnackBonus(float SnackBonus)
        {
            if (float.IsNegative(f: SnackBonus))
            {
                throw new ArithmeticException(message: nameof(SnackBonus));
            }
            
            this.SnackBonus = SnackBonus;
        }

        public float GetMobilizationBonus()
        {
            return this.MobilizationBonus;
        }

        public void SetMobilizationBonus(float MobilizationBonus)
        {
            if (float.IsNegative(f: MobilizationBonus))
            {
                throw new ArithmeticException(message: nameof(MobilizationBonus));
            }
            
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
            if (float.IsNaN(f: IncomeTax))
            {
                throw new Exception(nameof(IncomeTax));
            }
            else
            if (float.IsNegative(f: IncomeTax))
            {
                throw new Exception(nameof(IncomeTax));
            }
            
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