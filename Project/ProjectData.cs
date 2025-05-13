using System;
using System.Threading.Tasks;

namespace Data.Project
{
    public class ProjectData
    {
        #region Variables
        private string Name { get; set; }
        private string? Description { get; set; }
        private DateOnly CreationDate { get; set; }
        private TimeOnly CreationTime { get; set; }
        private AccessLevelEnum AccessLevel { get; set; }
        #endregion

        #region Enum
        public enum AccessLevelEnum : byte
        {
            Private,
            Protected,
            Public
        }
        #endregion



        #region Constructor Methods
        public ProjectData()
            : base()
        {
            this.Name = string.Empty;
            this.Description = null;
            this.CreationDate = new DateOnly();
            this.CreationTime = new TimeOnly();
            this.AccessLevel = AccessLevelEnum.Private;
        }

        public ProjectData(string Name,
                           string? Description,
                           DateOnly CreationDate,
                           TimeOnly CreationTime,
                           AccessLevelEnum AccessLevel)
            : base()
        {
            this.Name = Name;
            this.Description = Description;
            this.CreationDate = CreationDate;
            this.CreationTime = CreationTime;
            this.AccessLevel = AccessLevel;
        }
        #endregion



        #region Destructor Methods
        ~ProjectData()
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
                                                message: $"The variable \"{nameof(Name)}\", of the {nameof(ProjectData)} class, cannot be null or empty or have blank fields.");
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

        public DateOnly GetCreationDate()
        {
            return this.CreationDate;
        }

        public void SetCreationDate(DateOnly CreationDate)
        {
            if (CreationDate > DateOnly.FromDateTime(dateTime: DateTime.Now))
            {
                throw new Exception();
            }

            this.CreationDate = CreationDate;
        }

        public TimeOnly GetCreationTime()
        {
            return this.CreationTime;
        }

        public void SetCreationTime(TimeOnly CreationTime)
        {
            this.CreationTime = CreationTime;
        }

        public AccessLevelEnum GetAccessLevel()
        {
            return this.AccessLevel;
        }

        public void SetAccessLevel(AccessLevelEnum AccessLevel)
        {
            this.AccessLevel = AccessLevel;
        }
        #endregion



        #region To
        public DateTime ToCreationDateTime()
        {
            DateTime CreationDateTime;

            CreationDateTime = CreationDate.ToDateTime(time: CreationTime);

            return CreationDateTime;
        }

        public async Task<DateTime> ToCreationDateTimeAsync()
        {
            return await Task.Run<DateTime>(function: () => this.ToCreationDateTime());
        }
        #endregion
    }
}