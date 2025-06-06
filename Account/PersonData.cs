using System;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Account
{
    public class PersonData
    {
        #region Variables
        private string FirstName { get; set; }
        private string? MiddleName { get; set; }
        private string FirstLastName { get; set; }
        private string? SecondLastName { get; set; }
        private DateOnly BirthDate { get; set; }
        private SexEnum Sex { get; set; }
        #endregion

        #region Enum
        public enum SexEnum : byte
        {
            Female,
            Male
        }
        #endregion



        #region Constructor Method
        public PersonData()
            : base()
        {
            #region Variables
            this.FirstName = string.Empty;
            this.MiddleName = null;
            this.FirstLastName = string.Empty;
            this.SecondLastName = null;
            this.BirthDate = new DateOnly();
            this.Sex = SexEnum.Female;
            #endregion
        }

        public PersonData(string FirstName,
                          string? MiddleName,
                          string FirstLastName,
                          string? SecondLastName,
                          DateOnly BirthDate,
                          SexEnum Sex)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: FirstName);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: FirstLastName);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: FirstName);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: FirstLastName);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: BirthDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.FirstLastName = FirstLastName;
            this.SecondLastName = SecondLastName;
            this.BirthDate = BirthDate;
            this.Sex = Sex;
            #endregion
        }
        #endregion



        #region Destroyer Method
        ~PersonData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string GetFirstName()
        {
            return this.FirstName;
        }

        public void SetFirstName(string FirstName)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: FirstName);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: FirstName);

            this.FirstName = FirstName.Trim();
        }

        public string? GetMiddleName()
        {
            return this.MiddleName;
        }

        public void SetMiddleName(string? MiddleName)
        {
            this.MiddleName = MiddleName?.Trim();
        }

        public string GetFirstLastName()
        {
            return this.FirstLastName;
        }

        public void SetFirstLastName(string FirstLastName)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(argument: FirstLastName);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: FirstLastName);
            
            this.FirstLastName = FirstLastName.Trim();
        }

        public string? GetSecondLastName()
        {
            return this.SecondLastName;
        }

        public void SetSecondLastName(string? SecondLastName)
        {
            this.SecondLastName = SecondLastName?.Trim();
        }

        public DateOnly GetBirthDate()
        {
            return this.BirthDate;
        }

        public void SetBirthDate(DateOnly BirthDate)
        {
            DateOnly Today = DateOnly.FromDateTime(dateTime: DateTime.Now);

            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: BirthDate, other: Today);
            
            this.BirthDate = BirthDate;
        }

        public SexEnum GetSex()
        {
            return this.Sex;
        }

        public void SetSex(SexEnum Sex)
        {
            this.Sex = Sex;
        }
        #endregion
        #endregion



        #region Age
        public byte Age()
        {
            #region Variables
            byte Age;
            DateOnly Today;
            #endregion

            #region Arrays
            bool[] ListOfValidations = Array.Empty<bool>();
            #endregion

            Today = DateOnly.FromDateTime(dateTime: DateTime.Now);

            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: this.BirthDate, other: Today);

            Age = Convert.ToByte(value: Today.Year - this.BirthDate.Year);

            ListOfValidations = new bool[2]
            {
                this.BirthDate.Month > Today.Month,
                this.BirthDate.Month == Today.Month
                &&
                this.BirthDate.Day > Today.Day
            };

            if (ListOfValidations.AsParallel<bool>().Contains<bool>(value: true))
            {
                --Age;
            }

            return Age;
        }

        public async Task<byte> AgeAsync()
        {
            return await Task.Run<byte>(function: () => this.Age());
        }
        #endregion



        #region Full Name
        public string FullName()
        {
            #region Variables
            string Name;
            string LastName;
            string FullName;
            #endregion

            Name = (
                string.IsNullOrEmpty(value: this.MiddleName) || string.IsNullOrWhiteSpace(value: this.MiddleName)
                ?
                this.FirstName.Trim()
                :
                $"{this.FirstName.Trim()} {this.MiddleName.Trim()}"
            ).Trim();

            LastName = (
                string.IsNullOrEmpty(value: this.SecondLastName) || string.IsNullOrWhiteSpace(value: this.SecondLastName)
                ?
                this.FirstLastName.Trim()
                :
                $"{this.FirstLastName.Trim()} {this.SecondLastName.Trim()}"
            ).Trim();

            FullName = string.Concat(Name, " ", LastName);

            return FullName;
        }

        public async Task<string> FirstNameAsync()
        {
            return await Task.Run<string>(function: () => this.FullName());
        }
        #endregion
    }
}