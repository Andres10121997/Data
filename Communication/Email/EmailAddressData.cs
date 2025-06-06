using System;

namespace Data.Communication.Email
{
    public sealed class EmailAddressData
    {
        #region Variables
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
            this.Email = string.Empty;
            this.EmailType = EmailAddressTypeEnum.None;
        }

        public EmailAddressData(string Email,
                                EmailAddressTypeEnum EmailType)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Email);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Email);
            ArgumentOutOfRangeException.ThrowIfZero(value: Email.Length);
            #endregion

            #region Variables
            this.Email = Email.Trim();
            this.EmailType = EmailType;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~EmailAddressData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string GetEmail()
        {
            return this.Email;
        }

        public void SetEmail(string Email)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Email);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Email);
            ArgumentOutOfRangeException.ThrowIfZero(value: Email.Length);

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