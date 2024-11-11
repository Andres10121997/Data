using System;

namespace Data.Account
{
    public class SexData
    {
        #region Variables
        private byte ID { get; set; }
        private string Gender { get; set; }
        #endregion



        #region Constructor Method
        public SexData()
            : base()
        {
            this.ID = byte.MinValue;
            this.Gender = string.Empty;
        }

        public SexData(byte ID,
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
        public byte GetSexID()
        {
            return this.ID;
        }

        public void SetSexID(byte ID)
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
                                                message: $"\"{nameof(Gender)}\" cannot be null or empty or have whitespace.");
            }
            
            this.Gender = Gender;
        }
        #endregion
    }
}