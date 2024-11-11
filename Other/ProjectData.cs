using System;

namespace Data.Other
{
    public class ProjectData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Name { get; set; }
        private string? Description { get; set; }
        private DateOnly CreationDate { get; set; }
        #endregion



        #region Constructor methods
        public ProjectData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Name = string.Empty;
            this.Description = null;
            this.CreationDate = new DateOnly();
        }

        public ProjectData(ulong ID,
                           string Name,
                           string? Description,
                           DateOnly CreationDate)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.CreationDate = CreationDate;
        }
        #endregion



        #region Destructor methods
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
            if (string.IsNullOrEmpty(value: Name)
                ||
                string.IsNullOrWhiteSpace(value: Name))
            {
                throw new ArgumentNullException(paramName: nameof(Name));
            }
            
            this.Name = Name.Trim();
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
            if (CreationDate > DateOnly.FromDateTime(dateTime: DateTime.Now))
            {
                throw new Exception();
            }
            
            this.CreationDate = CreationDate;
        }
        #endregion
    }
}