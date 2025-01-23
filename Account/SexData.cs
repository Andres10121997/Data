using System;

namespace Data.Account
{
    public class SexData
    {
        #region Variables
        private byte? ID { get; set; }
        private string Gender { get; set; }
        #endregion



        #region Constructor Method
        public SexData()
            : base()
        {
            this.ID = null;
            this.Gender = string.Empty;
        }

        public SexData(byte? ID,
                       string Name)
            : base()
        {
            this.ID = ID;
            this.Gender = Name;
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

        public string GetGender()
        {
            return this.Gender;
        }

        public void SetGender(string Gender)
        {
            if (string.IsNullOrEmpty(value: Gender)
                ||
                string.IsNullOrWhiteSpace(value: Gender))
            {
                throw new ArgumentNullException(paramName: nameof(Gender),
                                                message: $"The variable \"{nameof(Gender)}\", of the {nameof(SexData)} class, cannot be null or empty or have blank spaces.");
            }
            
            this.Gender = Gender.Trim();
        }
        #endregion
    }
}