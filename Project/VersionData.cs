using System;
using System.Threading.Tasks;

namespace Data.Project
{
    public class VersionData
    {
        #region Variables
        private byte Major { get; set; }
        private byte Minor { get; set; }
        private byte Patch { get; set; }
        private string? PreRelease { get; set; } // Ej. "alpha", "beta", "rc1"
        private string Description { get; set; }
        private DateOnly UpdateDate { get; set; }
        private TimeOnly UpdateTime { get; set; }
        #endregion



        #region Constructor Methods
        public VersionData()
            : base()
        {
            this.Major = 0;
            this.Minor = 0;
            this.Patch = 0;
            this.PreRelease = null;
            this.Description = string.Empty;
            this.UpdateDate = new DateOnly();
            this.UpdateTime = new TimeOnly();
        }

        public VersionData(byte Major,
                           byte Minor,
                           byte Patch,
                           string? PreRelease,
                           string Description,
                           DateOnly UpdateDate,
                           TimeOnly UpdateTime)
            : base()
        {
            this.Major = Major;
            this.Minor = Minor;
            this.Patch = Patch;
            this.PreRelease = PreRelease;
            this.Description = Description;
            this.UpdateDate = UpdateDate;
            this.UpdateTime = UpdateTime;
        }
        #endregion



        #region Destructor Methods
        ~VersionData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public byte GetMajor()
        {
            return this.Major;
        }

        public void SetMajor(byte Major)
        {
            this.Major = Major;
        }

        public byte GetMinor()
        {
            return this.Minor;
        }

        public void SetMinor(byte Minor)
        {
            this.Minor = Minor;
        }

        public byte GetPatch()
        {
            return this.Patch;
        }

        public void SetPatch(byte Patch)
        {
            this.Patch = Patch;
        }

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

        // Convertir VersionData a System.Version
        public Version ToSystemVersion()
        {
            return new Version(Major, Minor, Patch);
        }
        #endregion



        #region From
        // Convertir System.Version a VersionData
        public static VersionData FromSystemVersion(Version version, string? preRelease = null, string description = "")
        {
            return new VersionData(
                (byte)version.Major,
                (byte)version.Minor,
                (byte)version.Build, // Usamos Build para el 'Patch'
                preRelease,
                description,
                DateOnly.FromDateTime(DateTime.Now),
                TimeOnly.FromDateTime(DateTime.Now)
            );
        }
        #endregion



        #region Full Version
        public string FullVersion()
        {
            string Version = $"{Major}.{Minor}.{Patch}";

            if (!string.IsNullOrWhiteSpace(PreRelease))
            {
                Version += $"-{PreRelease}";
            }

            return Version;
        }

        public async Task<string> FullVersionAsync()
        {
            return await Task.Run<string>(function: () => this.FullVersion());
        }
        #endregion
    }
}