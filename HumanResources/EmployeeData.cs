using Data.Account;
using System;

namespace Data.HumanResources
{
    public class EmployeeData : PersonData
    {
        #region Variables
        private DateOnly HiringDate { get; set; }
        private DateOnly? ContractEndDate { get; set; }
        #endregion

        #region Objects
        private DepartmentData Department { get; set; }
        private JobData Job { get; set; }
        private SalaryData Salary { get; set; }
        #endregion

        #region Arrays
        private SalaryData[]? SalaryHistory { get; set; }
        #endregion



        #region Constructor Method
        public EmployeeData()
            : base()
        {
            #region Variables
            this.HiringDate = DateOnly.MinValue;
            this.ContractEndDate = null;
            #endregion

            #region Objects
            this.Department = new DepartmentData();
            this.Job = new JobData();
            this.Salary = new SalaryData();
            #endregion

            #region Arrays
            this.SalaryHistory = null;
            #endregion
        }

        public EmployeeData(DateOnly HiringDate,
                            DateOnly? ContractEndDate,
                            DepartmentData Department,
                            JobData Job,
                            SalaryData Salary,
                            SalaryData[]? SalaryHistory)
            : base()
        {
            #region Variables
            this.HiringDate = HiringDate;
            this.ContractEndDate = ContractEndDate;
            #endregion

            #region Objects
            this.Department = Department;
            this.Job = Job;
            this.Salary = Salary;
            #endregion

            #region Arrays
            this.SalaryHistory = SalaryHistory;
            #endregion
        }

        public EmployeeData(ulong? ID,
                            string FirstName,
                            string? MiddleName,
                            string FirstLastName,
                            string? SecondLastName,
                            DateOnly DateOfBirth,
                            SexData OSex,
                            DateOnly HiringDate,
                            DateOnly? ContractEndDate,
                            DepartmentData Department,
                            JobData Job,
                            SalaryData Salary,
                            SalaryData[]? SalaryHistory)
            : base(ID: ID,
                   FirstName: FirstName,
                   MiddleName: MiddleName,
                   FirstLastName: FirstLastName,
                   SecondLastName: SecondLastName,
                   DateOfBirth: DateOfBirth,
                   OSex: OSex)
        {
            #region Variables
            this.HiringDate = HiringDate;
            this.ContractEndDate = ContractEndDate;
            #endregion

            #region Objects
            this.Department = Department;
            this.Job = Job;
            this.Salary = Salary;
            #endregion

            #region Arrays
            this.SalaryHistory = SalaryHistory;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~EmployeeData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public DateOnly GetHiringDate()
        {
            return this.HiringDate;
        }

        public void SetHiringDate(DateOnly HiringDate)
        {
            this.HiringDate = HiringDate;
        }

        public DateOnly? GetContractEndDate()
        {
            return this.ContractEndDate;
        }

        public void SetContractEndDate(DateOnly? ContractEndDate)
        {
            this.ContractEndDate = ContractEndDate;
        }
        #endregion

        #region Objects
        public DepartmentData GetDepartment()
        {
            return this.Department;
        }

        public void SetDepartment(DepartmentData Department)
        {
            this.Department = Department;
        }

        public JobData GetJob()
        {
            return this.Job;
        }

        public void SetJob(JobData Job)
        {
            this.Job = Job;
        }

        public SalaryData GetSalary()
        {
            return this.Salary;
        }

        public void SetSalary(SalaryData Salary)
        {
            this.Salary = Salary;
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