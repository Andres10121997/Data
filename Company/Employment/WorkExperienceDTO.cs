using System;

namespace Data.Company.Employment
{
    public sealed class WorkExperienceDTO
    {
        #region Variables
        private string V_Position;
        private DateOnly V_StartDate;
        private DateOnly? V_EndDate;
        private string V_Description;
        #endregion

        #region Object
        private CompanyDTO O_Company;
        #endregion



        #region Constructor Method
        public WorkExperienceDTO()
            : base()
        {
            #region Variables
            this.V_Position = string.Empty;
            this.V_StartDate = new DateOnly();
            this.V_EndDate = null;
            this.V_Description = string.Empty;
            #endregion

            #region Objects
            this.O_Company = new CompanyDTO();
            #endregion
        }

        public WorkExperienceDTO(string Position,
                                  DateOnly StartDate,
                                  DateOnly? EndDate,
                                  string Description,
                                  CompanyDTO Company)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Position);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Position);
            ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(value: StartDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Description);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Description);
            #endregion

            #region Variables
            this.V_Position = Position.Trim();
            this.V_StartDate = StartDate;
            this.V_EndDate = EndDate;
            this.V_Description = Description.Trim();
            #endregion

            #region Objects
            this.O_Company = Company;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string Position
        {
            get => V_Position.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Position = value.Trim();
            }
        }

        public DateOnly StartDate
        {
            get => this.V_StartDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(
                    value: value,
                    other: DateOnly.FromDateTime(dateTime: DateTime.Now)
                );

                this.V_StartDate = value;
            }
        }

        public DateOnly? EndDate
        {
            get => this.V_EndDate;
            set => this.V_EndDate = value;
        }

        public string Description
        {
            get => this.V_Description.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Description = value.Trim();
            }
        }
        #endregion

        #region Object
        public CompanyDTO Company
        {
            get => this.O_Company;
            set => this.O_Company = value;
        }
        #endregion
        #endregion
    }
}