using System;

namespace Data.HumanResources
{
    public class DepartmentData
    {
        #region Variables
        private string Name { get; set; }
        private string? Description { get; set; }
        private DepartmentTypeEnum DepartmentType { get; set; }
        #endregion

        #region Enum
        public enum DepartmentTypeEnum
        {
            Department,
            Subdepartment
        }
        #endregion



        #region Constructor Method
        public DepartmentData()
            : base()
        {
            #region Variables
            this.Name = string.Empty;
            this.Description = null;
            #endregion

            #region Enum
            this.DepartmentType = DepartmentTypeEnum.Department;
            #endregion
        }

        public DepartmentData(string Name,
                              string? Description,
                              DepartmentTypeEnum DepartmentType)
            : base()
        {
            #region Variables
            this.Name = Name.Trim();
            this.Description = Description?.Trim();
            #endregion

            #region Enum
            this.DepartmentType = DepartmentType;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~DepartmentData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
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
                                                message: $"The variable \"{nameof(Name)}\", of the {nameof(DepartmentData)} class, cannot be null or empty or have blank spaces.");
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

        #region Enum
        public DepartmentTypeEnum GetDepartmentType()
        {
            return this.DepartmentType;
        }

        public void SetDepartmentType(DepartmentTypeEnum DepartmentType)
        {
            this.DepartmentType = DepartmentType;
        }
        #endregion
        #endregion
    }
}