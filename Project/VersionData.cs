using System;
using System.Threading.Tasks;

namespace Data.Project
{
    public sealed record VersionData
    {
        #region Variables
        private string? V_PreRelease; // Ej. "alpha", "beta", "rc1"
        private string V_Description;
        private DateOnly V_UpdateDate;
        private TimeOnly V_UpdateTime;
        #endregion

        #region Object
        private Version O_Version { get; set; }
        #endregion



        #region Constructor Methods
        public VersionData()
            : base()
        {
            #region Variables
            this.V_PreRelease = null;
            this.V_Description = string.Empty;
            this.V_UpdateDate = new DateOnly();
            this.V_UpdateTime = new TimeOnly();
            #endregion

            #region Object
            this.O_Version = new Version();
            #endregion
        }

        public VersionData(string? PreRelease,
                           string Description,
                           DateOnly UpdateDate,
                           TimeOnly UpdateTime,
                           Version OVersion)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Description);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Description);
            #endregion

            #region Variables
            this.V_PreRelease = PreRelease;
            this.V_Description = Description;
            this.V_UpdateDate = UpdateDate;
            this.V_UpdateTime = UpdateTime;
            #endregion

            #region Object
            this.O_Version = OVersion;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string? PreRelease
        {
            get => this.V_PreRelease;
            set
            {
                V_PreRelease = value;
            }
        }

        public string Description
        {
            get => this.V_Description;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Description = value;
            }
        }

        public DateOnly UpdateDate
        {
            get => this.V_UpdateDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan(
                    value: value,
                    other: DateOnly.FromDateTime(dateTime: DateTime.Now)
                );
                
                this.V_UpdateDate = value;
            }
        }

        public TimeOnly UpdateTime
        {
            get => this.V_UpdateTime;
            set
            {
                this.V_UpdateTime = value;
            }
        }
        #endregion

        #region Object
        public Version version
        {
            get => this.O_Version;
            set
            {
                this.O_Version = value;
            }
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

            Version = $"{this.version.Major}.{this.version.Minor}.{this.version.Build}.{this.version.Revision}";

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