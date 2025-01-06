using System;
using System.Threading.Tasks;

namespace Data.Other
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



        #region Constructor methods
        public ProjectData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Name = string.Empty;
            this.Description = null;
            this.CreationDate = new DateOnly();
            this.CreationTime = new TimeOnly();
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
                throw new ArgumentNullException(paramName: nameof(Name),
                                                message: $"The variable \"{nameof(Name)}\", of the ProjectData class, cannot be null or empty or have blank fields.");
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
        #endregion



        #region To
        public DateTime ToCreationDateTime()
        {
            DateTime CreationDateTime = this.CreationDate.ToDateTime(time: this.CreationTime);

            return CreationDateTime;
        }

        public async Task<DateTime> ToCreationDateTimeAsync()
        {
            try
            {
                return await Task.Run<DateTime>(function: () => this.ToCreationDateTime());
            }
            catch (ArgumentNullException ane)
            {
                await Utils.ErrorMessagesAsync(ex: ane, OType: this.GetType());
                
                throw;
            }
        }
        #endregion
    }
}