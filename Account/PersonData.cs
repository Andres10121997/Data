﻿using System;
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
        private DateOnly DateOfBirth { get; set; }
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
            this.DateOfBirth = DateOnly.MinValue;
            this.Sex = SexEnum.Female;
            #endregion
        }

        public PersonData(string FirstName,
                          string? MiddleName,
                          string FirstLastName,
                          string? SecondLastName,
                          DateOnly DateOfBirth,
                          SexEnum Sex)
            : base()
        {
            #region Variables
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.FirstLastName = FirstLastName;
            this.SecondLastName = SecondLastName;
            this.DateOfBirth = DateOfBirth;
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
            return this.SecondLastName;
        }

        public void SetSecondLastName(string? SecondLastName)
        {
            this.SecondLastName = SecondLastName?.Trim();
        }

        public DateOnly GetDateOfBirth()
        {
            return this.DateOfBirth;
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
            bool[] ListOfValidations;
            #endregion

            Today = DateOnly.FromDateTime(dateTime: DateTime.Now);

            if (this.DateOfBirth > Today)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(this.DateOfBirth),
                                                      message: $"The \"{nameof(this.DateOfBirth)}\" variable cannot exceed the current date.");
            }

            Age = Convert.ToByte(value: Today.Year - this.DateOfBirth.Year);

            ListOfValidations = new bool[2]
            {
                this.DateOfBirth.Month > Today.Month,
                this.DateOfBirth.Month == Today.Month
                &&
                this.DateOfBirth.Day > Today.Day
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



        #region FullName
        public string FullName()
        {
            #region Variables
            string Name;
            string LastName;
            #endregion

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

        public async Task<string> FirstNameAsync()
        {
            return await Task.Run<string>(function: () => this.FullName());
        }
        #endregion
    }
}