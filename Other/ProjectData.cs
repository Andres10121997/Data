namespace Data.Other
{
    public class ProjectData
    {
        #region Variables
        private ulong ID { get; set; }
        private string Name { get; set; }
        private string? Description { get; set; }
        #endregion



        #region Constructor methods
        public ProjectData()
            : base()
        {
            this.ID = ulong.MinValue;
            this.Name = string.Empty;
            this.Description = null;
        }

        public ProjectData(ulong ID,
                           string Name,
                           string? Description)
            : base()
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }
        #endregion



        #region Destructor methods
        ~ProjectData()
        {

        }
        #endregion



        #region Getters and Setters
        public ulong GetProjectID()
        {
            return this.ID;
        }

        public void SetProjectID(ulong ID)
        {
            this.ID = ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string? GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string? Description)
        {
            this.Description = Description;
        }
        #endregion
    }
}