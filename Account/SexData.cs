using System;

namespace Data.Account
{
    public class SexData
    {
        #region Variables
        private byte ID { get; set; }
        private string Name { get; set; }
        #endregion



        #region Constructor Method
        public SexData()
            : base()
        {
            this.ID = byte.MinValue;
            this.Name = string.Empty;
        }

        public SexData(byte ID,
                       string Name)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
        }
        #endregion



        #region Destroyer Method
        ~SexData()
        {

        }
        #endregion



        #region Getters and Setters
        public byte GetSexID()
        {
            return this.ID;
        }

        public void SetSexID(byte ID)
        {
            this.ID = ID;
        }

        public string GetSex()
        {
            return this.Name;
        }

        public void SetSex(string Name)
        {
            if (string.IsNullOrEmpty(Name)
                ||
                string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name), "\"Sex\" cannot be null or empty or have whitespace.");
            }
            
            this.Name = Name;
        }
        #endregion
    }
}