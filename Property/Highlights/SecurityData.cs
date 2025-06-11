using System;

namespace Data.Property.Highlights
{
    public sealed class SecurityData
    {
        #region Variables
        private bool V_HasAlarm; // Alarma
        private bool V_HasConcierge; // Conserjería
        private bool V_HasAutomaticGate; // Portón automático
        private string V_SecurityType; // Tipo de seguridad (vigilancia con camaras municipales y guardia)
        private bool V_HasWithClosedCondominium; // Con condominio cerrado
        private bool V_HasControlledAccess; // Acceso controlado
        #endregion



        #region Constructor Methods
        public SecurityData()
            : base()
        {
            this.V_HasAlarm = false;
            this.V_HasConcierge = false;
            this.V_HasAutomaticGate = false;
            this.V_SecurityType = string.Empty;
            this.V_HasWithClosedCondominium = false;
            this.V_HasControlledAccess = false;
        }

        public SecurityData(bool HasAlarm,
                            bool HasConcierge,
                            bool HasAutomaticGate,
                            string SecurityType,
                            bool HasWithClosedCondominium,
                            bool HasControlledAccess)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: SecurityType);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: SecurityType);
            #endregion

            #region Variables
            this.V_HasAlarm = HasAlarm;
            this.V_HasConcierge = HasConcierge;
            this.V_HasAutomaticGate = HasAutomaticGate;
            this.V_SecurityType = SecurityType;
            this.V_HasWithClosedCondominium = HasWithClosedCondominium;
            this.V_HasControlledAccess = HasControlledAccess;
            #endregion
        }
        #endregion



        #region Getters and Setters
        public bool HasAlarm
        {
            get => this.V_HasAlarm;
            set => this.V_HasAlarm = value;
        }

        public bool HasConcierge
        {
            get => this.V_HasConcierge;
            set => this.V_HasConcierge = value;
        }

        public bool HasAutomaticGate
        {
            get => this.V_HasAutomaticGate;
            set => this.V_HasAutomaticGate = value;
        }

        public string SecurityType
        {
            get => V_SecurityType;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_SecurityType = value;
            }
        }

        public bool HasWithClosedCondominium
        {
            get => this.V_HasWithClosedCondominium;
            set => this.V_HasWithClosedCondominium = value;
        }

        public bool HasControlledAccess
        {
            get => this.V_HasControlledAccess;
            set => this.V_HasControlledAccess = value;
        }
        #endregion
    }
}