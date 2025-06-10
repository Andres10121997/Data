using System;

namespace Data.Certification
{
    public class CertificateData
    {
        #region Variables
        private string Title { get; set; }
        private uint Folio { get; set; }
        private float Price { get; set; }
        #endregion



        #region Constructor Method
        public CertificateData()
            : base()
        {
            #region Variables
            this.Title = string.Empty;
            this.Folio = uint.MinValue;
            this.Price = float.NaN;
            #endregion
        }

        public CertificateData(string Title,
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
            this.Title = Title.Trim();
            this.Folio = Folio;
            this.Price = Price;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~CertificateData()
        {

        }
        #endregion



        #region Getters and Setters
        public string GetTitle()
        {
            return this.Title;
        }

        public void SetTitle(string Title)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Title);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Title);
            
            this.Title = Title.Trim();
        }

        public uint GetFolio()
        {
            return this.Folio;
        }

        public void SetFolio(uint Folio)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero<uint>(value: Folio);
            
            this.Folio = Folio;
        }

        public float GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(float Price)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<float>(value: Price, other: float.NaN);
            ArgumentOutOfRangeException.ThrowIfNegative<float>(value: Price);
            
            this.Price = Price;
        }
        #endregion
    }
}