using System;

namespace Data.Account
{
    public class UsernameData : UserData
    {
        #region Variables
        private ulong ID { get; set; }
        public string Username { get; set; }
        #endregion



        #region Constructor Method
        public UsernameData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Username = string.Empty;
        }

        public UsernameData(ulong ID,
                            string Username)
            : base()
        {
            this.ID = ID;
            this.Username = Username;
        }

        public UsernameData(ulong UserID,
                            string IP,
                            string Login,
                            ulong UsernameID,
                            string Username)
            : base(ID: UserID,
                   IP: IP,
                   Login: Login)
        {
            this.ID = UsernameID;
            this.Username = Username;
        }
        #endregion



        #region Destroyer Method
        ~UsernameData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong GetUsernameID()
        {
            return this.ID;
        }

        public void SetUsernameID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public void SetUsername(string Username)
        {
            if (string.IsNullOrEmpty(Username)
                ||
                string.IsNullOrWhiteSpace(Username))
            {
                throw new ArgumentNullException(paramName: nameof(Username));
            }
            
            this.Username = Username;
        }
        #endregion
    }
}