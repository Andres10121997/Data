using Data.Account;
using Data.Other;
using System;

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
        private DepartmentData Department { get; set; }
        private SalaryData Salary { get; set; }
        #endregion

        #region Arrays
        private SalaryData[]? SalaryHistory { get; set; }
        #endregion



        #region Constructor Method
        public EmployeeData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.HiringDate = DateOnly.MinValue;
            this.ContractEndDate = null;
            this.Salary = new SalaryData();
            this.Department = new DepartmentData();
            this.SalaryHistory = null;
        }

        public EmployeeData(ulong ID,
                            DateOnly HiringDate,
                            DateOnly? ContractEndDate,
                            SalaryData Salary,
                            DepartmentData Department,
                            SalaryData[]? SalaryHistory)
            : base()
        {
            this.ID = ID;
            this.HiringDate = HiringDate;
            this.ContractEndDate = ContractEndDate;
            this.Salary = Salary;
            this.Department = Department;
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
                            SalaryData Salary,
                            DepartmentData Department,
                            SalaryData[]? SalaryHistory)
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
            this.Salary = Salary;
            this.Department = Department;
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
        public SalaryData GetSalary()
        {
            return this.Salary;
        }

        public void SetSalary(SalaryData Salary)
        {
            this.Salary = Salary;
        }

        public DepartmentData GetDepartment()
        {
            return this.Department;
        }

        public void SetDepartment(DepartmentData Department)
        {
            this.Department = Department;
        }
        #endregion

        #region Arrays
        public SalaryData[]? GetSalaryHistory()
        {
            return this.SalaryHistory;
        }

        public void SetSalaryHistory(SalaryData[]? SalaryHistory)
        {
            this.SalaryHistory = SalaryHistory;
        }
        #endregion
        #endregion
    }
}