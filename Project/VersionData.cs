using System;
using System.Threading.Tasks;

namespace Data.Project
{
    public class VersionData
    {
        #region Variables
        private byte MainVersion { get; set; }
        private byte SecondaryVersion { get; set; }
        private byte TertiaryVersion { get; set; }
        private string Description { get; set; }
        private DateOnly UpdateDate { get; set; }
        private TimeOnly UpdateTime { get; set; }
        #endregion



        #region Constructor Methods
        public VersionData()
            : base()
        {
            this.MainVersion = 0;
            this.SecondaryVersion = 0;
            this.TertiaryVersion = 0;
            this.Description = string.Empty;
            this.UpdateDate = new DateOnly();
            this.UpdateTime = new TimeOnly();
        }

        public VersionData(byte MainVersion,
                           byte SecondaryVersion,
                           byte TertiaryVersion,
                           string Description,
                           DateOnly UpdateDate,
                           TimeOnly UpdateTime)
            : base()
        {
            this.MainVersion = MainVersion;
            this.SecondaryVersion = SecondaryVersion;
            this.TertiaryVersion = TertiaryVersion;
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
        public byte GetMainVersion()
        {
            return this.MainVersion;
        }

        public void SetMainVersion(byte MainVersion)
        {
            if (MainVersion < 0)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(MainVersion),
                                                      message: $"El parámetro {nameof(MainVersion)}, de la clase {nameof(VersionData)}, no puede ser menor que 0.");
            }
            
            this.MainVersion = MainVersion;
        }

        public byte GetSecondaryVersion()
        {
            return this.SecondaryVersion;
        }

        public void SetSecondaryVersion(byte SecondaryVersion)
        {
            if (SecondaryVersion < 0)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(SecondaryVersion),
                                                      message: $"El parámetro {nameof(SecondaryVersion)}, de la clase {nameof(VersionData)}, no puede ser menor que 0.");
            }
            
            this.SecondaryVersion = SecondaryVersion;
        }

        public byte GetTertiaryVersion()
        {
            return this.TertiaryVersion;
        }

        public void SetTertiaryVersion(byte TertiaryVersion)
        {
            if (TertiaryVersion < 0)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(TertiaryVersion),
                                                      message: $"El parámetro {nameof(TertiaryVersion)}, de la clase {nameof(VersionData)}, no puede ser menor que 0.");
            }
            
            this.TertiaryVersion = TertiaryVersion;
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



        #region To
        public override string ToString()
        {
            return $"{this.MainVersion}.{this.SecondaryVersion}.{this.TertiaryVersion}";
        }

        public DateTime ToUpdateDateTime()
        {
            DateTime dt;

            dt = this.UpdateDate.ToDateTime(time: this.UpdateTime);

            return dt;
        }

        public async Task<DateTime> ToUpdateDateTimeAsync()
        {
            return await Task.Run<DateTime>(function: () => this.ToUpdateDateTime());
        }
        #endregion
    }
}