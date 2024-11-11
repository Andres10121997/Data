namespace Data.Communication.Phone
{
    public class PhoneData
    {
        #region Variables
        private ulong ID { get; set; }
        private string PhoneNumber { get; set; }
        #endregion

        #region Objects
        private PhoneTypeData PhoneType { get; set; }
        #endregion



        #region Constructor Method
        public PhoneData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.PhoneNumber = string.Empty;
            this.PhoneType = new PhoneTypeData();
        }

        public PhoneData(ulong ID,
                         string PhoneNumber,
                         PhoneTypeData PhoneType)
            : base()
        {
            this.ID = ID;
            this.PhoneNumber = PhoneNumber.Trim();
            this.PhoneType = PhoneType;
        }
        #endregion



        #region Destroyer Method
        ~PhoneData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
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
            this.PhoneNumber = PhoneNumber.Trim();
        }
        #endregion

        #region Objects
        public PhoneTypeData GetPhoneType()
        {
            return this.PhoneType;
        }

        public void SetPhoneType(PhoneTypeData PhoneType)
        {
            this.PhoneType = PhoneType;
        }
        #endregion
        #endregion
    }
}