namespace Data.Communication.Phone
{
    public class PhoneData
    {
        #region Variables
        private ulong ID { get; set; }
        private string PhoneNumber { get; set; }
        private PhoneTypeEnum PhoneType { get; set; }
        #endregion

        #region Enum
        public enum PhoneTypeEnum : byte
        {
            Personal,
            Work
        }
        #endregion



        #region Constructor Method
        public PhoneData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.PhoneNumber = string.Empty;
            this.PhoneType = PhoneTypeEnum.Personal;
        }

        public PhoneData(ulong ID,
                         string PhoneNumber,
                         PhoneTypeEnum PhoneType)
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
            return this.ID;
        }

        public void SetPhoneID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public void SetPhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber.Trim();
        }

        public PhoneTypeEnum GetPhoneType()
        {
            return this.PhoneType;
        }

        public void SetPhoneType(PhoneTypeEnum PhoneType)
        {
            this.PhoneType = PhoneType;
        }
        #endregion
        #endregion
    }
}