using System;

namespace Data.Company
{
    public class WorkExperienceData
    {
        #region Variables
        private string Position { get; set; }
        private DateOnly StartDate { get; set; }
        private DateOnly? EndDate { get; set; }
        private string Description { get; set; }
        #endregion

        #region Object
        private CompanyData Company { get; set; }
        #endregion



        #region Constructor Method
        public WorkExperienceData()
            : base()
        {
            this.Position = string.Empty;
            this.StartDate = new DateOnly();
            this.EndDate = null;
            this.Description = string.Empty;
            this.Company = new CompanyData();
        }

        public WorkExperienceData(string Position,
                                  DateOnly StartDate,
                                  DateOnly? EndDate,
                                  string Description,
                                  CompanyData Company)
            : base()
        {
            this.Position = Position;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Description = Description;
            this.Company = Company;
        }
        #endregion



        #region Destroyer Method
        ~WorkExperienceData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string GetPosition()
        {
            return this.Position;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
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

        public void SetEndDate(DateOnly EndDate)
        {
            this.EndDate = EndDate;
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string Description)
        {
            this.Description = Description;
        }
        #endregion

        #region Object
        public CompanyData GetCompany()
        {
            return this.Company;
        }

        public void SetCompany(CompanyData Company)
        {
            this.Company = Company;
        }
        #endregion
        #endregion
    }
}