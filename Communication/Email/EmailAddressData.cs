using System;

namespace Data.Communication.Email
{
    public class EmailAddressData
    {
        #region Variables
        private ulong? ID { get; set; }
        private string Email { get; set; }
        private EmailAddressTypeEnum EmailType { get; set; }
        #endregion

        #region Enum
        public enum EmailAddressTypeEnum : byte
        {
            None,
            Educational,
            Personal,
            Work
        }
        #endregion



        #region Constructor Method
        public EmailAddressData()
            : base()
        {
            this.ID = null;
            this.Email = string.Empty;
            this.EmailType = EmailAddressTypeEnum.None;
        }

        public EmailAddressData(ulong? ID,
                                string Email,
                                EmailAddressTypeEnum EmailType)
            : base()
        {
            this.ID = ID;
            this.Email = Email.Trim();
            this.EmailType = EmailType;
        }
        #endregion



        #region Destroyer Method
        ~EmailAddressData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong? GetID()
        {
            return ID;
        }

        public void SetID(ulong? ID)
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
                                                message: $"The variable \"{nameof(Email)}\", of the EmailAddressData class, cannot be null or empty or have blank spaces.");
            }
            
            this.Email = Email.Trim();
        }

        public EmailAddressTypeEnum GetEmailType()
        {
            return this.EmailType;
        }

        public void SetEmailType(EmailAddressTypeEnum EmailType)
        {
            this.EmailType = EmailType;
        }
        #endregion
        #endregion
    }
}