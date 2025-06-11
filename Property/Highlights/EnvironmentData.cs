namespace Data.Property.Highlights
{
    public sealed class EnvironmentData // Ambientes
    {
        #region Variables
        private bool V_HasGrill; // Parrilla
        private bool V_HasPool; // Piscina
        private bool V_HasCloset;
        private bool V_HasGuestBathroom; // Baño de visitas
        private bool V_HasTerrace; // Terraza
        private bool V_HasDiningRoom; // Comedor
        private bool V_HasWalkInCloset; // Vestidor
        private bool V_HasHomeoffice; // Oficina en casa
        private bool V_HasLiving;
        private bool V_HasYard; // Patio
        private bool V_HasBedroomDuite; // Dormitorio en suite
        private bool V_HasBalcony; // Balcón
        private bool V_HasMansard; // Mansarda
        private bool V_HasGarden; // Jardín
        private bool V_HasKitchen; // Cocina
        private bool V_HasServiceBedroom; // Dormitorio de servicio
        private bool V_HasServiceBathroom; // Baño de servicio
        private bool V_HasPlayroom; // Cuarto de juego
        private bool V_HasWithLodge; // Con logia
        private bool V_HasEverydayDiningRoom; // Comedor de diario
        #endregion



        #region Constructor Methods
        public EnvironmentData()
            : base()
        {
            this.HasGrill = false;
            this.HasPool = false;
            this.HasCloset = false;
            this.HasGuestBathroom = false;
            this.HasTerrace = false;
            this.HasDiningRoom = false;
            this.HasWalkInCloset = false;
            this.HasHomeoffice = false;
            this.HasLiving = false;
            this.HasYard = false;
            this.HasBedroomDuite = false;
            this.HasBalcony = false;
            this.HasMansard = false;
            this.HasGarden = false;
            this.HasKitchen = false;
            this.HasServiceBedroom = false;
            this.HasServiceBathroom = false;
            this.HasPlayroom = false;
            this.HasWithLodge = false;
            this.HasEverydayDiningRoom = false;
        }

        public EnvironmentData(bool HasGrill,
                               bool HasPool,
                               bool HasCloset,
                               bool HasGuestBathroom,
                               bool HasTerrace,
                               bool HasDiningRoom,
                               bool HasWalkInCloset,
                               bool HasHomeoffice,
                               bool HasLiving,
                               bool HasYard,
                               bool HasBedroomDuite,
                               bool HasBalcony,
                               bool HasMansard,
                               bool HasGarden,
                               bool HasKitchen,
                               bool HasServiceBedroom,
                               bool HasServiceBathroom,
                               bool HasPlayroom,
                               bool HasWithLodge,
                               bool HasEverydayDiningRoom)
            : base()
        {
            this.HasGrill = HasGrill;
            this.HasPool = HasPool;
            this.HasCloset = HasCloset;
            this.HasGuestBathroom = HasGuestBathroom;
            this.HasTerrace = HasTerrace;
            this.HasDiningRoom = HasDiningRoom;
            this.HasWalkInCloset = HasWalkInCloset;
            this.HasHomeoffice = HasHomeoffice;
            this.HasLiving = HasLiving;
            this.HasYard = HasYard;
            this.HasBedroomDuite = HasBedroomDuite;
            this.HasBalcony = HasBalcony;
            this.HasMansard = HasMansard;
            this.HasGarden = HasGarden;
            this.HasKitchen = HasKitchen;
            this.HasServiceBedroom = HasServiceBedroom;
            this.HasServiceBathroom = HasServiceBathroom;
            this.HasPlayroom = HasPlayroom;
            this.HasWithLodge = HasWithLodge;
            this.HasEverydayDiningRoom = HasEverydayDiningRoom;
        }
        #endregion



        #region Getters and Setters
        public bool HasGrill
        {
            get => this.V_HasGrill;
            set => this.V_HasGrill = value;
        }

        public bool HasPool
        {
            get => V_HasPool;
            set => this.V_HasPool = value;
        }

        public bool HasCloset
        {
            get => this.V_HasCloset;
            set => this.V_HasCloset = value;
        }

        public bool HasGuestBathroom
        {
            get => this.V_HasGuestBathroom;
            set => this.V_HasGuestBathroom = value;
        }

        public bool HasTerrace
        {
            get => this.V_HasTerrace;
            set => this.V_HasTerrace = value;
        }

        public bool HasDiningRoom
        {
            get => V_HasDiningRoom;
            set => this.V_HasDiningRoom = value;
        }

        public bool HasWalkInCloset
        {
            get => this.V_HasWalkInCloset;
            set => this.V_HasWalkInCloset = value;
        }

        public bool HasHomeoffice
        {
            get => this.V_HasHomeoffice;
            set => this.V_HasHomeoffice = value;
        }

        public bool HasLiving
        {
            get => this.V_HasLiving;
            set => this.V_HasLiving = value;
        }

        public bool HasYard
        {
            get => this.V_HasYard;
            set => this.V_HasYard = value;
        }

        public bool HasBedroomDuite
        {
            get => this.V_HasBedroomDuite;
            set => this.V_HasBedroomDuite = value;
        }

        public bool HasBalcony
        {
            get => this.V_HasBalcony;
            set => this.V_HasBalcony = value;
        }

        public bool HasMansard
        {
            get => this.V_HasMansard;
            set => this.V_HasMansard = value;
        }

        public bool HasGarden
        {
            get => this.V_HasGarden;
            set => this.V_HasGarden = value;
        }

        public bool HasKitchen
        {
            get => this.V_HasKitchen;
            set => this.V_HasKitchen = value;
        }

        public bool HasServiceBedroom
        {
            get => this.V_HasServiceBedroom;
            set => this.V_HasServiceBedroom = value;
        }

        public bool HasServiceBathroom
        {
            get => this.V_HasServiceBathroom;
            set => this.V_HasServiceBathroom = value;
        }

        public bool HasPlayroom
        {
            get => this.V_HasPlayroom;
            set => this.V_HasPlayroom = value;
        }

        public bool HasWithLodge
        {
            get => this.V_HasWithLodge;
            set => this.V_HasWithLodge = value;
        }

        public bool HasEverydayDiningRoom
        {
            get => this.V_HasEverydayDiningRoom;
            set => this.V_HasEverydayDiningRoom = value;
        }
        #endregion
    }
}