namespace Data.Communication
{
    public class PhoneData
    {
        #region Variables
        private ulong ID { get; set; }
        private string PhoneNumber { get; set; }
        private string Type { get; set; }
        #endregion



        #region Constructor Method
        public PhoneData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.PhoneNumber = string.Empty;
            this.Type = string.Empty;
        }

        public PhoneData(ulong ID,
                         string PhoneNumber,
                         string Type)
            : base()
        {
            this.ID = ID;
            this.PhoneNumber = PhoneNumber;
            this.Type = Type;
        }
        #endregion



        #region Destroyer Method
        ~PhoneData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong GetID()
        {
            return this.ID;
        }

        public void SetID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public void SetPhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
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