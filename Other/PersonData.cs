using Data.Account;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Other
{
    public class PersonData
    {
        #region Variables
        private ulong ID { get; set; }
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
            this.ID = ulong.MinValue;
            this.FirstName = string.Empty;
            this.MiddleName = null;
            this.FirstLastName = string.Empty;
            this.SecondLastName = null;
            this.DateOfBirth = DateOnly.MinValue;
            this.OSex = new SexData();
        }

        public PersonData(ulong ID,
                          string FirstName,
                          string? MiddleName,
                          string FirstLastName,
                          string? SecondLastName,
                          DateOnly DateOfBirth,
                          SexData OSex)
            : base()
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.FirstLastName = FirstLastName;
            this.SecondLastName = SecondLastName;
            this.DateOfBirth = DateOfBirth;
            this.OSex = OSex;
        }
        #endregion



        #region Destroyer Method
        ~PersonData()
        {

        }
        #endregion



        #region Getters and Setters
        #region Variables
        public ulong GetPersonID()
        {
            return this.ID;
        }

        public void SetPersonID(ulong ID)
        {
            if (ID < 0)
            {
                throw new Exception(nameof(ID));
            }
            
            this.ID = ID;
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public void SetFirstName(string FirstName)
        {
            if (string.IsNullOrEmpty(value: FirstName)
                ||
                string.IsNullOrWhiteSpace(value: FirstName))
            {
                throw new ArgumentNullException(paramName: nameof(FirstName),
                                                message: "The first name cannot be null or empty or have empty spaces.");
            }

            this.FirstName = FirstName.Trim();
        }

        public string? GetMiddleName()
        {
            return this.MiddleName;
        }

        public void SetMiddleName(string? MiddleName)
        {
            this.MiddleName = MiddleName;
        }

        public string GetFirstLastName()
        {
            return this.FirstLastName;
        }

        public void SetFirstLastName(string FirstLastName)
        {
            if (string.IsNullOrEmpty(value: FirstLastName)
                ||
                string.IsNullOrWhiteSpace(value: FirstLastName))
            {
                throw new ArgumentNullException(paramName: nameof(FirstName),
                                                message: "The first last name cannot be null or empty or have empty spaces.");
            }
            
            this.FirstLastName = FirstLastName.Trim();
        }

        public string? GetSecondLastName()
        {
            return this.SecondLastName;
        }

        public void SetSecondLastName(string? SecondLastName)
        {
            this.SecondLastName = SecondLastName;
        }

        public DateOnly GetDateOfBirth()
        {
            return this.DateOfBirth;
        }

        public void SetDateOfBirth(DateOnly DateOfBirth)
        {
            if (DateOfBirth > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new Exception("The birthday date cannot be greater than the current date.");
            }
            
            this.DateOfBirth = DateOfBirth;
        }
        #endregion

        #region Objects
        public SexData GetOSex()
        {
            return this.OSex;
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

            try
            {
                Today = DateOnly.FromDateTime(DateTime.Now);

                if (this.DateOfBirth > Today)
                {
                    throw new Exception("The Date of Birth cannot exceed the current date.");
                }

                Age = Convert.ToByte(value: Today.Year - this.DateOfBirth.Year);

                ListOfValidations = new bool[2]
                {
                    this.DateOfBirth.Month > Today.Month,
                    this.DateOfBirth.Month == Today.Month
                    &&
                    this.DateOfBirth.Day > Today.Day
                };
                
                if (ListOfValidations.AsParallel().Contains(value: true))
                {
                    --Age;
                }

                return Age;
            }
            catch (Exception ex)
            {
                Utils.ErrorMessages(ex, this.GetType());
                
                throw;
            }
        }

        public async Task<byte> AgeAsync()
        {
            try
            {
                return await Task.Run<byte>(function: () => this.Age());
            }
            catch (Exception ex)
            {
                await Utils.ErrorMessagesAsync(ex: ex, OType: this.GetType());
                
                throw;
            }
        }
        #endregion



        #region FullName
        public string FullName()
        {
            string Name;
            string LastName;

            try
            {
                if (string.IsNullOrEmpty(value: this.MiddleName)
                    ||
                    string.IsNullOrWhiteSpace(value: this.MiddleName))
                {
                    Name = this.FirstName.Trim();
                }
                else
                {
                    Name = $"{this.FirstName.Trim()} {this.MiddleName.Trim()}";
                }

                if (string.IsNullOrEmpty(value: this.SecondLastName)
                    ||
                    string.IsNullOrWhiteSpace(value: this.SecondLastName))
                {
                    LastName = this.FirstLastName.Trim();
                }
                else
                {
                    LastName = $"{this.FirstLastName.Trim()} {this.SecondLastName.Trim()}";
                }

                return $"{Name.Trim()} {LastName.Trim()}";
            }
            catch (Exception ex)
            {
                Utils.ErrorMessages(ex: ex,
                                    OType: this.GetType());
                
                throw;
            }
        }

        public async Task<string> FirstNameAsync()
        {
            try
            {
                return await Task.Run<string>(function: () => this.FullName());
            }
            catch (Exception ex)
            {
                await Utils.ErrorMessagesAsync(ex: ex,
                                               OType: this.GetType());
                
                throw;
            }
        }
#endregion
    }
}