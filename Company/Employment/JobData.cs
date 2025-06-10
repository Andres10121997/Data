using System;

namespace Data.Company.Employment
{
    public sealed record JobData
    {
        #region Variables
        private string V_Name;
        private string? V_Description;
        #endregion



        #region Constructor Method
        public JobData()
            : base()
        {
            this.V_Name = string.Empty;
            this.V_Description = null;
        }

        public JobData(string Name,
                       string? Description)
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            #endregion

            #region Variables
            this.V_Name = Name.Trim();
            this.V_Description = Description?.Trim();
            #endregion
        }
        #endregion



        #region Getters and Setters
        public string Name
        {
            get => this.V_Name;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Name = value.Trim();
            }
        }

        public string? Description
        {
            get => this.V_Description;
            set
            {
                this.V_Description = value?.Trim();
            }
        }
        #endregion
    }
}