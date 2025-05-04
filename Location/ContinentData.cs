using System;

namespace Data.Location
{
    public class ContinentData
    {
        #region Variables
        private ContinentEnum Name { get; set; }
        #endregion

        #region Arrays
        CountryData[] ListOfCountries { get; set; }
        #endregion

        #region Enums
        public enum ContinentEnum
        {
            Africa,
            America,
            Antartica,
            Asia,
            Europe,
            Oceania
        }
        #endregion



        #region Constructor Method
        public ContinentData()
            : base()
        {
            this.Name = ContinentEnum.America;
            this.ListOfCountries = Array.Empty<CountryData>();
        }

        public ContinentData(ContinentEnum Name,
                             CountryData[] ListOfCountries)
            : base()
        {
            this.Name = Name;
            this.ListOfCountries = ListOfCountries;
        }
        #endregion



        #region Destroyer Method
        ~ContinentData()
        {

        }
        #endregion



        #region Getters and Setters
        public ContinentEnum GetName()
        {
            return this.Name;
        }

        public void SetName(ContinentEnum Name)
        {
            this.Name = Name;
        }

        public CountryData[] GetListOfCountries()
        {
            return this.ListOfCountries;
        }

        public void SetListOfCountries(CountryData[] ListOfCountries)
        {
            this.ListOfCountries = ListOfCountries;
        }
        #endregion
    }
}