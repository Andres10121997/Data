using System;

namespace Data.Company
{
    public sealed class DepartmentDTO
    {
        #region Variables
        private string V_Name;
        private string? V_Description;
        private DepartmentTypeEnum V_DepartmentType;
        #endregion

        #region Objects
        private DepartmentDTO O_SubDepartment;
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
        public DepartmentDTO()
            : base()
        {
            #region Variables
            this.V_Name = string.Empty;
            this.V_Description = null;
            this.V_DepartmentType = DepartmentTypeEnum.None;
            #endregion

            #region Objects
            this.O_SubDepartment = new DepartmentDTO();
            #endregion
        }

        public DepartmentDTO(string Name,
                              string? Description,
                              DepartmentTypeEnum DepartmentType,
                              DepartmentDTO SubDepartment)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            #endregion

            #region Variables
            this.V_Name = Name.Trim();
            this.V_Description = Description?.Trim();
            this.V_DepartmentType = DepartmentType;
            #endregion

            #region Objects
            this.O_SubDepartment = SubDepartment;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string Name
        {
            get => this.V_Name.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Name = value.Trim();
            }
        }

        public string? Description
        {
            get => this.V_Description?.Trim();
            set => this.V_Description = value?.Trim();
        }

        public DepartmentTypeEnum DepartmentType
        {
            get => this.V_DepartmentType;
            set => this.V_DepartmentType = value;
        }
        #endregion

        #region Objects
        public DepartmentDTO SubDepartment
        {
            get => this.O_SubDepartment;
            set => this.O_SubDepartment = value;
        }
        #endregion
        #endregion
    }
}