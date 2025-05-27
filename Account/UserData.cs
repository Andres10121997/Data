using Data.Communication.Email;
using Data.Communication.Phone;
using Data.Location;
using System;

namespace Data.Account
{
    public class UserData : PersonData
    {
        #region Variables
        private string IP { get; set; }
        private string Login { get; set; }
        private string Username { get; set; }
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
                        EmailAddressData EmailAddress,
                        PhoneData Phone,
                        CountryData Country)
            : base()
        {
            #region Variables
            this.IP = IP.Trim();
            this.Login = Login.Trim();
            this.Username = Username.Trim();
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
            #region Variables
            this.IP = IP.Trim();
            this.Login = Login.Trim();
            this.Username = Username.Trim();
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
            if (string.IsNullOrEmpty(value: IP)
                ||
                string.IsNullOrWhiteSpace(value: IP))
            {
                throw new ArgumentNullException(paramName: nameof(IP),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(IP), ClassName: nameof(UserData)));
            }
            
            this.IP = IP.Trim();
        }

        public string GetLogin()
        {
            return this.Login;
        }

        public void SetLogin(string Login)
        {
            if (string.IsNullOrEmpty(value: Login)
                ||
                string.IsNullOrWhiteSpace(value: Login))
            {
                throw new ArgumentNullException(paramName: nameof(Login),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Login), ClassName: nameof(UserData)));
            }
            
            this.Login = Login.Trim();
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public void SetUsername(string Username)
        {
            if (string.IsNullOrEmpty(value: Username)
                ||
                string.IsNullOrWhiteSpace(value: Username))
            {
                throw new ArgumentNullException(paramName: nameof(Username),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Username), ClassName: nameof(UserData)));
            }
            
            this.Username = Username.Trim();
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
    }
}