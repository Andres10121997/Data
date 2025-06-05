namespace Data.Property.Highlights
{
    public sealed class ServiceData
    {
        #region Variables
        private bool HasInternetAccess { get; set; } // Acceso a internet
        private bool HasAirConditioning { get; set; } // Aire acondicionado
        private bool HasHeating { get; set; } // Calefacción
        private bool HasCableTV { get; set; } // TV por cable
        private bool HasTelephoneLine { get; set; } // Línea telefónica
        private bool HasNaturalGas { get; set; } // Gas natural
        private bool HasElectricGenerator { get; set; } // Generador eléctrico
        private bool HasSolarPowered { get; set; } // Con energia solar
        private bool HasWashingMachineConnection { get; set; } // Con conexión para lavarropas
        private bool HasRunningWater { get; set; } // Agua corriente
        private bool HasTank { get; set; } // Cisterna
        private bool HasBoiler { get; set; } // Caldera
        #endregion



        #region Constructor Methods
        public ServiceData()
            : base()
        {
            this.HasInternetAccess              = false;
            this.HasAirConditioning             = false;
            this.HasHeating                     = false;
            this.HasCableTV                     = false;
            this.HasTelephoneLine               = false;
            this.HasNaturalGas                  = false;
            this.HasElectricGenerator           = false;
            this.HasSolarPowered                = false;
            this.HasWashingMachineConnection    = false;
            this.HasRunningWater                = false;
            this.HasTank                        = false;
            this.HasBoiler                      = false;
        }

        public ServiceData(bool HasInternetAccess,
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
            this.HasInternetAccess              = HasInternetAccess;
            this.HasAirConditioning             = HasAirConditioning;
            this.HasHeating                     = HasHeating;
            this.HasCableTV                     = HasCableTV;
            this.HasTelephoneLine               = HasTelephoneLine;
            this.HasNaturalGas                  = HasNaturalGas;
            this.HasElectricGenerator           = HasElectricGenerator;
            this.HasSolarPowered                = HasSolarPowered;
            this.HasWashingMachineConnection    = HasWashingMachineConnection;
            this.HasRunningWater                = HasRunningWater;
            this.HasTank                        = HasTank;
            this.HasBoiler                      = HasBoiler;
        }
        #endregion



        #region Destructor Methods
        ~ServiceData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetHasInternetAccess()
        {
            return this.HasInternetAccess;
        }

        public void SetHasInternetAccess(bool HasInternetAccess)
        {
            this.HasInternetAccess = HasInternetAccess;
        }

        public bool GetHasAirConditioning()
        {
            return this.HasAirConditioning;
        }

        public void SetHasAirConditioning(bool HasAirConditioning)
        {
            this.HasAirConditioning = HasAirConditioning;
        }

        public bool GetHasHeating()
        {
            return this.HasHeating;
        }

        public void SetHasHeating(bool HasHeating)
        {
            this.HasHeating = HasHeating;
        }

        public bool GetHasCableTV()
        {
            return this.HasCableTV;
        }

        public void SetHasCableTV(bool HasCableTV)
        {
            this.HasCableTV = HasCableTV;
        }

        public bool GetHasTelephoneLine()
        {
            return this.HasTelephoneLine;
        }

        public void SetHasTelephoneLine(bool HasTelephoneLine)
        {
            this.HasTelephoneLine = HasTelephoneLine;
        }

        public bool GetHasNaturalGas()
        {
            return this.HasNaturalGas;
        }

        public void SetHasNaturalGas(bool HasNaturalGas)
        {
            this.HasNaturalGas = HasNaturalGas;
        }

        public bool GetHasElectricGenerator()
        {
            return this.HasElectricGenerator;
        }

        public void SetHasElectricGenerator(bool HasElectricGenerator)
        {
            this.HasElectricGenerator = HasElectricGenerator;
        }

        public bool GetHasSolarPowered()
        {
            return this.HasSolarPowered;
        }

        public void SetHasSolarPowered(bool HasSolarPowered)
        {
            this.HasSolarPowered = HasSolarPowered;
        }

        public bool GetHasWashingMachineConnection()
        {
            return this.HasWashingMachineConnection;
        }

        public void SetHasWashingMachineConnection(bool HasWashingMachineConnection)
        {
            this.HasWashingMachineConnection = HasWashingMachineConnection;
        }

        public bool GetHasRunningWater()
        {
            return this.HasRunningWater;
        }

        public void SetHasRunningWater(bool HasRunningWater)
        {
            this.HasRunningWater = HasRunningWater;
        }

        public bool GetHasTank()
        {
            return this.HasTank;
        }

        public void SetHasTank(bool HasTank)
        {
            this.HasTank = HasTank;
        }

        public bool GetHasBoiler()
        {
            return this.HasBoiler;
        }

        public void SetHasBoiler(bool HasBoiler)
        {
            this.HasBoiler = HasBoiler;
        }
        #endregion
    }
}