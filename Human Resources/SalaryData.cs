using System;

namespace Data.Human_Resources
{
    public class SalaryData
    {
        #region Variables
        private ulong ID { get; set; }
        private float BaseSalary { get; set; }
        private DateOnly StartDate { get; set; }
        private DateOnly? EndDate { get; set; }
        private float IncomeTax { get; set; }
        #endregion



        #region Constructor Method
        public SalaryData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.BaseSalary = float.MinValue;
            this.StartDate = DateOnly.MinValue;
            this.EndDate = null;
            this.IncomeTax = 0;
        }

        public SalaryData(ulong ID,
                          float BaseSalary,
                          DateOnly StartDate,
                          DateOnly? EndDate,
                          float IncomeTax)
            : base()
        {
            this.ID = ID;
            this.BaseSalary = BaseSalary;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IncomeTax = IncomeTax;
        }
        #endregion



        #region Destroyer Method
        ~SalaryData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong GetSalaryID()
        {
            return ID;
        }

        public void SetSalaryID(ulong ID)
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
    }
}