namespace Data.Property.Highlights
{
    public class EnvironmentData // Ambientes
    {
        #region Variables
        private bool IsThereGrill { get; set; } // Parrilla
        private bool IsTherePool { get; set; } // Piscina
        private bool IsThereCloset { get; set; }
        private bool IsThereGuestBathroom { get; set; } // Baño de visitas
        private bool IsThereTerrace { get; set; } // Terraza
        private bool IsThereDiningRoom { get; set; } // Comedor
        private bool IsThereWalkInCloset { get; set; } // Vestidor
        private bool IsThereHomeoffice { get; set; } // Oficina en casa
        private bool IsThereLiving { get; set; }
        private bool IsThereYard { get; set; } // Patio
        private bool IsThereBedroomDuite { get; set; } // Dormitorio en suite
        private bool IsThereBalcony { get; set; } // Balcón
        private bool IsThereMansard { get; set; } // Mansarda
        private bool IsThereGarden { get; set; } // Jardín
        private bool IsThereKitchen { get; set; } // Cocina
        private bool IsThereServiceBedroom { get; set; } // Dormitorio de servicio
        private bool IsThereServiceBathroom { get; set; } // Baño de servicio
        private bool IsTherePlayroom { get; set; } // Cuarto de juego
        private bool IsThereWithLodge { get; set; } // Con logia
        private bool IsThereEverydayDiningRoom { get; set; } // Comedor de diario
        #endregion



        #region ConstructorMethods
        public EnvironmentData()
            : base()
        {
            this.IsThereGrill = false;
            this.IsTherePool = false;
            this.IsThereCloset = false;
            this.IsThereGuestBathroom = false;
            this.IsThereTerrace = false;
            this.IsThereDiningRoom = false;
            this.IsThereWalkInCloset = false;
            this.IsThereHomeoffice = false;
            this.IsThereLiving = false;
            this.IsThereYard = false;
            this.IsThereBedroomDuite = false;
            this.IsThereBalcony = false;
            this.IsThereMansard = false;
            this.IsThereGarden = false;
            this.IsThereKitchen = false;
            this.IsThereServiceBedroom = false;
            this.IsThereServiceBathroom = false;
            this.IsTherePlayroom = false;
            this.IsThereWithLodge = false;
            this.IsThereEverydayDiningRoom = false;
        }

        public EnvironmentData(bool IsThereGrill,
                               bool IsTherePool,
                               bool IsThereCloset,
                               bool IsThereGuestBathroom,
                               bool IsThereTerrace,
                               bool IsThereDiningRoom,
                               bool IsThereWalkInCloset,
                               bool IsThereHomeoffice,
                               bool IsThereLiving,
                               bool IsThereYard,
                               bool IsThereBedroomDuite,
                               bool IsThereBalcony,
                               bool IsThereMansard,
                               bool IsThereGarden,
                               bool IsThereKitchen,
                               bool IsThereServiceBedroom,
                               bool IsThereServiceBathroom,
                               bool IsTherePlayroom,
                               bool IsThereWithLodge,
                               bool IsThereEverydayDiningRoom)
            : base()
        {
            this.IsThereGrill = IsThereGrill;
            this.IsTherePool = IsTherePool;
            this.IsThereCloset = IsThereCloset;
            this.IsThereGuestBathroom = IsThereGuestBathroom;
            this.IsThereTerrace = IsThereTerrace;
            this.IsThereDiningRoom = IsThereDiningRoom;
            this.IsThereWalkInCloset = IsThereWalkInCloset;
            this.IsThereHomeoffice = IsThereHomeoffice;
            this.IsThereLiving = IsThereLiving;
            this.IsThereYard = IsThereYard;
            this.IsThereBedroomDuite = IsThereBedroomDuite;
            this.IsThereBalcony = IsThereBalcony;
            this.IsThereMansard = IsThereMansard;
            this.IsThereGarden = IsThereGarden;
            this.IsThereKitchen = IsThereKitchen;
            this.IsThereServiceBedroom = IsThereServiceBedroom;
            this.IsThereServiceBathroom = IsThereServiceBathroom;
            this.IsTherePlayroom = IsTherePlayroom;
            this.IsThereWithLodge = IsThereWithLodge;
            this.IsThereEverydayDiningRoom = IsThereEverydayDiningRoom;
        }
        #endregion



        #region DestructorMethods
        ~EnvironmentData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetIsThereGrill()
        {
            return this.IsThereGrill;
        }

        public void SetIsThereGrill(bool IsThereGrill)
        {
            this.IsThereGrill = IsThereGrill;
        }

