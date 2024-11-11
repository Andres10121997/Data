namespace Data.Communication.Email
{
    public class EmailAddressTypeData
    {
        #region Variables
        private byte ID { get; set; }
        private string Type { get; set; }
        #endregion



        #region Constructor Method
        public EmailAddressTypeData()
            : base()
        {
            this.ID = byte.MinValue;
            this.Type = string.Empty;
        }

        public EmailAddressTypeData(byte ID,
                                    string Type)
            : base()
        {
            this.ID = ID;
            this.Type = Type.Trim();
        }
        #endregion



        #region Destroyer Method
        ~EmailAddressTypeData()
        {

        }
        #endregion



        #region Getters and Setters
        public byte GetEmailTypeID()
        {
            return this.ID;
        }

        public void SetEmailTypeID(byte ID)
        {
            this.ID = ID;
        }

        public string GetEmailType()
        {
            return this.Type;
        }

        public void SetEmailType(string Type)
        {
            this.Type = Type.Trim();
        }
        #endregion
    }
}