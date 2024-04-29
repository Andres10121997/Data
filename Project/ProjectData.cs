using System;

namespace Data.Project
{
    public class ProjectData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Name { get; set; }
        private string? Description { get; set; }
        private DateOnly CreationDate { get; set; }
        private TimeOnly CreationTime { get; set; }
        #endregion



        #region Constructor Method
        public ProjectData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Name = string.Empty;
            this.Description = null;
            this.CreationDate = DateOnly.MinValue;
            this.CreationTime = TimeOnly.MinValue;
        }

        public ProjectData(ulong ID,
                           string Name,
                           string? Description,
                           DateOnly CreationDate,
                           TimeOnly CreationTime)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.CreationDate = CreationDate;
            this.CreationTime = CreationTime;
        }
        #endregion



        #region Destroyer Method
        ~ProjectData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong GetProjectID()
        {
            return this.ID;
        }

        public void SetProjectID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name)
                ||
                string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(paramName: nameof(Name), message: "The project name cannot be null, empty, or have whitespace.");
            }
            
            this.Name = Name;
        }

        public string? GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string? Description)
        {
            this.Description = Description;
        }

        public DateOnly GetCreationDate()
        {
            return this.CreationDate;
        }

        public void SetCreationDate(DateOnly CreationDate)
        {
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
        #endregion
    }
}