using Data.Property.Highlights;

namespace Data.Property
{
    public class PropertyData
    {
        #region Variables
        private ushort UsableArea { get; set; }
        private ushort TotalArea { get; set; }
        private byte NumberOfBedrooms { get; set; }
        private byte NumberOfBathrooms { get; set; }
        private byte NumberOfWarehouses { get; set; }
        private byte NumberOfParkingSpaces { get; set; }
        private byte NumberOfFloors { get; set; }
        private PropertyTypeEnum PropertyType { get; set; }
        #endregion

        #region Objects
        private SecurityData Security { get; set; }
        private ServiceData Service { get; set; }
        private EnvironmentData Environment { get; set; }
        private EquipmentData Equipment { get; set; }
        #endregion

        #region Enum
        public enum PropertyTypeEnum
        {
            House,          // Casa
            Apartment,      // Apartamento
            Office,         // Oficina
            RetailSpace,    // Local Comercial
            Land,           // Terreno
            Plot,           // Parcela
            Agricultural,   // Agrícola
            Industrial,     // Industrial
            Warehouse,      // Bodega
            Parking,        // Estacionamiento
            Resort          // Centro Vacacional
        }
        #endregion



        #region Constructor Methods
        public PropertyData()
            : base()
        {
            #region Variables
            this.UsableArea = ushort.MinValue;
            this.TotalArea = ushort.MinValue;
            this.NumberOfBedrooms = byte.MinValue;
            this.NumberOfBathrooms = byte.MinValue;
            this.NumberOfWarehouses = byte.MinValue;
            this.NumberOfParkingSpaces = byte.MinValue;
            this.NumberOfFloors = byte.MinValue;
            this.PropertyType = PropertyTypeEnum.House;
            #endregion

            #region Objects
            this.Security = new SecurityData();
            this.Service = new ServiceData();
            this.Environment = new EnvironmentData();
            this.Equipment = new EquipmentData();
            #endregion
        }

        public PropertyData(ushort UsableArea,
                            ushort TotalArea,
                            byte NumberOfBedrooms,
                            byte NumberOfBathrooms,
                            byte NumberOfWarehouses,
                            byte NumberOfParkingSpaces,
                            byte NumberOfFloors,
                            PropertyTypeEnum PropertyType,
                            SecurityData Security,
                            ServiceData Service,
                            EnvironmentData Environment,
                            EquipmentData Equipment)
            : base()
        {
            #region Variables
            this.UsableArea = UsableArea;
            this.TotalArea = TotalArea;
            this.NumberOfBedrooms = NumberOfBedrooms;
            this.NumberOfBathrooms = NumberOfBathrooms;
            this.NumberOfWarehouses = NumberOfWarehouses;
            this.NumberOfParkingSpaces = NumberOfParkingSpaces;
            this.NumberOfFloors = NumberOfFloors;
            this.PropertyType = PropertyType;
            #endregion

            #region Objects
            this.Security = Security;
            this.Service = Service;
            this.Environment = Environment;
            this.Equipment = Equipment;
            #endregion
        }
        #endregion



        #region Destructor Methods
        ~PropertyData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
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

        public byte GetNumberOfBedrooms()
        {
            return this.NumberOfBedrooms;
        }

        public void SetNumberOfBedrooms(byte NumberOfBedrooms)
        {
            this.NumberOfBedrooms = NumberOfBedrooms;
        }

        public byte GetNumberOfBathrooms()
        {
            return this.NumberOfBathrooms;
        }

        public void SetNumberOfBathrooms(byte NumberOfBathrooms)
        {
            this.NumberOfBathrooms = NumberOfBathrooms;
        }

        public byte GetNumberOfWarehouses()
        {
            return this.NumberOfWarehouses;
        }

        public void SetNumberOfWarehouses(byte NumberOfWarehouses)
        {
            this.NumberOfWarehouses = NumberOfWarehouses;
        }

        public byte GetNumberOfParkingSpaces()
        {
            return this.NumberOfParkingSpaces;
        }

        public void SetNumberOfParkingSpaces(byte NumberOfParkingSpaces)
        {
            this.NumberOfParkingSpaces = NumberOfParkingSpaces;
        }

        public byte GetNumberOfFloors()
        {
            return this.NumberOfFloors;
        }

        public void SetNumberOfFloors(byte NumberOfFloors)
        {
            this.NumberOfFloors = NumberOfFloors;
        }

        public PropertyTypeEnum GetPropertyType()
        {
            return this.PropertyType;
        }

        public void SetPropertyType(PropertyTypeEnum PropertyType)
        {
            this.PropertyType = PropertyType;
        }
        #endregion

        #region Objects
        public SecurityData GetSecurity()
        {
            return this.Security;
        }

        public void SetSecurity(SecurityData Security)
        {
            this.Security = Security;
        }

        public ServiceData GetService()
        {
            return this.Service;
        }

        public void SetService(ServiceData Service)
        {
            this.Service = Service;
        }

        public EnvironmentData GetEnvironment()
        {
            return this.Environment;
        }

        public void SetEnvironment(EnvironmentData Environment)
        {
            this.Environment = Environment;
        }

        public EquipmentData GetEquipment()
        {
            return this.Equipment;
        }

        public void SetEquipment(EquipmentData Equipment)
        {
            this.Equipment = Equipment;
        }
        #endregion
        #endregion
    }
}