using System;

namespace Data.Communication.Phone
{
    public sealed class PhoneData
    {
        #region Variables
        private string PhoneNumber { get; set; }
        private PhoneTypeEnum PhoneType { get; set; }
        #endregion

        #region Enum
        public enum PhoneTypeEnum : byte
        {
            None,
            Personal,
            Work
        }
        #endregion



        #region Constructor Method
        public PhoneData()
            : base()
        {
            this.PhoneNumber = string.Empty;
            this.PhoneType = PhoneTypeEnum.None;
        }

        public PhoneData(string PhoneNumber,
                         PhoneTypeEnum PhoneType)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: PhoneNumber);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: PhoneNumber);
            ArgumentOutOfRangeException.ThrowIfZero(value: PhoneNumber.Length);
            #endregion

            #region Variables
            this.PhoneNumber = PhoneNumber.Trim();
            this.PhoneType = PhoneType;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~PhoneData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public void SetPhoneNumber(string PhoneNumber)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: PhoneNumber);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: PhoneNumber);
            ArgumentOutOfRangeException.ThrowIfZero(value: PhoneNumber.Length);
            
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