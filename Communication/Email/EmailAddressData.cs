using System;

namespace Data.Communication.Email
{
    public class EmailAddressData : EmailAddressTypeData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Email { get; set; }
        #endregion



        #region Constructor Method
        public EmailAddressData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Email = string.Empty;
        }

        public EmailAddressData(ulong ID,
                                string Email)
            : base()
        {
            this.ID = ID;
            this.Email = Email.Trim();
        }

        public EmailAddressData(ulong ID,
                                string Email,
                                byte EmailAddressTypeID,
                                string Type)
            : base(ID: EmailAddressTypeID,
                   Type: Type)
        {
            this.ID = ID;
            this.Email = Email.Trim();
        }
        #endregion



        #region Destroyer Method
        ~EmailAddressData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong GetEmailID()
        {
            return ID;
        }

        public void SetEmailID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string Email)
        {
            if (string.IsNullOrEmpty(Email)
                ||
                string.IsNullOrWhiteSpace(Email))
            {
                throw new ArgumentNullException(paramName: nameof(Email),
                                                message: $"The {nameof(Email)} cannot be null or empty or white spaces.");
            }
            
            this.Email = Email;
        }
        #endregion
        #endregion
    }
}