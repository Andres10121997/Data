using System;
using System.Threading.Tasks;

namespace Data.Project
{
    public sealed class ProjectData
    {
        #region Variables
        private string V_Name;
        private string? V_Description;
        private DateOnly V_CreationDate;
        private TimeOnly V_CreationTime;
        private AccessLevelEnum V_AccessLevel;
        #endregion

        #region Enum
        public enum AccessLevelEnum : byte
        {
            Private,
            Protected,
            Public
        }
        #endregion

        #region Objects
        private VersionData O_Version;
        #endregion



        #region Constructor Methods
        public ProjectData()
            : base()
        {
            #region Variables
            this.V_Name = string.Empty;
            this.V_Description = null;
            this.V_CreationDate = new DateOnly();
            this.V_CreationTime = new TimeOnly();
            this.V_AccessLevel = AccessLevelEnum.Private;
            #endregion

            #region Objects
            this.O_Version = new VersionData();
            #endregion
        }

        public ProjectData(string Name,
                           string? Description,
                           DateOnly CreationDate,
                           TimeOnly CreationTime,
                           AccessLevelEnum AccessLevel,
                           VersionData Version)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.V_Name = Name.Trim();
            this.V_Description = Description?.Trim();
            this.V_CreationDate = CreationDate;
            this.V_CreationTime = CreationTime;
            this.V_AccessLevel = AccessLevel;
            #endregion

            #region Objects
            this.O_Version = Version;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
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

        public DateOnly CreationDate
        {
            get => this.V_CreationDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(
                    value: value,
                    other: DateOnly.FromDateTime(dateTime: DateTime.Now)
                );

                this.V_CreationDate = value;
            }
        }

        public TimeOnly CreationTime
        {
            get => this.V_CreationTime;
            set => this.V_CreationTime = value;
        }

        public AccessLevelEnum AccessLevel
        {
            get => this.V_AccessLevel;
            set => this.V_AccessLevel = value;
        }
        #endregion

        #region Objects
        public VersionData Version
        {
            get => this.O_Version;
            set => this.O_Version = value;
        }
        #endregion
        #endregion



        #region To
        public DateTime ToCreationDateTime()
        {
            DateTime CreationDateTime;

            CreationDateTime = this.CreationDate.ToDateTime(time: this.CreationTime);

            return CreationDateTime;
        }

        public async Task<DateTime> ToCreationDateTimeAsync()
        {
            return await Task.Run<DateTime>(function: () => this.ToCreationDateTime());
        }
        #endregion
    }
}