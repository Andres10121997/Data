namespace Data.Property.Highlights
{
    public sealed class EnvironmentData // Ambientes
    {
        #region Variables
        private bool HasGrill { get; set; } // Parrilla
        private bool HasPool { get; set; } // Piscina
        private bool HasCloset { get; set; }
        private bool HasGuestBathroom { get; set; } // Baño de visitas
        private bool HasTerrace { get; set; } // Terraza
        private bool HasDiningRoom { get; set; } // Comedor
        private bool HasWalkInCloset { get; set; } // Vestidor
        private bool HasHomeoffice { get; set; } // Oficina en casa
        private bool HasLiving { get; set; }
        private bool HasYard { get; set; } // Patio
        private bool HasBedroomDuite { get; set; } // Dormitorio en suite
        private bool HasBalcony { get; set; } // Balcón
        private bool HasMansard { get; set; } // Mansarda
        private bool HasGarden { get; set; } // Jardín
        private bool HasKitchen { get; set; } // Cocina
        private bool HasServiceBedroom { get; set; } // Dormitorio de servicio
        private bool HasServiceBathroom { get; set; } // Baño de servicio
        private bool HasPlayroom { get; set; } // Cuarto de juego
        private bool HasWithLodge { get; set; } // Con logia
        private bool HasEverydayDiningRoom { get; set; } // Comedor de diario
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
            this.HasGrill               = HasGrill;
            this.HasPool                = HasPool;
            this.HasCloset              = HasCloset;
            this.HasGuestBathroom       = HasGuestBathroom;
            this.HasTerrace             = HasTerrace;
            this.HasDiningRoom          = HasDiningRoom;
            this.HasWalkInCloset        = HasWalkInCloset;
            this.HasHomeoffice          = HasHomeoffice;
            this.HasLiving              = HasLiving;
            this.HasYard                = HasYard;
            this.HasBedroomDuite        = HasBedroomDuite;
            this.HasBalcony             = HasBalcony;
            this.HasMansard             = HasMansard;
            this.HasGarden              = HasGarden;
            this.HasKitchen             = HasKitchen;
            this.HasServiceBedroom      = HasServiceBedroom;
            this.HasServiceBathroom     = HasServiceBathroom;
            this.HasPlayroom            = HasPlayroom;
            this.HasWithLodge           = HasWithLodge;
            this.HasEverydayDiningRoom  = HasEverydayDiningRoom;
        }
        #endregion



        #region Destructor Methods
        ~EnvironmentData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetHasGrill()
        {
            return this.HasGrill;
        }

        public void SetHasGrill(bool HasGrill)
        {
            this.HasGrill = HasGrill;
        }

        public bool GetHasPool()
        {
            return this.HasPool;
        }

        public void SetHasPool(bool HasPool)
        {
            this.HasPool = HasPool;
        }

        public bool GetHasCloset()
        {
            return this.HasCloset;
        }

        public void SetHasCloset(bool HasCloset)
        {
            this.HasCloset = HasCloset;
        }

        public bool GetHasGuestBathroom()
        {
            return this.HasGuestBathroom;
        }

        public void SetHasGuestBathroom(bool HasGuestBathroom)
        {
            this.HasGuestBathroom = HasGuestBathroom;
        }

        public bool GetHasTerrace()
        {
            return this.HasTerrace;
        }

        public void SetHasTerrace(bool HasTerrace)
        {
            this.HasTerrace = HasTerrace;
        }

        public bool GetHasDiningRoom()
        {
            return this.HasDiningRoom;
        }

        public void SetHasDiningRoom(bool HasDiningRoom)
        {
            this.HasDiningRoom = HasDiningRoom;
        }

        public bool GetHasWalkInCloset()
        {
            return this.HasWalkInCloset;
        }

        public void SetHasWalkInCloset(bool HasWalkInCloset)
        {
            this.HasWalkInCloset = HasWalkInCloset;
        }

        public bool GetHasHomeoffice()
        {
            return this.HasHomeoffice;
        }

        public void SetHasHomeoffice(bool HasHomeoffice)
        {
            this.HasHomeoffice = HasHomeoffice;
        }

        public bool GetHasLiving()
        {
            return this.HasLiving;
        }

        public void SetHasLiving(bool HasLiving)
        {
            this.HasLiving = HasLiving;
        }

        public bool GetHasYard()
        {
            return this.HasYard;
        }

        public void SetHasYard(bool HasYard)
        {
            this.HasYard = HasYard;
        }

        public bool GetHasBedroomDuite()
        {
            return this.HasBedroomDuite;
        }

        public void SetHasBedroomDuite(bool HasBedroomDuite)
        {
            this.HasBedroomDuite = HasBedroomDuite;
        }

        public bool GetHasBalcony()
        {
            return this.HasBalcony;
        }

        public void SetHasBalcony(bool HasBalcony)
        {
            this.HasBalcony = HasBalcony;
        }

        public bool GetHasMansard()
        {
            return this.HasMansard;
        }

        public void SetHasMansard(bool HasMansard)
        {
            this.HasMansard = HasMansard;
        }

        public bool GetHasGarden()
        {
            return this.HasGarden;
        }

        public void SetHasGarden(bool HasGarden)
        {
            this.HasGarden = HasGarden;
        }

        public bool GetHasKitchen()
        {
            return this.HasKitchen;
        }

        public void SetHasKitchen(bool HasKitchen)
        {
            this.HasKitchen = HasKitchen;
        }

        public bool GetHasServiceBedroom()
        {
            return this.HasServiceBedroom;
        }

        public void SetHasServiceBedroom(bool HasServiceBedroom)
        {
            this.HasServiceBedroom = HasServiceBedroom;
        }

        public bool GetHasServiceBathroom()
        {
            return this.HasServiceBathroom;
        }

        public void SetHasServiceBathroom(bool HasServiceBathroom)
        {
            this.HasServiceBathroom = HasServiceBathroom;
        }

        public bool GetHasPlayroom()
        {
            return this.HasPlayroom;
        }

        public void SetHasPlayroom(bool HasPlayroom)
        {
            this.HasPlayroom = HasPlayroom;
        }

        public bool GetHasWithLodge()
        {
            return this.HasWithLodge;
        }

        public void SetHasWithLodge(bool HasWithLodge)
        {
            this.HasWithLodge = HasWithLodge;
        }

        public bool GetHasEverydayDiningRoom()
        {
            return this.HasEverydayDiningRoom;
        }

        public void SetHasEverydayDiningRoom(bool HasEverydayDiningRoom)
        {
            this.HasEverydayDiningRoom = HasEverydayDiningRoom;
        }
        #endregion
    }
}