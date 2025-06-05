using System;
using System.Threading.Tasks;

namespace Data.Project
{
    public sealed class VersionData
    {
        #region Variables
        private string? PreRelease { get; set; } // Ej. "alpha", "beta", "rc1"
        private string Description { get; set; }
        private DateOnly UpdateDate { get; set; }
        private TimeOnly UpdateTime { get; set; }
        #endregion

        #region Object
        private Version OVersion { get; set; }
        #endregion



        #region Constructor Methods
        public VersionData()
            : base()
        {
            #region Variables
            this.PreRelease = null;
            this.Description = string.Empty;
            this.UpdateDate = new DateOnly();
            this.UpdateTime = new TimeOnly();
            #endregion

            #region Object
            this.OVersion = new Version();
            #endregion
        }

        public VersionData(string? PreRelease,
                           string Description,
                           DateOnly UpdateDate,
                           TimeOnly UpdateTime,
                           Version OVersion)
            : base()
        {
            #region Variables
            this.PreRelease = PreRelease;
            this.Description = Description;
            this.UpdateDate = UpdateDate;
            this.UpdateTime = UpdateTime;
            #endregion

            #region Object
            this.OVersion = OVersion;
            #endregion
        }
        #endregion



        #region Destructor Methods
        ~VersionData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string? GetPreRelease()
        {
            return this.PreRelease;
        }

        public void SetPreRelease(string? PreRelease)
        {
            this.PreRelease = PreRelease;
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string Description)
        {
            if (string.IsNullOrEmpty(value: Description)
                ||
                string.IsNullOrWhiteSpace(value: Description))
            {
                throw new ArgumentNullException(paramName: nameof(Description),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Description), ClassName: nameof(VersionData)));
            }
            
            this.Description = Description;
        }

        public DateOnly GetUpdateDate()
        {
            return this.UpdateDate;
        }

        public void SetUpdateDate(DateOnly UpdateDate)
        {
            this.UpdateDate = UpdateDate;
        }

        public TimeOnly GetUpdateTime()
        {
            return this.UpdateTime;
        }

        public void SetUpdateTime(TimeOnly UpdateTime)
        {
            this.UpdateTime = UpdateTime;
        }
        #endregion

        #region Object
        public Version GetOVersion()
        {
            return this.OVersion;
        }

        public void SetOVersion(Version OVersion)
        {
            this.OVersion = OVersion;
        }
        #endregion
        #endregion



        #region To
        public DateTime ToUpdateDateTime()
        {
            DateTime UpdateDateTime;

            UpdateDateTime = this.UpdateDate.ToDateTime(time: this.UpdateTime);

            return UpdateDateTime;
        }

        public async Task<DateTime> ToUpdateDateTimeAsync()
        {
            return await Task.Run<DateTime>(function: () => this.ToUpdateDateTime());
        }
        #endregion



        #region Full Version
        public string FullVersion()
        {
            string Version;

            Version = $"{this.OVersion.Major}.{this.OVersion.Minor}.{this.OVersion.Build}.{this.OVersion.Revision}";

            if (!string.IsNullOrWhiteSpace(value: PreRelease))
            {
                Version += $"-{PreRelease}";
            }

            return Version.Trim();
        }

        public async Task<string> FullVersionAsync()
        {
            return await Task.Run<string>(function: () => this.FullVersion());
        }
        #endregion
    }
}