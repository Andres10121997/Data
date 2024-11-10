using Data.Other;
using System;

namespace Data.Account
{
    public class UserData : PersonData
    {
        #region Variables
        private ulong ID { get; set; }
        private string IP { get; set; }
        private string Login { get; set; }
        private string Username { get; set; }
        #endregion



        #region Constructor Method
        public UserData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.IP = string.Empty;
            this.Login = string.Empty;
            this.Username = string.Empty;
        }

        public UserData(ulong ID,
                        string IP,
                        string Login,
                        string Username)
            : base()
        {
            this.ID = ID;
            this.IP = IP;
            this.Login = Login;
            this.Username = Username;
        }

        public UserData(ulong PersonID,
                        string FirstName,
                        string? MiddleName,
                        string FirstLastName,
                        string? SecondLastName,
                        DateOnly DateOfBirth,
                        SexData OSex,
                        ulong UserID,
                        string IP,
                        string Login,
                        string Username)
            : base(ID: PersonID,
                   FirstName: FirstName,
                   MiddleName: MiddleName,
                   FirstLastName: FirstLastName,
                   SecondLastName: SecondLastName,
                   DateOfBirth: DateOfBirth,
                   OSex: OSex)
        {
            this.ID = UserID;
            this.IP = IP;
            this.Login = Login;
            this.Username = Username;
        }
        #endregion



        #region Destroyer Method
        ~UserData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong GetUserID()
        {
            return this.ID;
        }

        public void SetUserID(ulong ID)
        {
            this.ID = ID;
        }
        
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
                throw new ArgumentNullException(paramName: nameof(IP));
            }
            
            this.IP = IP;
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
                throw new ArgumentNullException(paramName: nameof(Login));
            }
            
            this.Login = Login;
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
                throw new ArgumentNullException(paramName: nameof(Username));
            }
            
            this.Username = Username;
        }
        #endregion
    }
}