using System;

namespace Data.Economy
{
    public sealed class CurrencyDTO
    {
        #region Variables
        private DateOnly V_Date;
        private string V_WeekdayName;
        private float V_Currency;
        #endregion



        #region Constructor Method
        public CurrencyDTO()
            : base()
        {
            this.V_Date = new DateOnly();
            this.V_WeekdayName = string.Empty;
            this.V_Currency = 0;
        }
        #endregion



        #region Getters and Setters
        public required DateOnly Date
        {
            get => this.V_Date;
            set => this.V_Date = value;
        }

        public required string WeekdayName
        {
            get => this.V_WeekdayName;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);
                
                this.V_WeekdayName = value;
            }
        }

        public required float Currency
        {
            get => this.V_Currency;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<float>(value: value);
                
                this.V_Currency = value;
            }
        }
        #endregion
    }
}