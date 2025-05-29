using System;

namespace Data.Location
{
    public class CountryData
    {
        #region Variables
        private string Name { get; set; }
        private string Iso { get; set; }
        private string Iso3 { get; set; }
        private uint Numcode { get; set; }
        private byte PhoneCode { get; set; }
        #endregion



        #region Constructor Method
        public CountryData()
            : base()
        {
            #region Variables
            this.Name = string.Empty;
            this.Iso = string.Empty;
            this.Iso3 = string.Empty;
            this.Numcode = uint.MinValue;
            this.PhoneCode = byte.MinValue;
            #endregion
        }

        public CountryData(string Name,
                           string Iso,
                           string Iso3,
                           uint Numcode,
                           byte PhoneCode)
            : base()
        {
            #region Variables
            this.Name = Name.Trim();
            this.Iso = Iso.Trim();
            this.Iso3 = Iso3.Trim();
            this.Numcode = Numcode;
            this.PhoneCode = PhoneCode;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~CountryData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(value: Name)
                ||
                string.IsNullOrWhiteSpace(value: Name))
            {
                throw new ArgumentNullException(paramName: nameof(Name),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Name), ClassName: nameof(CountryData)));
            }
            
            this.Name = Name.Trim();
        }

        public string GetIso()
        {
            return this.Iso;
        }

        public void SetIso(string Iso)
        {
            if (string.IsNullOrEmpty(value: Iso)
                ||
                string.IsNullOrWhiteSpace(value: Iso))
            {
                throw new ArgumentNullException(paramName: nameof(Iso),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Iso), ClassName: nameof(CountryData)));
            }
            else
            if (Iso.Trim().Length != 2)
            {
                throw new ArgumentOutOfRangeException(message: $"The parameter '{nameof(Iso)}' from the class '{nameof(CountryData)}' must be 3 characters long.",
                                                      paramName: nameof(Iso));
            }
            
            this.Iso = Iso.Trim();
        }

        public string GetIso3()
        {
            return this.Iso3;
        }

        public void SetIso3(string Iso3)
        {
            if (string.IsNullOrEmpty(value: Iso3)
                ||
                string.IsNullOrWhiteSpace(value: Iso3))
            {
                throw new ArgumentNullException(paramName: nameof(Iso3),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Iso3), ClassName: nameof(CountryData)));
            }
            else
            if (Iso3.Trim().Length != 3)
            {
                throw new ArgumentOutOfRangeException(message: $"The parameter '{nameof(Iso3)}' from the class '{nameof(CountryData)}' must be 3 characters long.",
                                                      paramName: nameof(Iso3));
            }
            
            this.Iso3 = Iso3.Trim();
        }

        public uint GetNumcode()
        {
            return this.Numcode;
        }

        public void SetNumcode(uint Numcode)
        {
            this.Numcode = Numcode;
        }

        public byte GetPhoneCode()
        {
            return this.PhoneCode;
        }

        public void SetPhoneCode(byte PhoneCode)
        {
            this.PhoneCode = PhoneCode;
        }
        #endregion
        #endregion
    }
}