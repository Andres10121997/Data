namespace Data.Communication.Phone
{
    public class PhoneTypeData
    {
        #region Variables
        private byte ID { get; set; }
        private string Type { get; set; }
        #endregion



        #region Constructor Method
        public PhoneTypeData()
            : base()
        {
            this.ID = byte.MinValue;
            this.Type = string.Empty;
        }

        public PhoneTypeData(byte ID,
                             string Type)
            : base()
        {
            this.ID = ID;
            this.Type = Type;
        }
        #endregion



        #region Destroyer Method
        ~PhoneTypeData()
        {

        }
        #endregion



        #region Getters and Setters
        public byte GetPhoneTypeID()
        {
            return this.ID;
        }

        public void SetPhoneTypeID(byte ID)
        {
            this.ID = ID;
        }

        public string GetPhoneType()
        {
            return this.Type;
        }

        public void SetPhoneType(string Type)
        {
            this.Type = Type;
        }
        #endregion
    }
}