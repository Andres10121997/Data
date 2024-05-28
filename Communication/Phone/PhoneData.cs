namespace Data.Communication.Phone
{
    public class PhoneData : PhoneTypeData
    {
        #region Variables
        private ulong ID { get; set; }
        private string PhoneNumber { get; set; }
        #endregion



        #region Constructor Method
        public PhoneData()
            : base()
        {
            ID = ulong.MinValue;
            PhoneNumber = string.Empty;
        }

        public PhoneData(ulong ID,
                         string PhoneNumber)
            : base()
        {
            this.ID = ID;
            this.PhoneNumber = PhoneNumber;
        }

        public PhoneData(ulong ID,
                         string PhoneNumber,
                         byte PhoneTypeID,
                         string Type)
            : base(ID: PhoneTypeID,
                   Type: Type)
        {
            this.ID = ID;
            this.PhoneNumber = PhoneNumber;
        }
        #endregion



        #region Destroyer Method
        ~PhoneData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong GetPhoneID()
        {
            return ID;
        }

        public void SetPhoneID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public void SetPhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        #endregion
    }
}