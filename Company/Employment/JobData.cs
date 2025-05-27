using System;

namespace Data.Company.Employment
{
    public class JobData
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
            this.Name = Name.Trim();
            this.Description = Description?.Trim();
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
            if (string.IsNullOrEmpty(value: Name)
                ||
                string.IsNullOrWhiteSpace(value: Name))
            {
                throw new ArgumentNullException(paramName: nameof(Name),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Name), ClassName: nameof(JobData)));
            }

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