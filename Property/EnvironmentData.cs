namespace Data.Property
{
    public class EnvironmentData // Ambientes
    {
        #region Variables
        private bool Grill { get; set; } // Parrilla
        private bool Pool { get; set; } // Piscina
        private bool Closet { get; set; }
        private bool GuestBathroom { get; set; } // Baño de visitas
        private bool Terrace { get; set; } // Terraza
        private bool DiningRoom { get; set; } // Comedor
        private bool WalkInCloset { get; set; } // Vestidor
        private bool Homeoffice { get; set; } // Oficina en casa
        private bool Living { get; set; }
        private bool Yard { get; set; } // Patio
        private bool BedroomDuite { get; set; } // Dormitorio en suite
        private bool Balcony { get; set; } // Balcón
        private bool Mansard { get; set; } // Mansarda
        private bool Garden { get; set; } // Jardín
        private bool Kitchen { get; set; } // Cocina
        private bool ServiceBedroom { get; set; } // Dormitorio de servicio
        private bool ServiceBathroom { get; set; } // Baño de servicio
        private bool Playroom { get; set; } // Cuarto de juego
        private bool WithLodge { get; set; } // Con logia
        private bool EverydayDiningRoom { get; set; } // Comedor de diario
        #endregion



        #region ConstructorMethods
        public EnvironmentData()
            : base()
        {
            this.Grill = false;
            this.Pool = false;
            this.Closet = false;
            this.GuestBathroom = false;
            this.Terrace = false;
            this.DiningRoom = false;
            this.WalkInCloset = false;
            this.Homeoffice = false;
            this.Living = false;
            this.Yard = false;
            this.BedroomDuite = false;
            this.Balcony = false;
            this.Mansard = false;
            this.Garden = false;
            this.Kitchen = false;
            this.ServiceBedroom = false;
            this.ServiceBathroom = false;
            this.Playroom = false;
            this.WithLodge = false;
            this.EverydayDiningRoom = false;
        }

        public EnvironmentData(bool Grill,
                               bool Pool,
                               bool Closet,
                               bool GuestBathroom,
                               bool Terrace,
                               bool DiningRoom,
                               bool WalkInCloset,
                               bool Homeoffice,
                               bool Living,
                               bool Yard,
                               bool BedroomDuite,
                               bool Balcony,
                               bool Mansard,
                               bool Garden,
                               bool Kitchen,
                               bool ServiceBedroom,
                               bool ServiceBathroom,
                               bool Playroom,
                               bool WithLodge,
                               bool EverydayDiningRoom)
            : base()
        {
            this.Grill = Grill;
            this.Pool = Pool;
            this.Closet = Closet;
            this.GuestBathroom = GuestBathroom;
            this.Terrace = Terrace;
            this.DiningRoom = DiningRoom;
            this.WalkInCloset = WalkInCloset;
            this.Homeoffice = Homeoffice;
            this.Living = Living;
            this.Yard = Yard;
            this.BedroomDuite = BedroomDuite;
            this.Balcony = Balcony;
            this.Mansard = Mansard;
            this.Garden = Garden;
            this.Kitchen = Kitchen;
            this.ServiceBedroom = ServiceBedroom;
            this.ServiceBathroom = ServiceBathroom;
            this.Playroom = Playroom;
            this.WithLodge = WithLodge;
            this.EverydayDiningRoom = EverydayDiningRoom;
        }
        #endregion



        #region DestructorMethods
        ~EnvironmentData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetGrill()
        {
            return this.Grill;
        }

        public void SetGrill(bool Grill)
        {
            this.Grill = Grill;
        }

        public bool GetPool()
        {
            return this.Pool;
        }

        public void SetPool(bool Pool)
        {
            this.Pool = Pool;
        }

        public bool GetCloset()
        {
            return this.Closet;
        }

        public void SetCloset(bool Closet)
        {
            this.Closet = Closet;
        }

        public bool GetGuestBathroom()
        {
            return this.GuestBathroom;
        }

        public void SetGuestBathroom(bool GuestBathroom)
        {
            this.GuestBathroom = GuestBathroom;
        }

        public bool GetTerrace()
        {
            return this.Terrace;
        }

        public void SetTerrace(bool Terrace)
        {
            this.Terrace = Terrace;
        }

        public bool GetDiningRoom()
        {
            return this.DiningRoom;
        }

        public void SetDiningRoom(bool DiningRoom)
        {
            this.DiningRoom = DiningRoom;
        }

        public bool GetWalkInCloset()
        {
            return this.WalkInCloset;
        }

        public void SetWalkInCloset(bool WalkInCloset)
        {
            this.WalkInCloset = WalkInCloset;
        }

        public bool GetHomeoffice()
        {
            return this.Homeoffice;
        }

        public void SetHomeoffice(bool Homeoffice)
        {
            this.Homeoffice = Homeoffice;
        }

        public bool GetLiving()
        {
            return this.Living;
        }

        public void SetLiving(bool Living)
        {
            this.Living = Living;
        }

        public bool GetYard()
        {
            return this.Yard;
        }

        public void SetYard(bool Yard)
        {
            this.Yard = Yard;
        }

        public bool GetBedroomDuite()
        {
            return this.BedroomDuite;
        }

        public void SetBedroomDuite(bool BedroomDuite)
        {
            this.BedroomDuite = BedroomDuite;
        }

        public bool GetBalcony()
        {
            return this.Balcony;
        }

        public void SetBalcony(bool Balcony)
        {
            this.Balcony = Balcony;
        }

        public bool GetMansard()
        {
            return this.Mansard;
        }

        public void SetMansard(bool Mansard)
        {
            this.Mansard = Mansard;
        }

        public bool GetGarden()
        {
            return this.Garden;
        }

        public void SetGarden(bool Garden)
        {
            this.Garden = Garden;
        }

        public bool GetKitchen()
        {
            return this.Kitchen;
        }

        public void SetKitchen(bool Kitchen)
        {
            this.Kitchen = Kitchen;
        }

        public bool GetServiceBedroom()
        {
            return this.ServiceBedroom;
        }

        public void SetServiceBedroom(bool ServiceBedroom)
        {
            this.ServiceBedroom = ServiceBedroom;
        }

        public bool GetServiceBathroom()
        {
            return this.ServiceBathroom;
        }

        public void SetServiceBathroom(bool ServiceBathroom)
        {
            this.ServiceBathroom = ServiceBathroom;
        }

        public bool GetPlayroom()
        {
            return this.Playroom;
        }

        public void SetPlayroom(bool Playroom)
        {
            this.Playroom = Playroom;
        }

        public bool GetWithLodge()
        {
            return this.WithLodge;
        }

        public void SetWithLodge(bool WithLodge)
        {
            this.WithLodge = WithLodge;
        }

        public bool GetEverydayDiningRoom()
        {
            return this.EverydayDiningRoom;
        }

        public void SetEverydayDiningRoom(bool EverydayDiningRoom)
        {
            this.EverydayDiningRoom = EverydayDiningRoom;
        }
        #endregion
    }
}