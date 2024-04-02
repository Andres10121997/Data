namespace Data.Certification
{
    public class CertificateData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Title { get; set; }
        private ulong Folio { get; set; }
        private float Price { get; set; }
        #endregion



        #region Constructor Method
        public CertificateData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Title = string.Empty;
            this.Folio = ulong.MinValue;
            this.Price = float.MinValue;
        }

        public CertificateData(ulong ID,
                               string Title,
                               ulong Folio,
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
            this.ID = ID;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public void SetTitle(string Title)
        {
            this.Title = Title;
        }

        public ulong GetFolio()
        {
            return this.Folio;
        }

        public void SetFolio(ulong Folio)
        {
            this.Folio = Folio;
        }

        public float GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(float Price)
        {
            this.Price = Price;
        }
        #endregion
    }
}