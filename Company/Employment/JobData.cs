using System;

namespace Data.Company.Employment
{
    public sealed class JobData
    {
        #region Variables
        private string Name { get; set; }
        private string? Description { get; set; }
        #endregion



        #region Constructor Method
        public JobData()
            : base()
        {
            this.Name = string.Empty;
            this.Description = null;
        }

        public JobData(string Name,
                       string? Description)
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            #endregion

            #region Variables
            this.Name = Name.Trim();
            this.Description = Description?.Trim();
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~JobData()
        {

        }
        #endregion



        #region Getters and Setters
        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);

            this.Name = Name.Trim();
        }

        public string? GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string? Description)
        {
            this.Description = Description?.Trim();
        }
        #endregion
    }
}