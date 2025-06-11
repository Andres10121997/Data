using System;

namespace Data.Communication.Email
{
    public sealed class EmailAddressData
    {
        #region Variables
        private string V_Email;
        private EmailAddressTypeEnum V_EmailType;
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
            this.V_Email = string.Empty;
            this.V_EmailType = EmailAddressTypeEnum.None;
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
            this.V_Email = Email.Trim();
            this.V_EmailType = EmailType;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string Email
        {
            get => this.V_Email.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);
                ArgumentOutOfRangeException.ThrowIfZero<int>(value: value.Length);

                this.V_Email = value.Trim();
            }
        }

        public EmailAddressTypeEnum EmailType
        {
            get => this.V_EmailType;
            set => this.V_EmailType = value;
        }
        #endregion
        #endregion
    }
}