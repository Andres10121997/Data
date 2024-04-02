namespace Data.Communication.Email
{
    public class EmailAddressTypeData
    {
        #region Variables
        private byte ID { get; set; }
        private EmailTypeEnum Type { get; set; }
        #endregion

        #region Enums
        public enum EmailTypeEnum
        {
            Personal,
            Work,
            University,
            School
        }
        #endregion



        public EmailAddressTypeData()
            : base()
        {
            this.ID = byte.MinValue;
            this.Type = EmailTypeEnum.Personal;
        }

        public EmailAddressTypeData(byte ID,
                                    EmailTypeEnum Type)
        {
            this.ID = ID;
            this.Type = Type;
        }



        ~EmailAddressTypeData()
        {

        }



        public byte GetEmailTypeID()
        {
            return this.ID;
        }

        public void SetEmailTypeID(byte ID)
        {
            this.ID = ID;
        }

        public EmailTypeEnum GetEmailType()
        {
            return this.Type;
        }

        public void SetEmailType(EmailTypeEnum Type)
        {
            this.Type = Type;
        }
    }
}