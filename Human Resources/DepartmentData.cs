namespace Data.Human_Resources
{
    public class DepartmentData
    {
        #region Variables
        private string Name { get; set; }
        #endregion



        #region Constructor Method
        public DepartmentData()
            : base()
        {
            this.Name = string.Empty;
        }

        public DepartmentData(string Name)
            : base()
        {
            this.Name = Name;
        }
        #endregion



        #region Destroyer Method
        ~DepartmentData()
        {

        }
        #endregion



        #region Getters and Setters
        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name.Trim();
        }
        #endregion
    }
}