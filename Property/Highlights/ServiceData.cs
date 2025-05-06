namespace Data.Property.Highlights
{
    public class ServiceData
    {
        #region Variables
        private bool InternetAccess { get; set; } // Acceso a internet
        private bool AirConditioning { get; set; } // Aire acondicionado
        private bool Heating { get; set; } // Calefacción
        private bool CableTV { get; set; } // TV por cable
        private bool TelephoneLine { get; set; } // Línea telefónica
        private bool NaturalGas { get; set; } // Gas natural
        private bool ElectricGenerator { get; set; } // Generador eléctrico
        private bool SolarPowered { get; set; } // Con energia solar
        private bool WithWashingMachineConnection { get; set; } // Con conexión para lavarropas
        private bool RunningWater { get; set; } // Agua corriente
        private bool Tank { get; set; } // Cisterna
        private bool Boiler { get; set; } // Caldera
        #endregion



        #region ConstructorMethods
        public ServiceData()
            : base()
        {
            this.InternetAccess = false;
            this.AirConditioning = false;
            this.Heating = false;
            this.CableTV = false;
            this.TelephoneLine = false;
            this.NaturalGas = false;
            this.ElectricGenerator = false;
            this.SolarPowered = false;
            this.WithWashingMachineConnection = false;
            this.RunningWater = false;
            this.Tank = false;
            this.Boiler = false;
        }

        public ServiceData(bool InternetAccess,
                           bool AirConditioning,
                           bool Heating,
                           bool CableTV,
                           bool TelephoneLine,
                           bool NaturalGas,
                           bool ElectricGenerator,
                           bool SolarPowered,
                           bool WithWashingMachineConnection,
                           bool RunningWater,
                           bool Tank,
                           bool Boiler)
            : base()
        {
            this.InternetAccess = InternetAccess;
            this.AirConditioning = AirConditioning;
            this.Heating = Heating;
            this.CableTV = CableTV;
            this.TelephoneLine = TelephoneLine;
            this.NaturalGas = NaturalGas;
            this.ElectricGenerator = ElectricGenerator;
            this.SolarPowered = SolarPowered;
            this.WithWashingMachineConnection = WithWashingMachineConnection;
            this.RunningWater = RunningWater;
            this.Tank = Tank;
            this.Boiler = Boiler;
        }
        #endregion



        #region DestructorMethods
        ~ServiceData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetInternetAccess()
        {
            return this.InternetAccess;
        }

        public void SetInternetAccess(bool InternetAccess)
        {
            this.InternetAccess = InternetAccess;
        }

        public bool GetAirConditioning()
        {
            return this.AirConditioning;
        }

        public void SetAirConditioning(bool AirConditioning)
        {
            this.AirConditioning = AirConditioning;
        }

        public bool GetHeating()
        {
            return this.Heating;
        }

        public void SetHeating(bool Heating)
        {
            this.Heating = Heating;
        }

        public bool GetCableTV()
        {
            return this.CableTV;
        }

        public void SetCableTV(bool CableTV)
        {
            this.CableTV = CableTV;
        }

        public bool GetTelephoneLine()
        {
            return this.TelephoneLine;
        }

        public void SetTelephoneLine(bool TelephoneLine)
        {
            this.TelephoneLine = TelephoneLine;
        }

        public bool GetNaturalGas()
        {
            return this.NaturalGas;
        }

        public void SetNaturalGas(bool NaturalGas)
        {
            this.NaturalGas = NaturalGas;
        }

        public bool GetElectricGenerator()
        {
            return this.ElectricGenerator;
        }

        public void SetElectricGenerator(bool ElectricGenerator)
        {
            this.ElectricGenerator = ElectricGenerator;
        }

        public bool GetSolarPowered()
        {
            return this.SolarPowered;
        }

        public void SetSolarPowered(bool SolarPowered)
        {
            this.SolarPowered = SolarPowered;
        }

        public bool GetWithWashingMachineConnection()
        {
            return this.WithWashingMachineConnection;
        }

        public void SetWithWashingMachineConnection(bool WithWashingMachineConnection)
        {
            this.WithWashingMachineConnection = WithWashingMachineConnection;
        }

        public bool GetRunningWater()
        {
            return this.RunningWater;
        }

        public void SetRunningWater(bool RunningWater)
        {
            this.RunningWater = RunningWater;
        }

        public bool GetTank()
        {
            return this.Tank;
        }

        public void SetTank(bool Tank)
        {
            this.Tank = Tank;
        }

        public bool GetBoiler()
        {
            return this.Boiler;
        }

        public void SetBoiler(bool Boiler)
        {
            this.Boiler = Boiler;
        }
        #endregion
    }
}