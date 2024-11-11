using System;

namespace Data.Multimedia
{
    public class VideoData
    {
        #region Variables
        private string Title { get; set; }
        private string? Description { get; set; }
        private DateOnly UploadDate { get; set; }
        private TimeOnly UploadTime { get; set; }
        #endregion

        #region Array
        private byte[] Video { get; set; }
        #endregion



        #region Constructor Method
        public VideoData()
            : base()
        {
            this.Title = string.Empty;
            this.Description = null;
            this.UploadDate = new DateOnly();
            this.UploadTime = new TimeOnly();
            this.Video = Array.Empty<byte>();
        }

        public VideoData(string Title,
                         string? Description,
                         DateOnly UploadDate,
                         TimeOnly UploadTime,
                         byte[] Video)
            : base()
        {
            this.Title = Title;
            this.Description = Description;
            this.UploadDate = UploadDate;
            this.UploadTime = UploadTime;
            this.Video = Video;
        }
        #endregion



        #region Destroyer Method
        ~VideoData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string GetTitle()
        {
            return this.Title;
        }

        public void SetTitle(string Title)
        {
            if (string.IsNullOrEmpty(value: Title)
                ||
                string.IsNullOrWhiteSpace(value: Title))
            {
                throw new ArgumentNullException(paramName: nameof(Title),
                                                message: "The video title cannot be null or empty or have empty spaces.");
            }
            
            this.Title = Title.Trim();
        }

        public string? GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string? Description)
        {
            this.Description = Description;
        }

        public DateOnly GetUploadDate()
        {
            return this.UploadDate;
        }

        public void SetUploadDate(DateOnly UploadDate)
        {
            this.UploadDate = UploadDate;
        }

        public TimeOnly GetUploadTime()
        {
            return this.UploadTime;
        }

        public void SetUploadTime(TimeOnly UploadTime)
        {
            this.UploadTime = UploadTime;
        }
        #endregion

        #region Array
        public byte[] GetVideo()
        {
            return this.Video;
        }

        public void SetVideo(byte[] Video)
        {
            this.Video = Video;
        }
        #endregion
        #endregion
    }
}