﻿using System;
using System.Threading.Tasks;

namespace Data.Project
{
    public sealed class ProjectData
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

        #region Objects
        private VersionData Version { get; set; }
        #endregion



        #region Constructor Methods
        public ProjectData()
            : base()
        {
            #region Variables
            this.Name = string.Empty;
            this.Description = null;
            this.CreationDate = new DateOnly();
            this.CreationTime = new TimeOnly();
            this.AccessLevel = AccessLevelEnum.Private;
            #endregion

            #region Objects
            this.Version = new VersionData();
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
            this.Name = Name.Trim();
            this.Description = Description?.Trim();
            this.CreationDate = CreationDate;
            this.CreationTime = CreationTime;
            this.AccessLevel = AccessLevel;
            #endregion

            #region Objects
            this.Version = Version;
            #endregion
        }
        #endregion



        #region Destructor Methods
        ~ProjectData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
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

        public DateOnly GetCreationDate()
        {
            return this.CreationDate;
        }

        public void SetCreationDate(DateOnly CreationDate)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));

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

        #region Objects
        public VersionData GetVersion()
        {
            return this.Version;
        }

        public void SetVersion(VersionData Version)
        {
            this.Version = Version;
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