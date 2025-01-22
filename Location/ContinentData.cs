using System;

namespace Data.Location
{
    public class ContinentData
    {
        #region Variables
        private byte? ID { get; set; }
        private string Name { get; set; }
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
            this.ID = null;
            this.Name = string.Empty;
        }

        public ContinentData(byte? ID,
                             string Name)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
        }
        #endregion



        #region Destroyer Method
        ~ContinentData()
        {

        }
        #endregion



        #region Getters and Setters
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
                                                message: $"The variable \"{nameof(Name)}\", of the ContinentData class, cannot be null or empty or have blank spaces.");
            }
            
            this.Name = Name.Trim();
        }
        #endregion
    }
}