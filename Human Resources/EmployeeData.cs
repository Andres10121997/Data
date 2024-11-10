using Data.Account;
using Data.Other;
using System;
using System.Collections.Generic;

namespace Data.Human_Resources
{
    public class EmployeeData : PersonData
    {
        #region Variables
        private ulong ID { get; set; }
        private DateOnly HiringDate { get; set; }
        private DateOnly? ContractEndDate { get; set; }
        #endregion

        #region Objects
        private SalaryData OSalary { get; set; }
        #endregion

        #region List
        private List<SalaryData> SalaryHistory { get; set; }
        #endregion



        #region Constructor Method
        public EmployeeData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.HiringDate = DateOnly.MinValue;
            this.ContractEndDate = null;
            this.OSalary = new SalaryData();
            this.SalaryHistory = new List<SalaryData>();
        }

        public EmployeeData(ulong ID,
                            DateOnly HiringDate,
                            DateOnly? ContractEndDate,
                            SalaryData OSalary,
                            List<SalaryData> SalaryHistory)
            : base()
        {
            this.ID = ID;
            this.HiringDate = HiringDate;
            this.ContractEndDate = ContractEndDate;
            this.OSalary = OSalary;
            this.SalaryHistory = SalaryHistory;
        }

        public EmployeeData(ulong PersonID,
                            string FirstName,
                            string? MiddleName,
                            string FirstLastName,
                            string? SecondLastName,
                            DateOnly DateOfBirth,
                            SexData OSex,
                            ulong EmployeeID,
                            DateOnly HiringDate,
                            DateOnly? ContractEndDate,
                            SalaryData OSalary,
                            List<SalaryData> SalaryHistory)
            : base(ID: PersonID,
                   FirstName: FirstName,
                   MiddleName: MiddleName,
                   FirstLastName: FirstLastName,
                   SecondLastName: SecondLastName,
                   DateOfBirth: DateOfBirth,
                   OSex: OSex)
        {
            this.ID = EmployeeID;
            this.HiringDate = HiringDate;
            this.ContractEndDate = ContractEndDate;
            this.OSalary = OSalary;
            this.SalaryHistory = SalaryHistory;
        }
        #endregion



        #region Destroyer Method
        ~EmployeeData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong GetEmployeeID()
        {
            return this.ID;
        }

        public void SetEmployeeID(ulong ID)
        {
            this.ID = ID;
        }

        public DateOnly GetHiringDate()
        {
            return HiringDate;
        }

        public void SetHiringDate(DateOnly HiringDate)
        {
            this.HiringDate = HiringDate;
        }

        public DateOnly? GetContractEndDate()
        {
            return ContractEndDate;
        }

        public void SetContractEndDate(DateOnly? ContractEndDate)
        {
            this.ContractEndDate = ContractEndDate;
        }
        #endregion

        #region Objects
        public SalaryData GetOSalary()
        {
            return this.OSalary;
        }

        public void SetOSalary(SalaryData OSalary)
        {
            this.OSalary = OSalary;
        }
        #endregion

        #region List
        public List<SalaryData> GetSalaryHistory()
        {
            return this.SalaryHistory;
        }

        public void SetSalaryHistory(List<SalaryData> SalaryHistory)
        {
            this.SalaryHistory = SalaryHistory;
        }
        #endregion
        #endregion
    }
}