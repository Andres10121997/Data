using System;

namespace Data.Human_Resources
{
    public class JobData
    {
        #region Variables
        private byte ID { get; set; }
        private string Name { get; set; }
        #endregion



        #region Constructor Method
        public JobData()
            : base()
        {
            this.ID = byte.MinValue;
            this.Name = string.Empty;
        }

        public JobData(byte ID,
                       string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        #endregion



        #region Destroyer Method
        ~JobData()
        {

        }
        #endregion



        #region Getters and Setters
        public byte GetID()
        {
            return this.ID;
        }

        public void SetID(byte ID)
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
                throw new ArgumentNullException(paramName: nameof(Name));
            }
            
            this.Name = Name;
        }
        #endregion
    }
}