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
        #endregion



        #region Constructor Method
        public SalaryData()
            : base()
        {
            this.BaseSalary = float.MinValue;
            this.StartDate = DateOnly.MinValue;
            this.EndDate = null;
        }

        public SalaryData(float BaseSalary,
                          DateOnly StartDate,
                          DateOnly? EndDate)
            : base()
        {
            this.BaseSalary = BaseSalary;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
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
        #endregion
    }
}