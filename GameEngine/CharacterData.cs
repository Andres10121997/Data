using System;

namespace Data.GameEngine
{
    public class CharacterData
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
            this.Name = Name.Trim();
            this.QuantityOfLife = QuantityOfLife;
            this.AmountOfDamage = AmountOfDamage;
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
            if (string.IsNullOrEmpty(value: Name)
                ||
                string.IsNullOrWhiteSpace(value: Name))
            {
                throw new ArgumentNullException(paramName: nameof(Name),
                                                message: ErrorMessage.ParameterIsNullOrEmptyOrWhiteSpace(ParamName: nameof(Name), ClassName: nameof(CharacterData)));
            }
            
            this.Name = Name.Trim();
        }

        public byte GetQuantityOfLife()
        {
            return this.QuantityOfLife;
        }

        public void SetQuantityOfLife(byte QuantityOfLife)
        {
            if (QuantityOfLife < 0)
            {
                throw new ArithmeticException(message: $"The \"${nameof(QuantityOfLife)}\" variable cannot be less than 0.");
            }
            
            this.QuantityOfLife = QuantityOfLife;
        }

        public byte GetAmountOfDamage()
        {
            return this.AmountOfDamage;
        }

        public void SetAmountOfDamage(byte AmountOfDamage)
        {
            if (AmountOfDamage < 0)
            {
                throw new ArithmeticException(message: $"The \"${nameof(AmountOfDamage)}\" variable cannot be less than 0.");
            }
            
            this.AmountOfDamage = AmountOfDamage;
        }
        #endregion
    }
}