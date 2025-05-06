namespace Data.Property.Highlights
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
            IsThereAlarm = false;
            IsThereConcierge = false;
            IsThereAutomaticGate = false;
            SecurityType = string.Empty;
            IsThereWithClosedCondominium = false;
            IsThereControlledAccess = false;
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
            return IsThereAlarm;
        }

        public void SetIsThereAlarm(bool Alarm)
        {
            IsThereAlarm = Alarm;
        }

        public bool GetIsThereConcierge()
        {
            return IsThereConcierge;
        }

        public void SetIsThereConcierge(bool Concierge)
        {
            IsThereConcierge = Concierge;
        }

        public bool GetIsThereAutomaticGate()
        {
            return IsThereAutomaticGate;
        }

        public void SetIsThereAutomaticGate(bool IsThereAutomaticGate)
        {
            this.IsThereAutomaticGate = IsThereAutomaticGate;
        }

        public string GetSecurityType()
        {
            return SecurityType;
        }

        public void SetSecurityType(string SecurityType)
        {
            this.SecurityType = SecurityType;
        }

        public bool GetIsThereWithClosedCondominium()
        {
            return IsThereWithClosedCondominium;
        }

        public void SetIsThereWithClosedCondominium(bool IsThereWithClosedCondominium)
        {
            this.IsThereWithClosedCondominium = IsThereWithClosedCondominium;
        }

        public bool GetIsThereControlledAccess()
        {
            return IsThereControlledAccess;
        }

        public void SetIsThereControlledAccess(bool IsThereControlledAccess)
        {
            this.IsThereControlledAccess = IsThereControlledAccess;
        }
        #endregion
    }
}