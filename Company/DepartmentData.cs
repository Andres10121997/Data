using System;

namespace Data.Company
{
    public class DepartmentData
    {
        #region Variables
        private string Name { get; set; }
        private string? Description { get; set; }
        private DepartmentTypeEnum DepartmentType { get; set; }
        #endregion

        #region Objects
        private DepartmentData SubDepartment { get; set; }
        #endregion

        #region Enum
        public enum DepartmentTypeEnum : byte
        {
            Department,
            Subdepartment,
            None
        }
        #endregion



        #region Constructor Method
        public DepartmentData()
            : base()
        {
            #region Variables
            this.Name = string.Empty;
            this.Description = null;
            this.DepartmentType = DepartmentTypeEnum.None;
            #endregion

            #region Objects
            this.SubDepartment = new DepartmentData();
            #endregion
        }

        public DepartmentData(string Name,
                              string? Description,
                              DepartmentTypeEnum DepartmentType,
                              DepartmentData SubDepartment)
            : base()
        {
            #region Variables
            this.Name = Name.Trim();
            this.Description = Description?.Trim();
            this.DepartmentType = DepartmentType;
            #endregion

            #region Objects
            this.SubDepartment = SubDepartment;
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
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Name), ClassName: nameof(DepartmentData)));
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

        public DepartmentTypeEnum GetDepartmentType()
        {
            return this.DepartmentType;
        }

        public void SetDepartmentType(DepartmentTypeEnum DepartmentType)
        {
            this.DepartmentType = DepartmentType;
        }
        #endregion

        #region Objects
        public DepartmentData GetSubDepartment()
        {
            return this.SubDepartment;
        }

        public void SetSubDepartment(DepartmentData SubDepartment)
        {
            this.SubDepartment = SubDepartment;
        }
        #endregion
        #endregion
    }
}