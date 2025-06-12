namespace Data.Property.Highlights
{
    public sealed class EquipmentDTO
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
        public EquipmentDTO()
            : base()
        {
            this.HasChimney = false;
            this.HasGym = false;
            this.HasJacuzzi = false;
            this.HasVisitorParking = false;
            this.HasCinemaArea = false;
            this.HasChildrensPlayArea = false;
            this.HasWithGreenArea = false;
            this.HasElevator = false;
            this.HasBasketballCourt = false;
            this.HasSoccerField = false;
            this.HasPaddleCourt = false;
            this.HasTennisCourt = false;
            this.HasMultiSportCourt = false;
            this.HasPartyHall = false;
            this.HasSauna = false;
        }

        public EquipmentDTO(bool HasChimney,
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
            this.HasChimney = HasChimney;
            this.HasGym = HasGym;
            this.HasJacuzzi = HasJacuzzi;
            this.HasVisitorParking = HasVisitorParking;
            this.HasCinemaArea = HasCinemaArea;
            this.HasChildrensPlayArea = HasChildrensPlayArea;
            this.HasWithGreenArea = HasWithGreenArea;
            this.HasElevator = HasElevator;
            this.HasBasketballCourt = HasBasketballCourt;
            this.HasSoccerField = HasSoccerField;
            this.HasPaddleCourt = HasPaddleCourt;
            this.HasTennisCourt = HasTennisCourt;
            this.HasMultiSportCourt = HasMultiSportCourt;
            this.HasPartyHall = HasPartyHall;
            this.HasSauna = HasSauna;
        }
        #endregion



        #region Getters and Setters
        public bool HasChimney
        {
            get => this.V_HasChimney;
            set => this.V_HasChimney = value;
        }

        public bool HasGym
        {
            get => this.V_HasGym;
            set => this.V_HasGym = value;
        }

        public bool HasJacuzzi
        {
            get => this.V_HasJacuzzi;
            set => this.V_HasJacuzzi = value;
        }

        public bool HasVisitorParking
        {
            get => this.V_HasVisitorParking;
            set => this.V_HasVisitorParking = value;
        }

        public bool HasCinemaArea
        {
            get => this.V_HasCinemaArea;
            set => this.V_HasCinemaArea = value;
        }

        public bool HasChildrensPlayArea
        {
            get => this.V_HasChildrensPlayArea;
            set => this.V_HasChildrensPlayArea = value;
        }

        public bool HasWithGreenArea
        {
            get => this.V_HasWithGreenArea;
            set => this.V_HasWithGreenArea = value;
        }

        public bool HasElevator
        {
            get => this.V_HasElevator;
            set => this.V_HasElevator = value;
        }

        public bool HasBasketballCourt
        {
            get => this.V_HasBasketballCourt;
            set => this.V_HasBasketballCourt = value;
        }

        public bool HasSoccerField
        {
            get => this.V_HasSoccerField;
            set => this.V_HasSoccerField = value;
        }

        public bool HasPaddleCourt
        {
            get => this.V_HasPaddleCourt;
            set => this.V_HasPaddleCourt = value;
        }

        public bool HasTennisCourt
        {
            get => this.V_HasTennisCourt;
            set => this.V_HasTennisCourt = value;
        }

        public bool HasMultiSportCourt
        {
            get => this.V_HasMultiSportCourt;
            set => this.V_HasMultiSportCourt = value;
        }

        public bool HasPartyHall
        {
            get => this.V_HasPartyHall;
            set => this.V_HasPartyHall = value;
        }

        public bool HasSauna
        {
            get => this.V_HasSauna;
            set => this.V_HasSauna = value;
        }
        #endregion
    }
}