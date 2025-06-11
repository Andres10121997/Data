using System;

namespace Data.GameEngine
{
    public sealed class CharacterData
    {
        #region Variables
        private string V_Name;
        private byte V_QuantityOfLife;
        private byte V_AmountOfDamage;
        #endregion



        #region Constructor Method
        public CharacterData()
            : base()
        {
            this.V_Name = string.Empty;
            this.V_QuantityOfLife = byte.MinValue;
            this.V_AmountOfDamage = byte.MinValue;
        }

        public CharacterData(string Name,
                             byte QuantityOfLife,
                             byte AmountOfDamage)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            ArgumentOutOfRangeException.ThrowIfNegative(value: QuantityOfLife);
            ArgumentOutOfRangeException.ThrowIfNegative(value: AmountOfDamage);
            #endregion

            #region Variables
            this.V_Name = Name.Trim();
            this.V_QuantityOfLife = QuantityOfLife;
            this.V_AmountOfDamage = AmountOfDamage;
            #endregion
        }
        #endregion



        #region Getters and Setters
        public string Name
        {
            get => this.V_Name;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Name = value.Trim();
            }
        }

        public byte QuantityOfLife
        {
            get => this.V_QuantityOfLife;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative<byte>(value: value);

                this.V_QuantityOfLife = value;
            }
        }

        public byte AmountOfDamage
        {
            get => this.V_AmountOfDamage;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative<byte>(value: value);

                this.V_AmountOfDamage = value;
            }
        }
        #endregion
    }
}