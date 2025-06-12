using System;

namespace Data.Company.Employment
{
    public sealed class JobDTO
    {
        #region Variables
        private string V_Name;
        private string? V_Description;
        #endregion



        #region Constructor Method
        public JobDTO()
            : base()
        {
            this.V_Name = string.Empty;
            this.V_Description = null;
        }

        public JobDTO(string Name,
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
            get => this.V_Name.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Name = value.Trim();
            }
        }

        public string? Description
        {
            get => this.V_Description?.Trim();
            set => this.V_Description = value?.Trim();
        }
        #endregion
    }
}