        public bool GetIsTherePool()
        {
            return this.IsTherePool;
        }

        public void SetIsTherePool(bool IsTherePool)
        {
            this.IsTherePool = IsTherePool;
        }

        public bool GetIsThereCloset()
        {
            return this.IsThereCloset;
        }

        public void SetIsThereCloset(bool IsThereCloset)
        {
            this.IsThereCloset = IsThereCloset;
        }

        public bool GetIsThereGuestBathroom()
        {
            return this.IsThereGuestBathroom;
        }

        public void SetIsThereGuestBathroom(bool IsThereGuestBathroom)
        {
            this.IsThereGuestBathroom = IsThereGuestBathroom;
        }

        public bool GetIsThereTerrace()
        {
            return this.IsThereTerrace;
        }

        public void SetIsThereTerrace(bool IsThereTerrace)
        {
            this.IsThereTerrace = IsThereTerrace;
        }

        public bool GetIsThereDiningRoom()
        {
            return this.IsThereDiningRoom;
        }

        public void SetIsThereDiningRoom(bool IsThereDiningRoom)
        {
            this.IsThereDiningRoom = IsThereDiningRoom;
        }

        public bool GetIsThereWalkInCloset()
        {
            return this.IsThereWalkInCloset;
        }

        public void SetIsThereWalkInCloset(bool IsThereWalkInCloset)
        {
            this.IsThereWalkInCloset = IsThereWalkInCloset;
        }

        public bool GetIsThereHomeoffice()
        {
            return this.IsThereHomeoffice;
        }

        public void SetIsThereHomeoffice(bool IsThereHomeoffice)
        {
            this.IsThereHomeoffice = IsThereHomeoffice;
        }

        public bool GetIsThereLiving()
        {
            return this.IsThereLiving;
        }

        public void SetIsThereLiving(bool IsThereLiving)
        {
            this.IsThereLiving = IsThereLiving;
        }

        public bool GetIsThereYard()
        {
            return this.IsThereYard;
        }

        public void SetIsThereYard(bool IsThereYard)
        {
            this.IsThereYard = IsThereYard;
        }

        public bool GetIsThereBedroomDuite()
        {
            return this.IsThereBedroomDuite;
        }

        public void SetIsThereBedroomDuite(bool IsThereBedroomDuite)
        {
            this.IsThereBedroomDuite = IsThereBedroomDuite;
        }

        public bool GetIsThereBalcony()
        {
            return this.IsThereBalcony;
        }

        public void SetIsThereBalcony(bool IsThereBalcony)
        {
            this.IsThereBalcony = IsThereBalcony;
        }

        public bool GetIsThereMansard()
        {
            return this.IsThereMansard;
        }

        public void SetIsThereMansard(bool IsThereMansard)
        {
            this.IsThereMansard = IsThereMansard;
        }

        public bool GetIsThereGarden()
        {
            return this.IsThereGarden;
        }

        public void SetIsThereGarden(bool IsThereGarden)
        {
            this.IsThereGarden = IsThereGarden;
        }

        public bool GetIsThereKitchen()
        {
            return this.IsThereKitchen;
        }

        public void SetIsThereKitchen(bool IsThereKitchen)
        {
            this.IsThereKitchen = IsThereKitchen;
        }

        public bool GetIsThereServiceBedroom()
        {
            return this.IsThereServiceBedroom;
        }

        public void SetIsThereServiceBedroom(bool IsThereServiceBedroom)
        {
            this.IsThereServiceBedroom = IsThereServiceBedroom;
        }

        public bool GetIsThereServiceBathroom()
        {
            return this.IsThereServiceBathroom;
        }

        public void SetIsThereServiceBathroom(bool IsThereServiceBathroom)
        {
            this.IsThereServiceBathroom = IsThereServiceBathroom;
        }

        public bool GetIsTherePlayroom()
        {
            return this.IsTherePlayroom;
        }

        public void SetIsTherePlayroom(bool IsTherePlayroom)
        {
            this.IsTherePlayroom = IsTherePlayroom;
        }

        public bool GetIsThereWithLodge()
        {
            return this.IsThereWithLodge;
        }

        public void SetIsThereWithLodge(bool IsThereWithLodge)
        {
            this.IsThereWithLodge = IsThereWithLodge;
        }

        public bool GetIsThereEverydayDiningRoom()
        {
            return this.IsThereEverydayDiningRoom;
        }

        public void SetIsThereEverydayDiningRoom(bool IsThereEverydayDiningRoom)
        {
            this.IsThereEverydayDiningRoom = IsThereEverydayDiningRoom;
        }
        #endregion
    }
}