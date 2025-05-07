using Data.Company.HumanResources;

namespace Data.Certification
{
    public class SalarySettlementData : CertificateData
    {
        #region Objects
        private EmployeeData OEmployee { get; set; }
        #endregion



        #region Constructor Method
        public SalarySettlementData()
            : base()
        {
            this.OEmployee = new EmployeeData();
        }

        public SalarySettlementData(EmployeeData OEmployee)
            : base()
        {
            this.OEmployee = OEmployee;
        }
        #endregion



        #region Destroyer Method
        ~SalarySettlementData()
        {

        }
        #endregion



        #region Getters and Setters
        public EmployeeData GetOEmployee()
        {
            return this.OEmployee;
        }

        public void SetOEmployee(EmployeeData OEmployee)
        {
            this.OEmployee = OEmployee;
        }
        #endregion
    }
}