using System;

namespace Data.Location
{
    public sealed record CountryData
    {
        #region Variables
        private string V_Name;
        private string V_Iso;
        private string V_Iso3;
        private uint V_Numcode;
        private byte V_PhoneCode;
        #endregion



        #region Constructor Method
        public CountryData()
            : base()
        {
            #region Variables
            this.V_Name = string.Empty;
            this.V_Iso = string.Empty;
            this.V_Iso3 = string.Empty;
            this.V_Numcode = uint.MinValue;
            this.V_PhoneCode = byte.MinValue;
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
            this.V_Name = Name.Trim();
            this.V_Iso = Iso.Trim();
            this.V_Iso3 = Iso3.Trim();
            this.V_Numcode = Numcode;
            this.V_PhoneCode = PhoneCode;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string Name
        {
            get => this.V_Name;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Name = value;
            }
        }

        public string Iso
        {
            get => this.V_Iso;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);
                ArgumentOutOfRangeException.ThrowIfNotEqual(
                    value: value.Trim().Length,
                    other: 2
                );

                this.V_Iso = value;
            }
        }

        public string Iso3
        {
            get => this.V_Iso3;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);
                ArgumentOutOfRangeException.ThrowIfNotEqual(
                    value: value.Trim().Length,
                    other: 3
                );

                this.V_Iso3 = value;
            }
        }

        public uint Numcode
        {
            get => this.V_Numcode;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: value);

                this.V_Numcode = value;
            }
        }

        public byte PhoneCode
        {
            get => this.V_PhoneCode;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: value);

                this.V_PhoneCode = value;
            }
        }
        #endregion
        #endregion
    }
}