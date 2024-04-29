using System;

namespace Data.Location
{
    public class CountryData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Name { get; set; }
        private string Iso { get; set; }
        private string Iso3 { get; set; }
        #endregion

        #region Objects
        private ContinentData OContinent { get; set; }
        #endregion



        #region Constructor Method
        public CountryData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Name = string.Empty;
            this.Iso = string.Empty;
            this.Iso3 = string.Empty;
            this.OContinent = new ContinentData();
        }

        public CountryData(ulong ID,
                           string Name,
                           string Iso,
                           string Iso3,
                           ContinentData OContinent)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
            this.Iso = Iso;
            this.Iso3 = Iso3;
            this.OContinent = OContinent;
        }
        #endregion



        #region Destroyer Method
        ~CountryData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong GetCountryID()
        {
            return this.ID;
        }

        public void SetCountryID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetIso()
        {
            return this.Iso;
        }

        public void SetIso(string Iso)
        {
            if (string.IsNullOrEmpty(Iso)
                ||
                string.IsNullOrWhiteSpace(Iso))
            {
                throw new ArgumentNullException(nameof(Iso), "The Iso cannot be null or empty or have white space.");
            }
            else
            if (Iso.Length < 2)
            {
                throw new Exception(nameof(Iso));
            }
            else
            if (Iso.Length > 2)
            {
                throw new Exception(nameof(Iso));
            }
            
            this.Iso = Iso;
        }

        public string GetIso3()
        {
            return this.Iso3;
        }

        public void SetIso3(string Iso3)
        {
            if (string.IsNullOrEmpty(Iso3)
                ||
                string.IsNullOrWhiteSpace(Iso3))
            {
                throw new ArgumentNullException(nameof(Iso3), "The Iso3 cannot be null or empty or have white space.");
            }
            else
            if (Iso3.Length < 3)
            {
                throw new Exception(nameof(Iso3));
            }
            else
            if (Iso3.Length > 3)
            {
                throw new Exception(nameof(Iso3));
            }
            
            this.Iso3 = Iso3;
        }
        #endregion

        #region Objects
        public ContinentData GetOContinent()
        {
            return this.OContinent;
        }

        public void SetOContinent(ContinentData OContinent)
        {
            this.OContinent = OContinent;
        }
        #endregion
        #endregion
    }
}