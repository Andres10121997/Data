namespace Data.Communication.Email
{
    public class EmailAddressData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Email { get; set; }
        private string Type { get; set; }
        #endregion



        #region Constructor Method
        public EmailAddressData()
            : base()
        {
            ID = ulong.MinValue;
            Email = string.Empty;
            Type = string.Empty;
        }

        public EmailAddressData(ulong ID,
                                string Email,
                                string Type)
            : base()
        {
            this.ID = ID;
            this.Email = Email;
            this.Type = Type;
        }
        #endregion



        #region Destroyer Method
        ~EmailAddressData()
        {

        }
        #endregion



        #region Getters and Setters
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

        public string GetEmailType()
        {
            return Type;
        }

        public void SetEmailType(string Type)
        {
            this.Type = Type;
        }
        #endregion
    }
}