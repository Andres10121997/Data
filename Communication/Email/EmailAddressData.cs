using System;

namespace Data.Communication.Email
{
    public class EmailAddressData
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
        public string GetEmail()
        {
            return this.Email;
        }

        public void SetEmail(string Email)
        {
            if (string.IsNullOrEmpty(value: Email)
                ||
                string.IsNullOrWhiteSpace(value: Email))
            {
                throw new ArgumentNullException(message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Email), ClassName: nameof(EmailAddressData)),
                                                paramName: nameof(Email));
            }
            else
            if (Email.Trim().Length == 0
                ||
                Email.Trim().Length.Equals(obj: 0))
            {
                throw new ArgumentException(message: $"The number of characters in the variable \"{nameof(Email)}\", of the class \"{nameof(EmailAddressData)}\", cannot be 0.",
                                            paramName: nameof(Email));
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