using System;

namespace Data.Communication.Email
{
    public class EmailAddressData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Email { get; set; }
        #endregion

        #region Objects
        private EmailAddressTypeData EmailAddressType { get; set; }
        #endregion



        #region Constructor Method
        public EmailAddressData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Email = string.Empty;
            this.EmailAddressType = new EmailAddressTypeData();
        }

        public EmailAddressData(ulong ID,
                                string Email,
                                EmailAddressTypeData EmailAddressType)
            : base()
        {
            this.ID = ID;
            this.Email = Email.Trim();
            this.EmailAddressType = EmailAddressType;
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

        #region Objects
        public EmailAddressTypeData GetEmailAddressType()
        {
            return this.EmailAddressType;
        }

        public void SetEmailAddressType(EmailAddressTypeData EmailAddressType)
        {
            this.EmailAddressType = EmailAddressType;
        }
        #endregion
        #endregion
    }
}