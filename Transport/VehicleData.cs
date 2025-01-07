namespace Data.Transport
{
    public class VehicleData
    {
        #region Variables
        private byte? ID { get; set; }
        private byte NumberOfDoors { get; set; }
        private byte NumberOfWheels { get; set; }
        #endregion



        #region Constructor methods
        public VehicleData()
            : base()
        {
            this.ID = null;
            this.NumberOfDoors = byte.MinValue;
            this.NumberOfWheels = byte.MinValue;
        }

        public VehicleData(byte? ID,
                           byte NumberOfDoors,
                           byte NumberOfWheels)
            : base()
        {
            this.ID = ID;
            this.NumberOfDoors = NumberOfDoors;
            this.NumberOfWheels = NumberOfWheels;
        }
        #endregion



        #region Destructor methods
        ~VehicleData()
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

        public byte GetNumberOfDoors()
        {
            return this.NumberOfDoors;
        }

        public void SetNumberOfDoors(byte NumberOfDoors)
        {
            this.NumberOfDoors = NumberOfDoors;
        }

        public byte GetNumberOfWheels()
        {
            return this.NumberOfWheels;
        }

        public void SetNumberOfWheels(byte NumberOfWheels)
        {
            this.NumberOfWheels = NumberOfWheels;
        }
        #endregion
    }
}