using Data.Account;
using Data.Company.Employment;
using System;

namespace Data.Company.HumanResources
{
    public sealed class EmployeeDTO : PersonDTO
    {
        #region Variables
        private DateOnly V_HiringDate;
        private DateOnly? V_ContractEndDate;
        #endregion

        #region Objects
        private DepartmentDTO O_Department;
        private JobDTO O_Job;
        private SalaryDTO O_Salary;
        #endregion

        #region Arrays
        private SalaryDTO[]? A_SalaryHistory;
        #endregion



        #region Constructor Method
        public EmployeeDTO()
            : base()
        {
            #region Variables
            this.V_HiringDate = DateOnly.MinValue;
            this.V_ContractEndDate = null;
            #endregion

            #region Objects
            this.O_Department = new DepartmentDTO();
            this.O_Job = new JobDTO();
            this.O_Salary = new SalaryDTO();
            #endregion

            #region Arrays
            this.A_SalaryHistory = null;
            #endregion
        }

        public EmployeeDTO(DateOnly HiringDate,
                            DateOnly? ContractEndDate,
                            DepartmentDTO Department,
                            JobDTO Job,
                            SalaryDTO Salary,
                            SalaryDTO[]? SalaryHistory)
            : base()
        {
            #region Exception
            ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(value: HiringDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.V_HiringDate = HiringDate;
            this.V_ContractEndDate = ContractEndDate;
            #endregion

            #region Objects
            this.O_Department = Department;
            this.O_Job = Job;
            this.O_Salary = Salary;
            #endregion

            #region Arrays
            this.A_SalaryHistory = SalaryHistory;
            #endregion
        }

        public EmployeeDTO(string FirstName,
                            string? MiddleName,
                            string FirstLastName,
                            string? SecondLastName,
                            DateOnly BirthDate,
                            SexEnum Sex,
                            DateOnly HiringDate,
                            DateOnly? ContractEndDate,
                            DepartmentDTO Department,
                            JobDTO Job,
                            SalaryDTO Salary,
                            SalaryDTO[]? SalaryHistory)
            : base(FirstName: FirstName,
                   MiddleName: MiddleName,
                   FirstLastName: FirstLastName,
                   SecondLastName: SecondLastName,
                   BirthDate: BirthDate,
                   Sex: Sex)
        {
            #region Exception
            ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(value: HiringDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.V_HiringDate = HiringDate;
            this.V_ContractEndDate = ContractEndDate;
            #endregion

            #region Objects
            this.O_Department = Department;
            this.O_Job = Job;
            this.O_Salary = Salary;
            #endregion

            #region Arrays
            this.A_SalaryHistory = SalaryHistory;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public DateOnly HiringDate
        {
            get => this.V_HiringDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(
                    value: value,
                    other: DateOnly.FromDateTime(dateTime: DateTime.Now)
                );

                this.V_HiringDate = value;
            }
        }

        public DateOnly? ContractEndDate
        {
            get => this.V_ContractEndDate;
            set => this.V_ContractEndDate = value;
        }
        #endregion

        #region Objects
        public DepartmentDTO Department
        {
            get => this.O_Department;
            set => this.O_Department = value;
        }

        public JobDTO Job
        {
            get => this.O_Job;
            set => this.O_Job = value;
        }

        public SalaryDTO Salary
        {
            get => this.O_Salary;
            set => this.O_Salary = value;
        }
        #endregion

        #region Arrays
        public SalaryDTO[]? SalaryHistory
        {
            get => this.A_SalaryHistory;
            set => this.A_SalaryHistory = value;
        }
        #endregion
        #endregion
    }
}