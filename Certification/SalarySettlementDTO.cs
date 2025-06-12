using Data.Company.HumanResources;

namespace Data.Certification
{
    public sealed class SalarySettlementDTO : CertificateDTO
    {
        #region Objects
        private EmployeeDTO O_Employee;
        #endregion



        #region Constructor Method
        public SalarySettlementDTO()
            : base()
        {
            this.O_Employee = new EmployeeDTO();
        }

        public SalarySettlementDTO(EmployeeDTO Employee)
            : base()
        {
            this.O_Employee = Employee;
        }
        #endregion



        #region Getters and Setters
        public EmployeeDTO Employee
        {
            get => this.O_Employee;
            set => this.O_Employee = value;
        }
        #endregion
    }
}