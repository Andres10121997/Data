using Data.Company.HumanResources;

namespace Data.Certification
{
    public sealed class SalarySettlementData : CertificateData
    {
        #region Objects
        private EmployeeData O_Employee;
        #endregion



        #region Constructor Method
        public SalarySettlementData()
            : base()
        {
            this.O_Employee = new EmployeeData();
        }

        public SalarySettlementData(EmployeeData Employee)
            : base()
        {
            this.O_Employee = Employee;
        }
        #endregion



        #region Getters and Setters
        public EmployeeData Employee
        {
            get => this.O_Employee;
            set => this.O_Employee = value;
        }
        #endregion
    }
}