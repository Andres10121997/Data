namespace Data.Property
{
    public class SecurityData
    {
        #region Variables
        private bool IsThereAlarm { get; set; } // Alarma
        private bool IsThereConcierge { get; set; } // Conserjería
        private bool IsThereAutomaticGate { get; set; } // Portón automático
        private string SecurityType { get; set; } // Tipo de seguridad (vigilancia con camaras municipales y guardia)
        private bool IsThereWithClosedCondominium { get; set; } // Con condominio cerrado
        private bool IsThereControlledAccess { get; set; } // Acceso controlado
        #endregion



        #region ConstructorMethods
        public SecurityData()
            : base()
        {
            this.IsThereAlarm = false;
            this.IsThereConcierge = false;
            this.IsThereAutomaticGate = false;
            this.SecurityType = string.Empty;
            this.IsThereWithClosedCondominium = false;
            this.IsThereControlledAccess = false;
        }

        public SecurityData(bool IsThereAlarm,
                            bool IsThereConcierge,
                            bool IsThereAutomaticGate,
                            string SecurityType,
                            bool IsThereWithClosedCondominium,
                            bool IsThereControlledAccess)
            : base()
        {
            this.IsThereAlarm = IsThereAlarm;
            this.IsThereConcierge = IsThereConcierge;
            this.IsThereAutomaticGate = IsThereAutomaticGate;
            this.SecurityType = SecurityType;
            this.IsThereWithClosedCondominium = IsThereWithClosedCondominium;
            this.IsThereControlledAccess = IsThereControlledAccess;
        }
        #endregion



        #region DestructorMethods
        ~SecurityData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetIsThereAlarm()
        {
            return this.IsThereAlarm;
        }

        public void SetIsThereAlarm(bool Alarm)
        {
            this.IsThereAlarm = Alarm;
        }

        public bool GetIsThereConcierge()
        {
            return this.IsThereConcierge;
        }

        public void SetIsThereConcierge(bool Concierge)
        {
            this.IsThereConcierge = Concierge;
        }

        public bool GetIsThereAutomaticGate()
        {
            return this.IsThereAutomaticGate;
        }

        public void SetIsThereAutomaticGate(bool IsThereAutomaticGate)
        {
            this.IsThereAutomaticGate = IsThereAutomaticGate;
        }

        public string GetSecurityType()
        {
            return this.SecurityType;
        }

        public void SetSecurityType(string SecurityType)
        {
            this.SecurityType = SecurityType;
        }

        public bool GetIsThereWithClosedCondominium()
        {
            return this.IsThereWithClosedCondominium;
        }

        public void SetIsThereWithClosedCondominium(bool IsThereWithClosedCondominium)
        {
            this.IsThereWithClosedCondominium = IsThereWithClosedCondominium;
        }

        public bool GetIsThereControlledAccess()
        {
            return this.IsThereControlledAccess;
        }

        public void SetIsThereControlledAccess(bool IsThereControlledAccess)
        {
            this.IsThereControlledAccess = IsThereControlledAccess;
        }
        #endregion
    }
}