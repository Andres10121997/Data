namespace Data.Property.Highlights
{
    public sealed class ServiceDTO
    {
        #region Variables
        private bool V_HasInternetAccess; // Acceso a internet
        private bool V_HasAirConditioning; // Aire acondicionado
        private bool V_HasHeating; // Calefacción
        private bool V_HasCableTV; // TV por cable
        private bool V_HasTelephoneLine; // Línea telefónica
        private bool V_HasNaturalGas; // Gas natural
        private bool V_HasElectricGenerator; // Generador eléctrico
        private bool V_HasSolarPowered; // Con energia solar
        private bool V_HasWashingMachineConnection; // Con conexión para lavarropas
        private bool V_HasRunningWater; // Agua corriente
        private bool V_HasTank; // Cisterna
        private bool V_HasBoiler; // Caldera
        #endregion



        #region Constructor Methods
        public ServiceDTO()
            : base()
        {
            this.HasInternetAccess = false;
            this.HasAirConditioning = false;
            this.HasHeating = false;
            this.HasCableTV = false;
            this.HasTelephoneLine = false;
            this.HasNaturalGas = false;
            this.HasElectricGenerator = false;
            this.HasSolarPowered = false;
            this.HasWashingMachineConnection = false;
            this.HasRunningWater = false;
            this.HasTank = false;
            this.HasBoiler = false;
        }

        public ServiceDTO(bool HasInternetAccess,
                           bool HasAirConditioning,
                           bool HasHeating,
                           bool HasCableTV,
                           bool HasTelephoneLine,
                           bool HasNaturalGas,
                           bool HasElectricGenerator,
                           bool HasSolarPowered,
                           bool HasWashingMachineConnection,
                           bool HasRunningWater,
                           bool HasTank,
                           bool HasBoiler)
            : base()
        {
            this.HasInternetAccess = HasInternetAccess;
            this.HasAirConditioning = HasAirConditioning;
            this.HasHeating = HasHeating;
            this.HasCableTV = HasCableTV;
            this.HasTelephoneLine = HasTelephoneLine;
            this.HasNaturalGas = HasNaturalGas;
            this.HasElectricGenerator = HasElectricGenerator;
            this.HasSolarPowered = HasSolarPowered;
            this.HasWashingMachineConnection = HasWashingMachineConnection;
            this.HasRunningWater = HasRunningWater;
            this.HasTank = HasTank;
            this.HasBoiler = HasBoiler;
        }
        #endregion



        #region Getters and Setters
        public bool HasInternetAccess
        {
            get => this.V_HasInternetAccess;
            set => this.V_HasInternetAccess = value;
        }

        public bool HasAirConditioning
        {
            get => this.V_HasAirConditioning;
            set => this.V_HasAirConditioning = value;
        }

        public bool HasHeating
        {
            get => this.V_HasHeating;
            set => this.V_HasHeating = value;
        }

        public bool HasCableTV
        {
            get => V_HasCableTV;
            set => V_HasCableTV = value;
        }

        public bool HasTelephoneLine
        {
            get => V_HasTelephoneLine;
            set => V_HasTelephoneLine = value;
        }

        public bool HasNaturalGas
        {
            get => V_HasNaturalGas;
            set => V_HasNaturalGas = value;
        }

        public bool HasElectricGenerator
        {
            get => this.V_HasElectricGenerator;
            set => this.V_HasElectricGenerator = value;
        }

        public bool HasSolarPowered
        {
            get => this.V_HasSolarPowered;
            set => this.V_HasSolarPowered = value;
        }

        public bool HasWashingMachineConnection
        {
            get => this.V_HasWashingMachineConnection;
            set => this.V_HasWashingMachineConnection = value;
        }

        public bool HasRunningWater
        {
            get => this.V_HasRunningWater;
            set => this.V_HasRunningWater = value;
        }

        public bool HasTank
        {
            get => this.V_HasTank;
            set => this.V_HasTank = value;
        }

        public bool HasBoiler
        {
            get => this.V_HasBoiler;
            set => this.V_HasBoiler = value;
        }
        #endregion
    }
}