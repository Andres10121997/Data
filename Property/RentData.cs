using Data.Account;
using System;

namespace Data.Property
{
    public class RentData
    {
        #region Variables
        private float RentAmount { get; set; }
        private DateOnly StartDate { get; set; }
        private DateOnly EndDate { get; set; }
        #endregion

        #region Objects
        private PersonData Person { get; set; }
        private PropertyData Property { get; set; }
        #endregion



        #region Constructor Methods
        public RentData()
            : base()
        {
            this.RentAmount = float.NaN;
            this.StartDate = new DateOnly();
            this.EndDate = new DateOnly();
            this.Person = new PersonData();
            this.Property = new PropertyData();
        }

        public RentData(float RentAmount,
                        DateOnly StartDate,
                        DateOnly EndDate,
                        PersonData Person,
                        PropertyData Property)
            : base()
        {
            this.RentAmount = RentAmount;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Person = Person;
            this.Property = Property;
        }
        #endregion



        #region Destructor Methods
        ~RentData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
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
            else
            if (float.IsNegative(f: RentAmount))
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(RentAmount),
                                                      message: $"The \"{nameof(RentAmount)}\" parameter of the \"{nameof(RentData)}\" class cannot be a negative number.");
            }

            this.RentAmount = RentAmount;
        }
        
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