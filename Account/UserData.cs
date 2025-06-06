using Data.Communication.Email;
using Data.Communication.Phone;
using Data.Location;
using System;
using System.Threading.Tasks;

namespace Data.Account
{
    public sealed class UserData : PersonData
    {
        #region Variables
        private string IP { get; set; }
        private string Login { get; set; }
        private string Username { get; set; }
        private DateOnly CreationDate { get; set; }
        private TimeOnly CreationTime { get; set; }
        #endregion

        #region Objects
        private EmailAddressData EmailAddress { get; set; }
        private PhoneData Phone { get; set; }
        private CountryData Country { get; set; }
        #endregion



        #region Constructor Method
        public UserData()
            : base()
        {
            #region Variables
            this.IP = string.Empty;
            this.Login = string.Empty;
            this.Username = string.Empty;
            this.CreationDate = new DateOnly();
            this.CreationTime = new TimeOnly();
            #endregion

            #region Objects
            this.EmailAddress = new EmailAddressData();
            this.Phone = new PhoneData();
            this.Country = new CountryData();
            #endregion
        }

        public UserData(string IP,
                        string Login,
                        string Username,
                        DateOnly CreationDate,
                        TimeOnly CreationTime,
                        EmailAddressData EmailAddress,
                        PhoneData Phone,
                        CountryData Country)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: IP);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Login);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Username);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: IP);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Login);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Username);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.IP = IP.Trim();
            this.Login = Login.Trim();
            this.Username = Username.Trim();
            this.CreationDate = CreationDate;
            this.CreationTime = CreationTime;
            #endregion

            #region Objects
            this.EmailAddress = EmailAddress;
            this.Phone = Phone;
            this.Country = Country;
            #endregion
        }

        public UserData(string FirstName,
                        string? MiddleName,
                        string FirstLastName,
                        string? SecondLastName,
                        DateOnly BirthDate,
                        SexEnum Sex,
                        string IP,
                        string Login,
                        string Username,
                        DateOnly CreationDate,
                        TimeOnly CreationTime,
                        EmailAddressData EmailAddress,
                        PhoneData Phone,
                        CountryData Country)
            : base(FirstName: FirstName.Trim(),
                   MiddleName: MiddleName?.Trim(),
                   FirstLastName: FirstLastName.Trim(),
                   SecondLastName: SecondLastName?.Trim(),
                   BirthDate: BirthDate,
                   Sex: Sex)
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: IP);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Login);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Username);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: IP);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Login);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Username);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.IP = IP.Trim();
            this.Login = Login.Trim();
            this.Username = Username.Trim();
            this.CreationDate = CreationDate;
            this.CreationTime = CreationTime;
            #endregion

            #region Objects
            this.EmailAddress = EmailAddress;
            this.Phone = Phone;
            this.Country = Country;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~UserData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string GetIP()
        {
            return this.IP;
        }

        public void SetIP(string IP)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: IP);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: IP);
            
            this.IP = IP.Trim();
        }

        public string GetLogin()
        {
            return this.Login;
        }

        public void SetLogin(string Login)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Login);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Login);
            
            this.Login = Login.Trim();
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public void SetUsername(string Username)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Username);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Username);
            
            this.Username = Username.Trim();
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
        #endregion

        #region Objects
        public EmailAddressData GetEmailAddress()
        {
            return this.EmailAddress;
        }

        public void SetEmailAddress(EmailAddressData EmailAddress)
        {
            this.EmailAddress = EmailAddress;
        }

        public PhoneData GetPhone()
        {
            return this.Phone;
        }

        public void SetPhone(PhoneData Phone)
        {
            this.Phone = Phone;
        }

        public CountryData GetCountry()
        {
            return this.Country;
        }

        public void SetCountry(CountryData Country)
        {
            this.Country = Country;
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