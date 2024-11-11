using System;

namespace Data.Human_Resources
{
    public class DepartmentData
    {
        #region Variables
        private byte ID { get; set; }
        private string Name { get; set; }
        private string? Description { get; set; }
        #endregion

        #region Enum
        public enum TypeOfDepartment
        {
            Department,
            Subdepartment
        }
        #endregion



        #region Constructor Method
        public DepartmentData()
            : base()
        {
            this.ID = byte.MinValue;
            this.Name = string.Empty;
            this.Description = null;
        }

        public DepartmentData(byte ID,
                              string Name,
                              string? Description)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }
        #endregion



        #region Destroyer Method
        ~DepartmentData()
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
            
            this.Name = Name.Trim();
        }

        public string? GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string? Description)
        {
            this.Description = Description?.Trim();
        }
        #endregion
    }
}