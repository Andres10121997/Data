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
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: Folio);
            ArgumentOutOfRangeException.ThrowIfNegative(value: Price);
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
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: Folio);
            
            this.Folio = Folio;
        }

        public float GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(float Price)
        {
            if (float.IsNaN(f: Price))
            {
                throw new ArithmeticException(message: nameof(Price));
            }

            ArgumentOutOfRangeException.ThrowIfNegative(value: Price);
            
            this.Price = Price;
        }
        #endregion
    }
}