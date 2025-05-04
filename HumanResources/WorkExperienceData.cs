using System;

namespace Data.HumanResources
{
    public class WorkExperienceData
    {
        #region Variables
        private string Company { get; set; }
        private string Position { get; set; }
        private DateOnly StartDate { get; set; }
        private DateOnly? EndDate { get; set; }
        private string Description { get; set; }
        #endregion



        #region Constructor Method
        public WorkExperienceData()
            : base()
        {
            this.Company = string.Empty;
            this.Position = string.Empty;
            this.StartDate = new DateOnly();
            this.EndDate = null;
            this.Description = string.Empty;
        }

        public WorkExperienceData(string Company,
                                  string Position,
                                  DateOnly StartDate,
                                  DateOnly? EndDate,
                                  string Description)
            : base()
        {
            this.Company = Company;
            this.Position = Position;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Description = Description;
        }
        #endregion



        #region Destroyer Method
        ~WorkExperienceData()
        {

        }
        #endregion



        #region Getters and Setters
        public string GetCompany()
        {
            return this.Company;
        }

        public void SetCompany(string Company)
        {
            this.Company = Company;
        }

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
    }
}