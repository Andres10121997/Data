using System;

namespace Data.GameEngine
{
    public sealed class CharacterData
    {
        #region Variables
        private string Name { get; set; }
        private byte QuantityOfLife { get; set; }
        private byte AmountOfDamage { get; set; }
        #endregion



        #region Constructor Method
        public CharacterData()
            : base()
        {
            this.Name = string.Empty;
            this.QuantityOfLife = byte.MinValue;
            this.AmountOfDamage = byte.MinValue;
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
            this.Name = Name.Trim();
            this.QuantityOfLife = QuantityOfLife;
            this.AmountOfDamage = AmountOfDamage;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~CharacterData()
        {

        }
        #endregion



        #region Getters and Setters
        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Name);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Name);
            
            this.Name = Name.Trim();
        }

        public byte GetQuantityOfLife()
        {
            return this.QuantityOfLife;
        }

        public void SetQuantityOfLife(byte QuantityOfLife)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value: QuantityOfLife);

            this.QuantityOfLife = QuantityOfLife;
        }

        public byte GetAmountOfDamage()
        {
            return this.AmountOfDamage;
        }

        public void SetAmountOfDamage(byte AmountOfDamage)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value: AmountOfDamage);
            
            this.AmountOfDamage = AmountOfDamage;
        }
        #endregion
    }
}