namespace Data.Property
{
    public class HomeData : PropertyData
    {
        #region Variables
        private byte NumberOfFloors { get; set; }
        private byte NumberOfBedrooms { get; set; }
        #endregion



        #region ConstructorMethods
        public HomeData()
            : base()
        {
            this.NumberOfFloors = byte.MinValue;
            this.NumberOfBedrooms = byte.MinValue;
        }

        public HomeData(byte NumberOfFloors,
                        byte NumberOfBedrooms)
            : base()
        {
            this.NumberOfFloors = NumberOfFloors;
            this.NumberOfBedrooms = NumberOfBedrooms;
        }

        public HomeData(ushort UsableArea,
                        ushort TotalArea,
                        bool IsThereABalcony,
                        byte NumberOfBathrooms,
                        byte NumberOfParkingSpaces,
                        byte NumberOfFloors,
                        byte NumberOfBedrooms)
            : base(UsableArea: UsableArea,
                   TotalArea: TotalArea,
                   IsThereABalcony: IsThereABalcony,
                   NumberOfBathrooms: NumberOfBathrooms,
                   NumberOfParkingSpaces: NumberOfParkingSpaces)
        {
            this.NumberOfFloors = NumberOfFloors;
            this.NumberOfBedrooms = NumberOfBedrooms;
        }
        #endregion



        #region DestructorMethods
        ~HomeData()
        {

        }
        #endregion



        #region Getters and Setters
        public byte GetNumberOfFloors()
        {
            return this.NumberOfFloors;
        }

        public void SetNumberOfFloors(byte NumberOfFloors)
        {
            this.NumberOfFloors = NumberOfFloors;
        }

        public byte GetNumberOfBedrooms()
        {
            return this.NumberOfBedrooms;
        }

        public void SetNumberOfBedrooms(byte NumberOfBedrooms)
        {
            this.NumberOfBedrooms = NumberOfBedrooms;
        }
        #endregion
    }
}