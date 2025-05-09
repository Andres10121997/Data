namespace Data.Property.Highlights
{
    public class SecurityData
    {
        #region Variables
        private bool HasAlarm { get; set; } // Alarma
        private bool HasConcierge { get; set; } // Conserjería
        private bool HasAutomaticGate { get; set; } // Portón automático
        private string SecurityType { get; set; } // Tipo de seguridad (vigilancia con camaras municipales y guardia)
        private bool HasWithClosedCondominium { get; set; } // Con condominio cerrado
        private bool HasControlledAccess { get; set; } // Acceso controlado
        #endregion



        #region ConstructorMethods
        public SecurityData()
            : base()
        {
            this.HasAlarm = false;
            this.HasConcierge = false;
            this.HasAutomaticGate = false;
            this.SecurityType = string.Empty;
            this.HasWithClosedCondominium = false;
            this.HasControlledAccess = false;
        }

        public SecurityData(bool HasAlarm,
                            bool HasConcierge,
                            bool HasAutomaticGate,
                            string SecurityType,
                            bool HasWithClosedCondominium,
                            bool HasControlledAccess)
            : base()
        {
            this.HasAlarm = HasAlarm;
            this.HasConcierge = HasConcierge;
            this.HasAutomaticGate = HasAutomaticGate;
            this.SecurityType = SecurityType;
            this.HasWithClosedCondominium = HasWithClosedCondominium;
            this.HasControlledAccess = HasControlledAccess;
        }
        #endregion



        #region DestructorMethods
        ~SecurityData()
        {

        }
        #endregion



        #region Getters and Setters
        public bool GetHasAlarm()
        {
            return this.HasAlarm;
        }

        public void SetHasAlarm(bool HasAlarm)
        {
            this.HasAlarm = HasAlarm;
        }

        public bool GetHasConcierge()
        {
            return this.HasConcierge;
        }

        public void SetHasConcierge(bool HasConcierge)
        {
            this.HasConcierge = HasConcierge;
        }

        public bool GetHasAutomaticGate()
        {
            return this.HasAutomaticGate;
        }

        public void SetHasAutomaticGate(bool HasAutomaticGate)
        {
            this.HasAutomaticGate = HasAutomaticGate;
        }

        public string GetSecurityType()
        {
            return this.SecurityType;
        }

        public void SetSecurityType(string SecurityType)
        {
            this.SecurityType = SecurityType;
        }

        public bool GetHasWithClosedCondominium()
        {
            return this.HasWithClosedCondominium;
        }

        public void SetHasWithClosedCondominium(bool HasWithClosedCondominium)
        {
            this.HasWithClosedCondominium = HasWithClosedCondominium;
        }

        public bool GetHasControlledAccess()
        {
            return this.HasControlledAccess;
        }

        public void SetHasControlledAccess(bool HasControlledAccess)
        {
            this.HasControlledAccess = HasControlledAccess;
        }
        #endregion
    }
}