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
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Iso);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Iso);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Iso3);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Iso3);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: Numcode);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: PhoneCode);
            #endregion

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
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            
            this.Name = Name.Trim();
        }

        public string GetIso()
        {
            return this.Iso;
        }

        public void SetIso(string Iso)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Iso);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Iso);
            ArgumentOutOfRangeException.ThrowIfNotEqual(value: Iso.Trim().Length, other: 2);
            
            this.Iso = Iso.Trim();
        }

        public string GetIso3()
        {
            return this.Iso3;
        }

        public void SetIso3(string Iso3)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Iso3);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Iso3);
            ArgumentOutOfRangeException.ThrowIfNotEqual(value: Iso3.Trim().Length, other: 3);
            
            this.Iso3 = Iso3.Trim();
        }

        public uint GetNumcode()
        {
            return this.Numcode;
        }

        public void SetNumcode(uint Numcode)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: Numcode);
            
            this.Numcode = Numcode;
        }

        public byte GetPhoneCode()
        {
            return this.PhoneCode;
        }

        public void SetPhoneCode(byte PhoneCode)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: PhoneCode);
            
            this.PhoneCode = PhoneCode;
        }
        #endregion
        #endregion
    }
}