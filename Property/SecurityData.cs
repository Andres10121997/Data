namespace Data.Property
{
    public class SecurityData
    {
        #region Variables
        private bool Alarm { get; set; } // Alarma
        private bool Concierge { get; set; } // Conserjería
        private bool AutomaticGate { get; set; } // Portón automático
        private string SecurityType { get; set; } // Tipo de seguridad (vigilancia con camaras municipales y guardia)
        private bool WithClosedCondominium { get; set; } // Con condominio cerrado
        private bool ControlledAccess { get; set; } // Acceso controlado
        #endregion



        #region ConstructorMethods
        public SecurityData()
            : base()
        {
            this.Alarm = false;
            this.Concierge = false;
            this.AutomaticGate = false;
            this.SecurityType = string.Empty;
            this.WithClosedCondominium = false;
            this.ControlledAccess = false;
        }

        public SecurityData(bool Alarm,
                            bool Concierge,
                            bool AutomaticGate,
                            string SecurityType,
                            bool WithClosedCondominium,
                            bool ControlledAccess)
            : base()
        {
            this.Alarm = Alarm;
            this.Concierge = Concierge;
            this.AutomaticGate = AutomaticGate;
            this.SecurityType = SecurityType;
            this.WithClosedCondominium = WithClosedCondominium;
            this.ControlledAccess = ControlledAccess;
        }
        #endregion



        #region DestructorMethods
        ~SecurityData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetAlarm()
        {
            return this.Alarm;
        }

        public void SetAlarm(bool Alarm)
        {
            this.Alarm |= Alarm;
        }

        public bool GetConcierge()
        {
            return this.Concierge;
        }

        public void SetConcierge(bool Concierge)
        {
            this.Concierge = Concierge;
        }

        public bool GetAutomaticGate()
        {
            return this.AutomaticGate;
        }

        public void SetAutomaticGate(bool AutomaticGate)
        {
            this.AutomaticGate = AutomaticGate;
        }

        public string GetSecurityType()
        {
            return this.SecurityType;
        }

        public void SetSecurityType(string SecurityType)
        {
            this.SecurityType = SecurityType;
        }

        public bool GetWithClosedCondominium()
        {
            return this.WithClosedCondominium;
        }

        public void SetWithClosedCondominium(bool WithClosedCondominium)
        {
            this.WithClosedCondominium = WithClosedCondominium;
        }

        public bool GetControlledAccess()
        {
            return this.ControlledAccess;
        }

        public void SetControlledAccess(bool ControlledAccess)
        {
            this.ControlledAccess = ControlledAccess;
        }
        #endregion
    }
}