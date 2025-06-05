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
        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public void SetPhoneNumber(string PhoneNumber)
        {
            if (string.IsNullOrEmpty(value: PhoneNumber)
                ||
                string.IsNullOrWhiteSpace(value: PhoneNumber))
            {
                throw new ArgumentNullException(paramName: nameof(PhoneNumber),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(PhoneNumber), ClassName: nameof(PhoneData)));
            }
            else
            if (PhoneNumber.Trim().Length == 0
                ||
                PhoneNumber.Trim().Length.Equals(obj: 0))
            {
                throw new ArgumentException(message: $"The number of characters in the variable \"{nameof(PhoneNumber)}\", of the class \"{nameof(PhoneData)}\", cannot be 0.",
                                            paramName: nameof(PhoneNumber));
            }
            
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