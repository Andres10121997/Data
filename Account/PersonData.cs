using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Account
{
    public class PersonData
    {
        #region Variables
        private string V_FirstName;
        private string? V_MiddleName;
        private string V_FirstLastName;
        private string? V_SecondLastName;
        private DateOnly V_BirthDate;
        private SexEnum V_Sex;
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
            this.V_FirstName = string.Empty;
            this.V_MiddleName = null;
            this.V_FirstLastName = string.Empty;
            this.V_SecondLastName = null;
            this.V_BirthDate = new DateOnly();
            this.V_Sex = SexEnum.Female;
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
            #region Variables
            this.V_FirstName = FirstName;
            this.V_MiddleName = MiddleName;
            this.V_FirstLastName = FirstLastName;
            this.V_SecondLastName = SecondLastName;
            this.V_BirthDate = BirthDate;
            this.V_Sex = Sex;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        [
            DataType(
                dataType: DataType.Text
            ),
            Display(
                AutoGenerateField = false,
                AutoGenerateFilter = false,
                Description = "",
                GroupName = nameof(PersonData),
                Name = "First name",
                Order = 1,
                Prompt = "Enter first name here.", // Ingrese aquí el primer nombre
                ShortName = "First name"
            ),
            MaxLength(
                length: 30
            ),
            MinLength(
                length: 1
            ),
            Required,
            StringLength(
                maximumLength: 30,
                MinimumLength = 1
            )
        ]
        public string FirstName
        {
            get => this.V_FirstName.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_FirstName = value.Trim();
            }
        }

        public string? MiddleName
        {
            get => this.V_MiddleName?.Trim();
            set => this.V_MiddleName = value?.Trim();
        }

        public string FirstLastName
        {
            get => this.V_FirstLastName.Trim();
            set
            {
                ArgumentException.ThrowIfNullOrEmpty(argument: value);
                ArgumentException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_FirstLastName = value.Trim();
            }
        }

        public string? SecondLastName
        {
            get => this.V_SecondLastName?.Trim();
            set => this.V_SecondLastName = value?.Trim();
        }
        
        public DateOnly BirthDate
        {
            get => this.V_BirthDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(
                    value: value,
                    other: DateOnly.FromDateTime(dateTime: DateTime.Now)
                );

                this.V_BirthDate = value;
            }
        }

        public SexEnum Sex
        {
            get => this.V_Sex;
            set => this.V_Sex = value;
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

            Age = Convert.ToByte(value: this.BirthDate.Year - Today.Year);

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

        public async Task<byte> AgeAsync() => await Task.FromResult<byte>(result: this.Age());
        #endregion



        #region Full Name
        private string Name => string.IsNullOrEmpty(value: this.MiddleName) || string.IsNullOrWhiteSpace(value: this.MiddleName)
                               ?
                               this.FirstName
                               :
                               string.Concat(str0: this.FirstName, str1: " ", str2: this.MiddleName);

        private string LastName => string.IsNullOrEmpty(value: this.SecondLastName) || string.IsNullOrWhiteSpace(value: this.SecondLastName)
                                   ?
                                   this.FirstLastName
                                   :
                                   string.Concat(str0: this.FirstLastName, str1: " ", str2: this.SecondLastName);

        public string FullName() => string.Concat(str0: this.Name, str1: " ", str2: LastName);

        public async Task<string> FullNameAsync() => await Task.FromResult<string>(result: this.FullName());
        #endregion
    }
}