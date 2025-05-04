namespace Data.Transport
{
    public class VehicleData
    {
        #region Variables
        private byte? ID { get; set; }
        private byte NumberOfDoors { get; set; }
        private byte NumberOfWheels { get; set; }
        private ushort OverallLength { get; set; } // Longitud general
        private ushort OverallWidth { get; set; } // Anchura general
        private ushort OverallHeight { get; set; } // Altura general
        #endregion



        #region Constructor methods
        public VehicleData()
            : base()
        {
            this.ID = null;
            this.NumberOfDoors = byte.MinValue;
            this.NumberOfWheels = byte.MinValue;
            this.OverallLength = ushort.MinValue;
            this.OverallWidth = ushort.MinValue;
            this.OverallHeight = ushort.MinValue;
        }

        public VehicleData(byte? ID,
                           byte NumberOfDoors,
                           byte NumberOfWheels,
                           ushort OverallLength,
                           ushort OverallWidth,
                           ushort OverallHeight)
            : base()
        {
            this.ID = ID;
            this.NumberOfDoors = NumberOfDoors;
            this.NumberOfWheels = NumberOfWheels;
            this.OverallLength = OverallLength;
            this.OverallWidth = OverallWidth;
            this.OverallHeight = OverallHeight;
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

        public ushort GetOverallLength()
        {
            return this.OverallLength;
        }

        public void SetOverallLength(byte OverallLength)
        {
            this.OverallLength = OverallLength;
        }

        public ushort GetOverallWidth()
        {
            return this.OverallWidth;
        }

        public void SetOverallWidth(ushort OverallWidth)
        {
            this.OverallWidth = OverallWidth;
        }

        public ushort GetOverallHeight()
        {
            return this.OverallHeight;
        }

        public void SetOverallHeight(ushort OverallHeight)
        {
            this.OverallHeight = OverallHeight;
        }
        #endregion
    }
}