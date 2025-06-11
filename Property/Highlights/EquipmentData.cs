namespace Data.Property.Highlights
{
    public sealed record EquipmentData
    {
        #region Variables
        private bool V_HasChimney; // Chimenea
        private bool V_HasGym; // Gimnasio
        private bool V_HasJacuzzi; // Jacuzzi
        private bool V_HasVisitorParking; // Visitor parking
        private bool V_HasCinemaArea; // Área de cine
        private bool V_HasChildrensPlayArea; // Área de juegos infantiles | Children's play area
        private bool V_HasWithGreenArea; // Con área verde
        private bool V_HasElevator; // Ascensor
        private bool V_HasBasketballCourt; // Cancha de básquetbol
        private bool V_HasSoccerField; // Cancha de fútbol
        private bool V_HasPaddleCourt; // Cancha de paddle
        private bool V_HasTennisCourt; // Cancha de tenis
        private bool V_HasMultiSportCourt; // Cancha polideportiva | Multi-sport court
        private bool V_HasPartyHall; // Salón de fiestas
        private bool V_HasSauna; // Sauna
        #endregion



        #region Constructor Methods
        public EquipmentData()
            : base()
        {
            this.V_HasChimney = false;
            this.V_HasGym = false;
            this.V_HasJacuzzi = false;
            this.V_HasVisitorParking = false;
            this.V_HasCinemaArea = false;
            this.V_HasChildrensPlayArea = false;
            this.V_HasWithGreenArea = false;
            this.V_HasElevator = false;
            this.V_HasBasketballCourt = false;
            this.V_HasSoccerField = false;
            this.V_HasPaddleCourt = false;
            this.V_HasTennisCourt = false;
            this.V_HasMultiSportCourt = false;
            this.V_HasPartyHall = false;
            this.V_HasSauna = false;
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
            this.V_HasChimney = HasChimney;
            this.V_HasGym = HasGym;
            this.V_HasJacuzzi = HasJacuzzi;
            this.V_HasVisitorParking = HasVisitorParking;
            this.V_HasCinemaArea = HasCinemaArea;
            this.V_HasChildrensPlayArea = HasChildrensPlayArea;
            this.V_HasWithGreenArea = HasWithGreenArea;
            this.V_HasElevator = HasElevator;
            this.V_HasBasketballCourt = HasBasketballCourt;
            this.V_HasSoccerField = HasSoccerField;
            this.V_HasPaddleCourt = HasPaddleCourt;
            this.V_HasTennisCourt = HasTennisCourt;
            this.V_HasMultiSportCourt = HasMultiSportCourt;
            this.V_HasPartyHall = HasPartyHall;
            this.V_HasSauna = HasSauna;
        }
        #endregion



        #region Getters and Setters
        public bool HasChimney
        {
            get => this.V_HasChimney;
            set
            {
                this.V_HasChimney = value;
            }
        }

        public bool HasGym
        {
            get => this.V_HasGym;
            set
            {
                this.V_HasGym = value;
            }
        }

        public bool HasJacuzzi
        {
            get => this.V_HasJacuzzi;
            set
            {
                this.V_HasJacuzzi = value;
            }
        }

        public bool HasVisitorParking
        {
            get => this.V_HasVisitorParking;
            set
            {
                this.V_HasVisitorParking = value;
            }
        }

        public bool HasCinemaArea
        {
            get => this.V_HasCinemaArea;
            set
            {
                this.V_HasCinemaArea = value;
            }
        }

        public bool HasChildrensPlayArea
        {
            get => this.V_HasChildrensPlayArea;
            set
            {
                this.V_HasChildrensPlayArea = value;
            }
        }

        public bool HasWithGreenArea
        {
            get => this.V_HasWithGreenArea;
            set
            {
                this.V_HasWithGreenArea = value;
            }
        }

        public bool HasElevator
        {
            get => this.V_HasElevator;
            set
            {
                this.V_HasElevator = value;
            }
        }

        public bool HasBasketballCourt
        {
            get => this.V_HasBasketballCourt;
            set
            {
                this.V_HasBasketballCourt = value;
            }
        }

        public bool HasSoccerField
        {
            get => this.V_HasSoccerField;
            set
            {
                this.V_HasSoccerField = value;
            }
        }

        public bool HasPaddleCourt
        {
            get => this.V_HasPaddleCourt;
            set
            {
                this.V_HasPaddleCourt = value;
            }
        }

        public bool HasTennisCourt
        {
            get => this.V_HasTennisCourt;
            set
            {
                this.V_HasTennisCourt = value;
            }
        }

        public bool HasMultiSportCourt
        {
            get => this.V_HasMultiSportCourt;
            set
            {
                this.V_HasMultiSportCourt = value;
            }
        }

        public bool HasPartyHall
        {
            get => this.V_HasPartyHall;
            set
            {
                this.V_HasPartyHall = value;
            }
        }

        public bool HasSauna
        {
            get => this.V_HasSauna;
            set
            {
                this.V_HasSauna = value;
            }
        }
        #endregion
    }
}