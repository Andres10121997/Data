namespace Data.Property.Highlights
{
    public class EquipmentData
    {
        #region Variables
        private bool IsThereChimney { get; set; } // Chimenea
        private bool IsThereGym { get; set; } // Gimnasio
        private bool IsThereJacuzzi { get; set; } // Jacuzzi
        private bool IsThereVisitorParking { get; set; } // Visitor parking
        private bool IsThereCinemaArea { get; set; } // Área de cine
        private bool IsThereChildrensPlayArea { get; set; } // Área de juegos infantiles | Children's play area
        private bool IsThereWithGreenArea { get; set; } // Con área verde
        private bool IsThereElevator { get; set; } // Ascensor
        private bool IsThereBasketballCourt { get; set; } // Cancha de básquetbol
        private bool IsThereSoccerField { get; set; } // Cancha de fútbol
        private bool IsTherePaddleCourt { get; set; } // Cancha de paddle
        private bool IsThereTennisCourt { get; set; } // Cancha de tenis
        private bool IsThereMultiSportCourt { get; set; } // Cancha polideportiva | Multi-sport court
        private bool IsTherePartyHall { get; set; } // Salón de fiestas
        private bool IsThereSauna { get; set; } // Sauna
        #endregion



        #region ConstructorMethods
        public EquipmentData()
            : base()
        {
            this.IsThereChimney = false;
            this.IsThereGym = false;
            this.IsThereJacuzzi = false;
            this.IsThereVisitorParking = false;
            this.IsThereCinemaArea = false;
            this.IsThereChildrensPlayArea = false;
            this.IsThereWithGreenArea = false;
            this.IsThereElevator = false;
            this.IsThereBasketballCourt = false;
            this.IsThereSoccerField = false;
            this.IsTherePaddleCourt = false;
            this.IsThereTennisCourt = false;
            this.IsThereMultiSportCourt = false;
            this.IsTherePartyHall = false;
            this.IsThereSauna = false;
        }

        public EquipmentData(bool IsThereChimney,
                                         bool IsThereGym,
                                         bool IsThereJacuzzi,
                                         bool IsThereVisitorParking,
                                         bool IsThereCinemaArea,
                                         bool IsThereChildrensPlayArea,
                                         bool IsThereWithGreenArea,
                                         bool IsThereElevator,
                                         bool IsThereBasketballCourt,
                                         bool IsThereSoccerField,
                                         bool IsTherePaddleCourt,
                                         bool IsThereTennisCourt,
                                         bool IsThereMultiSportCourt,
                                         bool IsTherePartyHall,
                                         bool IsThereSauna)
            : base()
        {
            this.IsThereChimney = IsThereChimney;
            this.IsThereGym = IsThereGym;
            this.IsThereJacuzzi = IsThereJacuzzi;
            this.IsThereVisitorParking = IsThereVisitorParking;
            this.IsThereCinemaArea = IsThereCinemaArea;
            this.IsThereChildrensPlayArea = IsThereChildrensPlayArea;
            this.IsThereWithGreenArea = IsThereWithGreenArea;
            this.IsThereElevator = IsThereElevator;
            this.IsThereBasketballCourt = IsThereBasketballCourt;
            this.IsThereSoccerField = IsThereSoccerField;
            this.IsTherePaddleCourt = IsTherePaddleCourt;
            this.IsThereTennisCourt = IsThereTennisCourt;
            this.IsThereMultiSportCourt = IsThereMultiSportCourt;
            this.IsTherePartyHall = IsTherePartyHall;
            this.IsThereSauna = IsThereSauna;
        }
        #endregion



        #region DestructorMethods
        ~EquipmentData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetIsThereChimney()
        {
            return this.IsThereChimney;
        }

        public void SetIsThereChimney(bool IsThereChimney)
        {
            this.IsThereChimney = IsThereChimney;
        }

        public bool GetIsThereGym()
        {
            return this.IsThereGym;
        }

        public void SetIsThereGym(bool IsThereGym)
        {
            this.IsThereGym = IsThereGym;
        }

        public bool GetIsThereJacuzzi()
        {
            return this.IsThereJacuzzi;
        }

        public void SetIsThereJacuzzi(bool IsThereJacuzzi)
        {
            this.IsThereJacuzzi = IsThereJacuzzi;
        }

        public bool GetIsThereVisitorParking()
        {
            return this.IsThereVisitorParking;
        }

        public void SetIsThereVisitorParking(bool IsThereVisitorParking)
        {
            this.IsThereVisitorParking = IsThereVisitorParking;
        }

        public bool GetIsThereCinemaArea()
        {
            return this.IsThereCinemaArea;
        }

        public void SetIsThereCinemaArea(bool IsThereCinemaArea)
        {
            this.IsThereCinemaArea = IsThereCinemaArea;
        }

        public bool GetIsThereChildrensPlayArea()
        {
            return this.IsThereChildrensPlayArea;
        }

        public void SetIsThereChildrensPlayArea(bool IsThereChildrensPlayArea)
        {
            this.IsThereChildrensPlayArea = IsThereChildrensPlayArea;
        }

        public bool GetIsThereWithGreenArea()
        {
            return this.IsThereWithGreenArea;
        }

        public void SetIsThereWithGreenArea(bool IsThereWithGreenArea)
        {
            this.IsThereWithGreenArea = IsThereWithGreenArea;
        }

        public bool GetIsThereElevator()
        {
            return this.IsThereElevator;
        }

        public void SetIsThereElevator(bool IsThereElevator)
        {
            this.IsThereElevator = IsThereElevator;
        }

        public bool GetIsThereBasketballCourt()
        {
            return this.IsThereBasketballCourt;
        }

        public void SetIsThereBasketballCourt(bool IsThereBasketballCourt)
        {
            this.IsThereBasketballCourt = IsThereBasketballCourt;
        }

        public bool GetIsThereSoccerField()
        {
            return this.IsThereSoccerField;
        }

        public void SetIsThereSoccerField(bool IsThereSoccerField)
        {
            this.IsThereSoccerField = IsThereSoccerField;
        }

        public bool GetIsTherePaddleCourt()
        {
            return this.IsTherePaddleCourt;
        }

        public void SetIsTherePaddleCourt(bool IsTherePaddleCourt)
        {
            this.IsTherePaddleCourt = IsTherePaddleCourt;
        }

        public bool GetIsThereTennisCourt()
        {
            return this.IsThereTennisCourt;
        }

        public void SetIsThereTennisCourt(bool IsThereTennisCourt)
        {
            this.IsThereTennisCourt = IsThereTennisCourt;
        }

        public bool GetIsThereMultiSportCourt()
        {
            return this.IsThereMultiSportCourt;
        }

        public void SetIsThereMultiSportCourt(bool IsThereMultiSportCourt)
        {
            this.IsThereMultiSportCourt = IsThereMultiSportCourt;
        }

        public bool GetIsTherePartyHall()
        {
            return this.IsTherePartyHall;
        }

        public void SetIsTherePartyHall(bool IsTherePartyHall)
        {
            this.IsTherePartyHall = IsTherePartyHall;
        }

        public bool GetIsThereSauna()
        {
            return this.IsThereSauna;
        }

        public void SetIsThereSauna(bool IsThereSauna)
        {
            this.IsThereSauna = IsThereSauna;
        }
        #endregion
    }
}