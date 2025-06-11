using Data.Account;
using System;

namespace Data.Property
{
    public sealed class RentData
    {
        #region Variables
        private DateOnly V_StartDate;
        private DateOnly V_EndDate;
        private float V_RentAmount;
        private float V_DepositAmount;
        #endregion

        #region Objects
        private PersonData O_Person;
        private PropertyData O_Property;
        #endregion



        #region Constructor Methods
        public RentData()
            : base()
        {
            #region Variables
            this.StartDate = new DateOnly();
            this.EndDate = new DateOnly();
            this.RentAmount = float.NaN;
            this.DepositAmount = float.NaN;
            #endregion

            #region Objects
            this.O_Person = new PersonData();
            this.O_Property = new PropertyData();
            #endregion
        }

        public RentData(DateOnly StartDate,
                        DateOnly EndDate,
                        float RentAmount,
                        float DepositAmount,
                        PersonData Person,
                        PropertyData Property)
            : base()
        {
            #region Variables
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.RentAmount = RentAmount;
            this.DepositAmount = DepositAmount;
            #endregion

            #region Objects
            this.O_Person = Person;
            this.O_Property = Property;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public DateOnly StartDate
        {
            get => this.V_StartDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(
                    value: value,
                    other: this.EndDate
                );
                
                this.V_StartDate = value;
            }
        }

        public DateOnly EndDate
        {
            get => this.V_EndDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(
                    value: value,
                    other: this.StartDate
                );
                
                this.V_EndDate = value;
            }
        }

        public float RentAmount
        {
            get => this.V_RentAmount;
            set
            {
                ArgumentOutOfRangeException.ThrowIfEqual<float>(
                    value: value,
                    other: float.NaN
                );
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<float>(value: value);

                this.V_RentAmount = value;
            }
        }

        public float DepositAmount
        {
            get => this.V_DepositAmount;
            set
            {
                ArgumentOutOfRangeException.ThrowIfEqual<float>(
                    value: value,
                    other: float.NaN
                );
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<float>(value: value);

                this.V_DepositAmount = value;
            }
        }
        #endregion

        #region Objects
        public PersonData Person
        {
            get => this.O_Person;
            set => this.O_Person = value;
        }

        public PropertyData Property
        {
            get => this.O_Property;
            set => this.O_Property = value;
        }
        #endregion
        #endregion
    }
}