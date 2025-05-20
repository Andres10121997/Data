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
        #endregion



        #region Constructor Methods
        public RentData()
            : base()
        {
            this.RentAmount = float.NaN;
            this.StartDate = new DateOnly();
            this.EndDate = new DateOnly();
            this.Person = new PersonData();
        }

        public RentData(float RentAmount,
                        DateOnly StartDate,
                        DateOnly EndDate,
                        PersonData Person)
            : base()
        {
            this.RentAmount = RentAmount;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Person = Person;
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
        #endregion
        #endregion
    }
}