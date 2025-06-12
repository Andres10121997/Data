using System;

namespace Data.Location
{
    public sealed class ContinentDTO
    {
        #region Variables
        private ContinentEnum V_Name;
        #endregion

        #region Arrays
        CountryDTO[] A_ListOfCountries;
        #endregion

        #region Enums
        public enum ContinentEnum : byte
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
        public ContinentDTO()
            : base()
        {
            this.V_Name = ContinentEnum.America;
            this.A_ListOfCountries = Array.Empty<CountryDTO>();
        }

        public ContinentDTO(ContinentEnum Name,
                             CountryDTO[] ListOfCountries)
            : base()
        {
            this.V_Name = Name;
            this.A_ListOfCountries = ListOfCountries;
        }
        #endregion



        #region Getters and Setters
        public ContinentEnum Name
        {
            get => this.V_Name;
            set => this.V_Name = value;
        }

        public CountryDTO[] ListOfCountries
        {
            get => this.A_ListOfCountries;
            set => this.A_ListOfCountries = value;
        }
        #endregion
    }
}