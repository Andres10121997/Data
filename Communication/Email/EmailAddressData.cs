namespace Data.Communication.Email
{
    public class EmailAddressData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Email { get; set; }
        #endregion

        #region Objects
        private EmailAddressTypeData OEmailAddressType { get; set; }
        #endregion



        #region Constructor Method
        public EmailAddressData()
            : base()
        {
            ID = ulong.MinValue;
            Email = string.Empty;
            this.OEmailAddressType = new EmailAddressTypeData();
        }

        public EmailAddressData(ulong ID,
                                string Email,
                                EmailAddressTypeData OEmailAddressType)
            : base()
        {
            this.ID = ID;
            this.Email = Email;
            this.OEmailAddressType = OEmailAddressType;
        }
        #endregion



        #region Destroyer Method
        ~EmailAddressData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong GetID()
        {
            return ID;
        }

        public void SetID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string Email)
        {
            this.Email = Email;
        }
        #endregion

        #region Objects
        public EmailAddressTypeData GetOEmailAddressType()
        {
            return this.OEmailAddressType;
        }

        public void SetEmailType(EmailAddressTypeData OEmailAddressType)
        {
            this.OEmailAddressType = OEmailAddressType;
        }
        #endregion
        #endregion
    }
}