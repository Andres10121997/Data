namespace Data.Property.Highlights
{
    public class EquipmentData
    {
        #region Variables
        private bool HasChimney { get; set; } // Chimenea
        private bool HasGym { get; set; } // Gimnasio
        private bool HasJacuzzi { get; set; } // Jacuzzi
        private bool HasVisitorParking { get; set; } // Visitor parking
        private bool HasCinemaArea { get; set; } // Área de cine
        private bool HasChildrensPlayArea { get; set; } // Área de juegos infantiles | Children's play area
        private bool HasWithGreenArea { get; set; } // Con área verde
        private bool HasElevator { get; set; } // Ascensor
        private bool HasBasketballCourt { get; set; } // Cancha de básquetbol
        private bool HasSoccerField { get; set; } // Cancha de fútbol
        private bool HasPaddleCourt { get; set; } // Cancha de paddle
        private bool HasTennisCourt { get; set; } // Cancha de tenis
        private bool HasMultiSportCourt { get; set; } // Cancha polideportiva | Multi-sport court
        private bool HasPartyHall { get; set; } // Salón de fiestas
        private bool HasSauna { get; set; } // Sauna
        #endregion



        #region Constructor Methods
        public EquipmentData()
            : base()
        {
            this.HasChimney             = false;
            this.HasGym                 = false;
            this.HasJacuzzi             = false;
            this.HasVisitorParking      = false;
            this.HasCinemaArea          = false;
            this.HasChildrensPlayArea   = false;
            this.HasWithGreenArea       = false;
            this.HasElevator            = false;
            this.HasBasketballCourt     = false;
            this.HasSoccerField         = false;
            this.HasPaddleCourt         = false;
            this.HasTennisCourt         = false;
            this.HasMultiSportCourt     = false;
            this.HasPartyHall           = false;
            this.HasSauna               = false;
        }

        public EquipmentData(bool HasChimney,
                             bool HasGym,
                             bool HasJacuzzi,
                             bool HasVisitorParking,
                             bool HasCinemaArea,
                             bool HasChildrensPlayArea,
                             bool HasWithGreenArea,
                             bool HasElevator,
                             bool HasBasketballCourt,
                             bool HasSoccerField,
                             bool HasPaddleCourt,
                             bool HasTennisCourt,
                             bool HasMultiSportCourt,
                             bool HasPartyHall,
                             bool HasSauna)
            : base()
        {
            this.HasChimney             = HasChimney;
            this.HasGym                 = HasGym;
            this.HasJacuzzi             = HasJacuzzi;
            this.HasVisitorParking      = HasVisitorParking;
            this.HasCinemaArea          = HasCinemaArea;
            this.HasChildrensPlayArea   = HasChildrensPlayArea;
            this.HasWithGreenArea       = HasWithGreenArea;
            this.HasElevator            = HasElevator;
            this.HasBasketballCourt     = HasBasketballCourt;
            this.HasSoccerField         = HasSoccerField;
            this.HasPaddleCourt         = HasPaddleCourt;
            this.HasTennisCourt         = HasTennisCourt;
            this.HasMultiSportCourt     = HasMultiSportCourt;
            this.HasPartyHall           = HasPartyHall;
            this.HasSauna               = HasSauna;
        }
        #endregion



        #region Destructor Methods
        ~EquipmentData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetHasChimney()
        {
            return this.HasChimney;
        }

        public void SetHasChimney(bool HasChimney)
        {
            this.HasChimney = HasChimney;
        }

        public bool GetHasGym()
        {
            return this.HasGym;
        }

        public void SetHasGym(bool HasGym)
        {
            this.HasGym = HasGym;
        }

        public bool GetHasJacuzzi()
        {
            return this.HasJacuzzi;
        }

        public void SetHasJacuzzi(bool HasJacuzzi)
        {
            this.HasJacuzzi = HasJacuzzi;
        }

        public bool GetHasVisitorParking()
        {
            return this.HasVisitorParking;
        }

        public void SetHasVisitorParking(bool HasVisitorParking)
        {
            this.HasVisitorParking = HasVisitorParking;
        }

        public bool GetHasCinemaArea()
        {
            return this.HasCinemaArea;
        }

        public void SetHasCinemaArea(bool HasCinemaArea)
        {
            this.HasCinemaArea = HasCinemaArea;
        }

        public bool GetHasChildrensPlayArea()
        {
            return this.HasChildrensPlayArea;
        }

        public void SetHasChildrensPlayArea(bool HasChildrensPlayArea)
        {
            this.HasChildrensPlayArea = HasChildrensPlayArea;
        }

        public bool GetHasWithGreenArea()
        {
            return this.HasWithGreenArea;
        }

        public void SetIsThereWithGreenArea(bool HasWithGreenArea)
        {
            this.HasWithGreenArea = HasWithGreenArea;
        }

        public bool GetHasElevator()
        {
            return this.HasElevator;
        }

        public void SetHasElevator(bool HasElevator)
        {
            this.HasElevator = HasElevator;
        }

        public bool GetHasBasketballCourt()
        {
            return this.HasBasketballCourt;
        }

        public void SetHasBasketballCourt(bool HasBasketballCourt)
        {
            this.HasBasketballCourt = HasBasketballCourt;
        }

        public bool GetHasSoccerField()
        {
            return this.HasSoccerField;
        }

        public void SetHasSoccerField(bool HasSoccerField)
        {
            this.HasSoccerField = HasSoccerField;
        }

        public bool GetHasPaddleCourt()
        {
            return this.HasPaddleCourt;
        }

        public void SetHasPaddleCourt(bool HasPaddleCourt)
        {
            this.HasPaddleCourt = HasPaddleCourt;
        }

        public bool GetHasTennisCourt()
        {
            return this.HasTennisCourt;
        }

        public void SetHasTennisCourt(bool HasTennisCourt)
        {
            this.HasTennisCourt = HasTennisCourt;
        }

        public bool GetHasMultiSportCourt()
        {
            return this.HasMultiSportCourt;
        }

        public void SetHasMultiSportCourt(bool HasMultiSportCourt)
        {
            this.HasMultiSportCourt = HasMultiSportCourt;
        }

        public bool GetHasPartyHall()
        {
            return this.HasPartyHall;
        }

        public void SetHasPartyHall(bool HasPartyHall)
        {
            this.HasPartyHall = HasPartyHall;
        }

        public bool GetHasSauna()
        {
            return this.HasSauna;
        }

        public void SetHasSauna(bool HasSauna)
        {
            this.HasSauna = HasSauna;
        }
        #endregion
    }
}