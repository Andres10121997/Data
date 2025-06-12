using System;

namespace Data.Certification
{
    public class CertificateDTO
    {
        #region Variables
        private string V_Title;
        private uint V_Folio;
        private float V_Price;
        #endregion



        #region Constructor Method
        public CertificateDTO()
            : base()
        {
            #region Variables
            this.V_Title = string.Empty;
            this.V_Folio = uint.MinValue;
            this.V_Price = float.NaN;
            #endregion
        }

        public CertificateDTO(string Title,
                               uint Folio,
                               float Price)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Title);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Title);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero<uint>(value: Folio);
            ArgumentOutOfRangeException.ThrowIfEqual<float>(value: Price, other: float.NaN);
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: Price);
            #endregion

            #region Variables
            this.V_Title = Title.Trim();
            this.V_Folio = Folio;
            this.V_Price = Price;
            #endregion
        }
        #endregion



        #region Getters and Setters
        public string Title
        {
            get => this.V_Title.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Title = value.Trim();
            }
        }

        public uint Folio
        {
            get => this.V_Folio;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<uint>(value: value);

                this.V_Folio = value;
            }
        }

        public float Price
        {
            get => this.V_Price;
            set
            {
                ArgumentOutOfRangeException.ThrowIfEqual<float>(
                    value: value,
                    other: float.NaN
                );
                ArgumentOutOfRangeException.ThrowIfNegative<float>(value: value);

                this.V_Price = value;
            }
        }
        #endregion
    }
}