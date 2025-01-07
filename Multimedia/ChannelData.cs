using System;
using System.Threading.Tasks;

namespace Data.Multimedia
{
    public class ChannelData
    {
        #region Variables
        private ulong? ID { get; set; }
        private string Name { get; set; }
        private string? Description { get; set; }
        private DateOnly CreationDate { get; set; }
        private TimeOnly CreationTime { get; set; }
        #endregion

        #region Arrays
        private VideoData[]? VideoList { get; set; }
        #endregion



        #region Constructor Method
        public ChannelData()
            : base()
        {
            this.ID = null;
            this.Name = string.Empty;
            this.Description = null;
            this.CreationDate = new DateOnly();
            this.CreationTime = new TimeOnly();
            this.VideoList = null;
        }

        public ChannelData(ulong? ID,
                           string Name,
                           string? Description,
                           DateOnly CreationDate,
                           TimeOnly CreationTime,
                           VideoData[] VideoList)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.CreationDate = CreationDate;
            this.CreationTime = CreationTime;
            this.VideoList = VideoList;
        }
        #endregion



        #region Destroyer Method
        ~ChannelData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong? GetID()
        {
            return this.ID;
        }
        
        public void SetID(ulong? ID)
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
                throw new ArgumentNullException(paramName: nameof(Name),
                                                message: $"The variable \"{nameof(Name)}\", of the ChannelData class, cannot be null or empty or have blank spaces.");
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

        #region Arrays
        public VideoData[]? GetVideoList()
        {
            return this.VideoList;
        }

        public void SetVideoList(VideoData[]? VideoList)
        {
            this.VideoList = VideoList;
        }
        #endregion
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