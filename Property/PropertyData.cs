using Data.Property.Highlights;
using System;

namespace Data.Property
{
    public sealed class PropertyData
    {
        #region Variables
        private ushort V_UsableArea;
        private ushort V_TotalArea;
        private byte V_NumberOfBedrooms;
        private byte V_NumberOfBathrooms;
        private byte V_NumberOfWarehouses;
        private byte V_NumberOfParkingSpaces;
        private byte V_NumberOfFloors;
        private PropertyTypeEnum V_PropertyType;
        #endregion

        #region Objects
        private SecurityData O_Security;
        private ServiceData O_Service;
        private EnvironmentData O_Environment;
        private EquipmentData O_Equipment;
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
            this.O_Security = new SecurityData();
            this.O_Service = new ServiceData();
            this.O_Environment = new EnvironmentData();
            this.O_Equipment = new EquipmentData();
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
            this.O_Security = Security;
            this.O_Service = Service;
            this.O_Environment = Environment;
            this.O_Equipment = Equipment;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ushort UsableArea
        {
            get => this.V_UsableArea;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: value);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(
                    value: value,
                    other: this.TotalArea
                );

                this.V_UsableArea = value;
            }
        }

        public ushort TotalArea
        {
            get => this.V_TotalArea;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: value);
                ArgumentOutOfRangeException.ThrowIfLessThan(
                    value: value,
                    other: this.UsableArea
                );

                this.V_TotalArea = value;
            }
        }

        public byte NumberOfBedrooms
        {
            get => this.V_NumberOfBedrooms;
            set => this.V_NumberOfBedrooms = value;
        }

        public byte NumberOfBathrooms
        {
            get => this.V_NumberOfBathrooms;
            set => this.V_NumberOfBathrooms = value;
        }

        public byte NumberOfWarehouses
        {
            get => this.V_NumberOfWarehouses;
            set => this.V_NumberOfWarehouses = value;
        }

        public byte NumberOfParkingSpaces
        {
            get => this.V_NumberOfParkingSpaces;
            set => this.V_NumberOfParkingSpaces = value;
        }

        public byte NumberOfFloors
        {
            get => this.V_NumberOfFloors;
            set => this.V_NumberOfFloors = value;
        }

        public PropertyTypeEnum PropertyType
        {
            get => this.V_PropertyType;
            set => this.V_PropertyType = value;
        }
        #endregion

        #region Objects
        public SecurityData Security
        {
            get => this.O_Security;
            set => this.O_Security = value;
        }

        public ServiceData Service
        {
            get => this.O_Service;
            set => this.O_Service = value;
        }

        public EnvironmentData Environment
        {
            get => this.O_Environment;
            set => this.O_Environment = value;
        }

        public EquipmentData Equipment
        {
            get => this.O_Equipment;
            set => this.O_Equipment = value;
        }
        #endregion
        #endregion
    }
}