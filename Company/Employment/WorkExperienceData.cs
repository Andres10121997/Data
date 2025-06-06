using System;

namespace Data.Company.Employment
{
    public sealed class WorkExperienceData
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
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Position);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Position);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: StartDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Description);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Description);
            #endregion

            #region Variables
            this.Position = Position.Trim();
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Description = Description.Trim();
            this.Company = Company;
            #endregion
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
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Position);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Position);
            
            this.Position = Position.Trim();
        }

        public DateOnly GetStartDate()
        {
            return this.StartDate;
        }

        public void SetStartDate(DateOnly StartDate)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: StartDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            
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
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Description);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Description);
            
            this.Description = Description.Trim();
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