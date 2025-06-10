using System;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Account
{
    public class PersonData
    {
        #region Variables
        private string _FirstName;
        private string? _MiddleName;
        private string _FirstLastName;
        private string? _SecondLastName;
        private DateOnly _BirthDate;
        private SexEnum _Sex;
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
            this._FirstName = string.Empty;
            this._MiddleName = null;
            this._FirstLastName = string.Empty;
            this._SecondLastName = null;
            this._BirthDate = new DateOnly();
            this._Sex = SexEnum.Female;
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
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: FirstName);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: FirstLastName);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: FirstLastName);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value: BirthDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this._FirstName = FirstName;
            this._MiddleName = MiddleName;
            this._FirstLastName = FirstLastName;
            this._SecondLastName = SecondLastName;
            this._BirthDate = BirthDate;
            this._Sex = Sex;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string FirstName
        {
            get => this._FirstName;

            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this._FirstName = value.Trim();
            }
        }

        public string? MiddleName
        {
            get => this._MiddleName;
            set
            {
                this._MiddleName = value?.Trim();
            }
        }

        public string FirstLastName
        {
            get => this._FirstLastName;
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this._FirstLastName = value.Trim();
            }
        }

        public string? SecondLastName
        {
            get => this._SecondLastName;
            set
            {
                this._SecondLastName = value?.Trim();
            }
        }
        
        public DateOnly BirthDate
        {
            get => this._BirthDate;
            set
            {
                DateOnly Today = DateOnly.FromDateTime(dateTime: DateTime.Now);

                ArgumentOutOfRangeException.ThrowIfGreaterThan(value: value, other: Today);

                this._BirthDate = value;
            }
        }

        public SexEnum Sex
        {
            get => this._Sex;
            set
            {
                this._Sex = Sex;
            }
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
                this.BirthDate.Month == Today.Month && this.BirthDate.Day > Today.Day
            };

            if (ListOfValidations.Contains<bool>(value: true))
            {
                --Age;
            }

            return Age;
        }

        public async Task<byte> AgeAsync()
        {
            return await Task.FromResult<byte>(result: this.Age());
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

            FullName = string.Concat(str0: Name, str1: " ", str2: LastName);

            return FullName;
        }

        public async Task<string> FullNameAsync()
        {
            return await Task.FromResult<string>(result: this.FullName());
        }
        #endregion
    }
}