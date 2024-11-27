using Data.Communication.Email;
using Data.Communication.Phone;
using Data.Other;
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
        #endregion



        #region Constructor Method
        public UserData()
            : base()
        {
            this.IP = string.Empty;
            this.Login = string.Empty;
            this.Username = string.Empty;
            this.EmailAddress = new EmailAddressData();
            this.Phone = new PhoneData();
        }

        public UserData(string IP,
                        string Login,
                        string Username,
                        EmailAddressData EmailAddress,
                        PhoneData Phone)
            : base()
        {
            this.IP = IP.Trim();
            this.Login = Login.Trim();
            this.Username = Username.Trim();
            this.EmailAddress = EmailAddress;
            this.Phone = Phone;
        }

        public UserData(ulong ID,
                        string FirstName,
                        string? MiddleName,
                        string FirstLastName,
                        string? SecondLastName,
                        DateOnly DateOfBirth,
                        SexData OSex,
                        string IP,
                        string Login,
                        string Username,
                        EmailAddressData EmailAddress,
                        PhoneData Phone)
            : base(ID: ID,
                   FirstName: FirstName.Trim(),
                   MiddleName: MiddleName?.Trim(),
                   FirstLastName: FirstLastName.Trim(),
                   SecondLastName: SecondLastName?.Trim(),
                   DateOfBirth: DateOfBirth,
                   OSex: OSex)
        {
            this.IP = IP.Trim();
            this.Login = Login.Trim();
            this.Username = Username.Trim();
            this.EmailAddress = EmailAddress;
            this.Phone = Phone;
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
                                                message: $"The variable \"{nameof(IP)}\", of the UserData class, cannot be null or empty or have blank spaces.");
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
                                                message: $"The variable \"{nameof(Login)}\", of the UserData class, cannot be null or empty or have blank spaces.");
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
                                                message: $"The variable \"{nameof(Login)}\", of the UserData class, cannot be null or empty or have blank spaces.");
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
        #endregion
        #endregion
    }
}