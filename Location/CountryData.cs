using System;

namespace Data.Location
{
    public class CountryData
    {
        #region Variables
        private byte? ID { get; set; }
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
            #region Variables
            this.ID = null;
            this.Name = string.Empty;
            this.Iso = string.Empty;
            this.Iso3 = string.Empty;
            #endregion

            #region Objects
            this.OContinent = new ContinentData();
            #endregion
        }

        public CountryData(byte? ID,
                           string Name,
                           string Iso,
                           string Iso3,
                           ContinentData OContinent)
            : base()
        {
            #region Variables
            this.ID = ID;
            this.Name = Name.Trim();
            this.Iso = Iso.Trim();
            this.Iso3 = Iso3.Trim();
            #endregion

            #region Objects
            this.OContinent = OContinent;
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
        public byte? GetID()
        {
            return this.ID;
        }

        public void SetID(byte? ID)
        {
            this.ID = ID;
        }

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
                                                message: $"The variable \"{nameof(Name)}\", of the ${nameof(CountryData)} class, cannot be null or empty or have blank spaces.");
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
                                                message: $"The variable \"{nameof(Iso)}\", of the ${nameof(CountryData)} class, cannot be null or empty or have blank spaces.");
            }
            else
            if (Iso.Length < 2)
            {
                throw new Exception(message: nameof(Iso));
            }
            else
            if (Iso.Length > 2)
            {
                throw new Exception(message: nameof(Iso));
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
                                                message: $"The variable \"{nameof(Iso3)}\", of the ${nameof(CountryData)} class, cannot be null or empty or have blank spaces.");
            }
            else
            if (Iso3.Length < 3)
            {
                throw new Exception(message: nameof(Iso3));
            }
            else
            if (Iso3.Length > 3)
            {
                throw new Exception(message: nameof(Iso3));
            }
            
            this.Iso3 = Iso3.Trim();
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