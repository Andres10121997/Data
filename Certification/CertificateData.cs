using System;

namespace Data.Certification
{
    public class CertificateData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Title { get; set; }
        private uint Folio { get; set; }
        private float Price { get; set; }
        #endregion



        #region Constructor Method
        public CertificateData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Title = string.Empty;
            this.Folio = uint.MinValue;
            this.Price = float.MinValue;
        }

        public CertificateData(ulong ID,
                               string Title,
                               uint Folio,
                               float Price)
            : base()
        {
            this.ID = ID;
            this.Title = Title;
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
        public ulong GetCertificateID()
        {
            return this.ID;
        }

        public void SetCertificateID(ulong ID)
        {
            if (ID < 0)
            {
                throw new ArithmeticException(message: nameof(ID));
            }
            
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
                throw new ArgumentNullException(paramName: nameof(Title));
            }
            
            this.Title = Title;
        }

        public ulong GetFolio()
        {
            return this.Folio;
        }

        public void SetFolio(uint Folio)
        {
            if (Folio < 0)
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
            
            this.Price = Price;
        }
        #endregion
    }
}