using System;

namespace Data.Account
{
    public class SexData
    {
        #region Variables
        private byte? ID { get; set; }
        private string Sex { get; set; }
        #endregion



        #region Constructor Method
        public SexData()
            : base()
        {
            this.ID = null;
            this.Sex = string.Empty;
        }

        public SexData(byte? ID,
                       string Sex)
            : base()
        {
            this.ID = ID;
            this.Sex = Sex;
        }
        #endregion



        #region Destroyer Method
        ~SexData()
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

        public string GetSex()
        {
            return this.Sex;
        }

        public void SetSex(string Sex)
        {
            if (string.IsNullOrEmpty(value: Sex)
                ||
                string.IsNullOrWhiteSpace(value: Sex))
            {
                throw new ArgumentNullException(paramName: nameof(Sex),
                                                message: $"The variable \"{nameof(Sex)}\", of the {nameof(SexData)} class, cannot be null or empty or have blank spaces.");
            }
            
            this.Sex = Sex.Trim();
        }
        #endregion
    }
}