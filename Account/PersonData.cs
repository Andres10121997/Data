using System;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Account
{
    public class PersonData
    {
        #region Variables
        private ulong? ID { get; set; }
        private string FirstName { get; set; }
        private string? MiddleName { get; set; }
        private string FirstLastName { get; set; }
        private string? SecondLastName { get; set; }
        private DateOnly DateOfBirth { get; set; }
        #endregion

        #region Objects
        private SexData OSex { get; set; }
        #endregion



        #region Constructor Method
        public PersonData()
            : base()
        {
            #region Variables
            this.ID = null;
            this.FirstName = string.Empty;
            this.MiddleName = null;
            this.FirstLastName = string.Empty;
            this.SecondLastName = null;
            this.DateOfBirth = DateOnly.MinValue;
            #endregion

            #region Objects
            this.OSex = new SexData();
            #endregion
        }

        public PersonData(ulong? ID,
                          string FirstName,
                          string? MiddleName,
                          string FirstLastName,
                          string? SecondLastName,
                          DateOnly DateOfBirth,
                          SexData OSex)
            : base()
        {
            #region Variables
            this.ID = ID;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.FirstLastName = FirstLastName;
            this.SecondLastName = SecondLastName;
            this.DateOfBirth = DateOfBirth;
            #endregion

            #region Objects
            this.OSex = OSex;
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
        public ulong? GetID()
        {
            return ID;
        }

        public void SetID(ulong? ID)
        {
            if (ID < 0)
            {
                throw new Exception(nameof(ID));
            }
            
            this.ID = ID;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string FirstName)
        {
            if (string.IsNullOrEmpty(value: FirstName)
                ||
                string.IsNullOrWhiteSpace(value: FirstName))
            {
                throw new ArgumentNullException(message: $"The variable \"{nameof(FirstName)}\", of the {nameof(PersonData)} class, cannot be null or empty or have blank fields.",
                                                paramName: nameof(FirstName));
            }

            this.FirstName = FirstName.Trim();
        }

        public string? GetMiddleName()
        {
            return MiddleName;
        }

        public void SetMiddleName(string? MiddleName)
        {
            this.MiddleName = MiddleName?.Trim();
        }

        public string GetFirstLastName()
        {
            return FirstLastName;
        }

        public void SetFirstLastName(string FirstLastName)
        {
            if (string.IsNullOrEmpty(value: FirstLastName)
                ||
                string.IsNullOrWhiteSpace(value: FirstLastName))
            {
                throw new ArgumentNullException(message: $"The {nameof(FirstLastName)} cannot be null or empty or have empty spaces.",
                                                paramName: nameof(FirstName));
            }
            
            this.FirstLastName = FirstLastName.Trim();
        }

        public string? GetSecondLastName()
        {
            return SecondLastName;
        }

        public void SetSecondLastName(string? SecondLastName)
        {
            this.SecondLastName = SecondLastName?.Trim();
        }

        public DateOnly GetDateOfBirth()
        {
            return DateOfBirth;
        }

        public void SetDateOfBirth(DateOnly DateOfBirth)
        {
            DateOnly Today = DateOnly.FromDateTime(dateTime: DateTime.Now);

            if (DateOfBirth > Today)
            {
                throw new ArgumentException(message: $"The \"{nameof(DateOnly)}\" variable cannot be later than the current date.",
                                            paramName: nameof(DateOfBirth));
            }
            
            this.DateOfBirth = DateOfBirth;
        }
        #endregion

        #region Objects
        public SexData GetOSex()
        {
            return OSex;
        }

        public void SetOSex(SexData OSex)
        {
            this.OSex = OSex;
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
            bool[] ListOfValidations;
            #endregion

            Today = DateOnly.FromDateTime(dateTime: DateTime.Now);

            try
            {
                if (DateOfBirth > Today)
                {
                    throw new Exception("The Date of Birth cannot exceed the current date.");
                }

                Age = Convert.ToByte(value: Today.Year - DateOfBirth.Year);

                ListOfValidations = new bool[2]
                {
                    DateOfBirth.Month > Today.Month,
                    DateOfBirth.Month == Today.Month
                    &&
                    DateOfBirth.Day > Today.Day
                };
                
                if (ListOfValidations.AsParallel<bool>().Contains<bool>(value: true))
                {
                    --Age;
                }

                return Age;
            }
            catch (Exception ex)
            {
                Utils.ErrorMessages(ex: ex, OType: GetType());
                
                throw;
            }
        }

        public async Task<byte> AgeAsync()
        {
            try
            {
                return await Task.Run<byte>(function: () => this.Age());
            }
            catch (ArgumentNullException ane)
            {
                await Utils.ErrorMessagesAsync(ex: ane, OType: this.GetType());
                
                throw;
            }
        }
        #endregion



        #region FullName
        public string FullName()
        {
            #region Variables
            string Name;
            string LastName;
            #endregion

            try
            {
                Name = (
                    string.IsNullOrEmpty(value: this.MiddleName) || string.IsNullOrWhiteSpace(value: this.MiddleName)
                    ?
                    this.FirstName.Trim() : $"{this.FirstName.Trim()} {this.MiddleName.Trim()}"
                );
                
                LastName = (
                    string.IsNullOrEmpty(value: this.SecondLastName) || string.IsNullOrWhiteSpace(value: this.SecondLastName)
                    ?
                    this.FirstLastName.Trim() : $"{this.FirstLastName.Trim()} {this.SecondLastName.Trim()}"
                );

                return $"{Name.Trim()} {LastName.Trim()}";
            }
            catch (Exception ex)
            {
                Utils.ErrorMessages(ex: ex,
                                    OType: GetType());
                
                throw;
            }
        }

        public async Task<string> FirstNameAsync()
        {
            try
            {
                return await Task.Run<string>(function: () => this.FullName());
            }
            catch (ArgumentNullException ane)
            {
                await Utils.ErrorMessagesAsync(ex: ane, OType: this.GetType());
                
                throw;
            }
        }
        #endregion
    }
}