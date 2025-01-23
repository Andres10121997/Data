using System;

namespace Data.Certification
{
    public class CertificateData
    {
        #region Variables
        private ulong? ID { get; set; }
        private string Title { get; set; }
        private nuint Folio { get; set; }
        private float Price { get; set; }
        #endregion



        #region Constructor Method
        public CertificateData()
            : base()
        {
            this.ID = null;
            this.Title = string.Empty;
            this.Folio = nuint.MinValue;
            this.Price = float.MinValue;
        }

        public CertificateData(ulong? ID,
                               string Title,
                               nuint Folio,
                               float Price)
            : base()
        {
            this.ID = ID;
            this.Title = Title.Trim();
            this.Folio = Folio;
            this.Price = Price;
        }
        #endregion



        #region Destroyer Method
        ~CertificateData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong? GetID()
        {
            return this.ID;
        }

        public void SetID(ulong? ID)
        {
            this.ID = ID;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public void SetTitle(string Title)
        {
            if (string.IsNullOrEmpty(value: Title)
                ||
                string.IsNullOrWhiteSpace(value: Title))
            {
                throw new ArgumentNullException(paramName: nameof(Title),
                                                message: $"The variable \"{nameof(Title)}\", of the {nameof(CertificateData)} class, cannot be null or empty or have blank spaces.");
            }
            
            this.Title = Title.Trim();
        }

        public nuint GetFolio()
        {
            return this.Folio;
        }

        public void SetFolio(nuint Folio)
        {
            if (Folio <= 0)
            {
                throw new ArithmeticException(message: nameof(Folio));
            }
            
            this.Folio = Folio;
        }

        public float GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(float Price)
        {
            if (float.IsNegative(f: Price))
            {
                throw new ArithmeticException(message: nameof(Price));
            }
            else
            if (Price < 0)
            {
                throw new ArithmeticException(message: nameof(Price));
            }
            
            this.Price = Price;
        }
        #endregion
    }
}