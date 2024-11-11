using System;

namespace Data.Location
{
    public class ContinentData
    {
        #region Variables
        private byte ID { get; set; }
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
            this.ID = byte.MinValue;
            this.Name = string.Empty;
        }

        public ContinentData(byte ID,
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
        public byte GetContinentID()
        {
            return this.ID;
        }

        public void SetContinentID(byte ID)
        {
            this.ID = ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name)
                ||
                string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(paramName: nameof(Name),
                                                message: "The Name cannot be null or empty or white spaces.");
            }
            
            this.Name = Name;
        }
        #endregion
    }
}