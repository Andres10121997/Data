namespace Data.Property
{
    public class PropertyData
    {
        #region Variables
        private ushort UsableArea { get; set; }
        private ushort TotalArea { get; set; }
        private bool IsThereABalcony { get; set; }
        private byte NumberOfBathrooms { get; set; }
        private byte NumberOfParkingSpaces { get; set; }
        #endregion



        #region ConstructorMethods
        public PropertyData()
            : base()
        {
            this.UsableArea = ushort.MinValue;
            this.TotalArea = ushort.MinValue;
            this.IsThereABalcony = false;
            this.NumberOfBathrooms = byte.MinValue;
            this.NumberOfParkingSpaces = byte.MinValue;
        }

        public PropertyData(ushort UsableArea,
                            ushort TotalArea,
                            bool IsThereABalcony,
                            byte NumberOfBathrooms,
                            byte NumberOfParkingSpaces)
            : base()
        {
            this.UsableArea = UsableArea;
            this.TotalArea = TotalArea;
            this.IsThereABalcony = IsThereABalcony;
            this.NumberOfBathrooms = NumberOfBathrooms;
            this.NumberOfParkingSpaces = NumberOfParkingSpaces;
        }
        #endregion



        #region DestructorMethods
        ~PropertyData()
        {

        }
        #endregion



        #region Getters and Setters
        public ushort GetUsableArea()
        {
            return this.UsableArea;
        }

        public void SetUsableArea(ushort UsableArea)
        {
            this.UsableArea = UsableArea;
        }

        public ushort GetTotalArea()
        {
            return this.TotalArea;
        }

        public void SetTotalArea(ushort TotalArea)
        {
            this.TotalArea = TotalArea;
        }

        public bool GetIsThereABalcony()
        {
            return this.IsThereABalcony;
        }

        public void SetIsThereABalcony(bool IsThereABalcony)
        {
            this.IsThereABalcony = IsThereABalcony;
        }

        public byte GetNumberOfBathrooms()
        {
            return this.NumberOfBathrooms;
        }

        public void SetNumberOfBathrooms(byte NumberOfBathrooms)
        {
            this.NumberOfBathrooms = NumberOfBathrooms;
        }

        public byte GetNumberOfParkingSpaces()
        {
            return this.NumberOfParkingSpaces;
        }

        public void SetNumberOfParkingSpaces(byte NumberOfParkingSpaces)
        {
            this.NumberOfParkingSpaces = NumberOfParkingSpaces;
        }
        #endregion
    }
}