using Data.Account;
using System;

namespace Data.Property
{
    public sealed class RentData
    {
        #region Variables
        private DateOnly StartDate { get; set; }
        private DateOnly EndDate { get; set; }
        private float RentAmount { get; set; }
        private float DepositAmount { get; set; }
        #endregion

        #region Objects
        private PersonData Person { get; set; }
        private PropertyData Property { get; set; }
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
            this.Person = new PersonData();
            this.Property = new PropertyData();
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
            #region Exception
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: RentAmount);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: DepositAmount);
            #endregion

            #region Variables
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.RentAmount = RentAmount;
            this.DepositAmount = DepositAmount;
            #endregion

            #region Objects
            this.Person = Person;
            this.Property = Property;
            #endregion
        }
        #endregion



        #region Destructor Methods
        ~RentData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public DateOnly GetStartDate()
        {
            return this.StartDate;
        }
        
        public void SetStartDate(DateOnly StartDate)
        {
            this.StartDate = StartDate;
        }

        public DateOnly GetEndDate()
        {
            return this.EndDate;
        }
        
        public void SetEndDate(DateOnly EndDate)
        {
            this.EndDate = EndDate;
        }

        public float GetRentAmount()
        {
            return this.RentAmount;
        }

        public void SetRentAmount(float RentAmount)
        {
            if (float.IsNaN(f: RentAmount))
            {
                throw new ArgumentNullException(paramName: nameof(RentAmount),
                                                message: $"The parameter \"{nameof(RentAmount)}\", of the \"{nameof(RentData)}\" class, cannot be {float.NaN}.");
            }

            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: RentAmount);

            this.RentAmount = RentAmount;
        }

        public float GetDepositAmount()
        {
            return this.DepositAmount;
        }

        public void SetDepositAmount(float DepositAmount)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value: DepositAmount);
            
            this.DepositAmount = DepositAmount;
        }
        #endregion

        #region Objects
        public PersonData GetPerson()
        {
            return this.Person;
        }

        public void SetPerson(PersonData Person)
        {
            this.Person = Person;
        }

        public PropertyData GetProperty()
        {
            return this.Property;
        }

        public void SetProperty(PropertyData Property)
        {
            this.Property = Property;
        }
        #endregion
        #endregion
    }
}