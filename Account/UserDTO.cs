using Data.Communication.Email;
using Data.Communication.Phone;
using Data.Location;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Data.Account
{
    public sealed class UserDTO : PersonDTO
    {
        #region Variables
        private string V_IP;
        private string V_Login;
        private string V_Username;
        private DateOnly V_CreationDate;
        private TimeOnly V_CreationTime;
        #endregion

        #region Objects
        private EmailAddressDTO O_EmailAddress;
        private PhoneDTO O_Phone;
        private CountryDTO O_Country;
        #endregion



        #region Constructor Method
        public UserDTO()
            : base()
        {
            #region Variables
            this.V_IP = string.Empty;
            this.V_Login = string.Empty;
            this.V_Username = string.Empty;
            this.V_CreationDate = new DateOnly();
            this.V_CreationTime = new TimeOnly();
            #endregion

            #region Objects
            this.O_EmailAddress = new EmailAddressDTO();
            this.O_Phone = new PhoneDTO();
            this.O_Country = new CountryDTO();
            #endregion
        }

        public UserDTO(string IP,
                        string Login,
                        string Username,
                        DateOnly CreationDate,
                        TimeOnly CreationTime,
                        EmailAddressDTO EmailAddress,
                        PhoneDTO Phone,
                        CountryDTO Country)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: IP);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: IP);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Login);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Login);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Username);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Username);
            ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.V_IP = IP.Trim();
            this.V_Login = Login.Trim();
            this.V_Username = Username.Trim();
            this.V_CreationDate = CreationDate;
            this.V_CreationTime = CreationTime;
            #endregion

            #region Objects
            this.O_EmailAddress = EmailAddress;
            this.O_Phone = Phone;
            this.O_Country = Country;
            #endregion
        }

        public UserDTO(string FirstName,
                        string? MiddleName,
                        string FirstLastName,
                        string? SecondLastName,
                        DateOnly BirthDate,
                        SexEnum Sex,
                        string IP,
                        string Login,
                        string Username,
                        DateOnly CreationDate,
                        TimeOnly CreationTime,
                        EmailAddressDTO EmailAddress,
                        PhoneDTO Phone,
                        CountryDTO Country)
            : base(FirstName: FirstName.Trim(),
                   MiddleName: MiddleName?.Trim(),
                   FirstLastName: FirstLastName.Trim(),
                   SecondLastName: SecondLastName?.Trim(),
                   BirthDate: BirthDate,
                   Sex: Sex)
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: IP);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: IP);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Login);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Login);
            ArgumentNullException.ThrowIfNullOrEmpty(argument: Username);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: Username);
            ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(value: CreationDate, other: DateOnly.FromDateTime(dateTime: DateTime.Now));
            #endregion

            #region Variables
            this.V_IP = IP.Trim();
            this.V_Login = Login.Trim();
            this.V_Username = Username.Trim();
            this.V_CreationDate = CreationDate;
            this.V_CreationTime = CreationTime;
            #endregion

            #region Objects
            this.O_EmailAddress = EmailAddress;
            this.O_Phone = Phone;
            this.O_Country = Country;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        [
            DataType(
                dataType:DataType.Text
            ),
            Display(
                AutoGenerateField = false,
                AutoGenerateFilter = false,
                Description = "",
                GroupName = nameof(UserDTO),
                Name = "IP",
                Order = 1,
                Prompt = "",
                ShortName = "IP"
            ),
            Required
        ]
        public required string IP
        {
            get => this.V_IP.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_IP = value.Trim();
            }
        }

        public required string Login
        {
            get => this.V_Login.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Login = value.Trim();
            }
        }

        public required string Username
        {
            get => this.V_Username.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);

                this.V_Username = value.Trim();
            }
        }

        public required DateOnly CreationDate
        {
            get => this.V_CreationDate;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan<DateOnly>(
                    value: value,
                    other: DateOnly.FromDateTime(dateTime: DateTime.Now)
                );

                this.V_CreationDate = value;
            }
        }

        public required TimeOnly CreationTime
        {
            get => this.V_CreationTime;
            set => this.V_CreationTime = value;
        }
        #endregion

        #region Objects
        public EmailAddressDTO EmailAddress
        {
            get => this.O_EmailAddress;
            set => this.O_EmailAddress = value;
        }

        public PhoneDTO Phone
        {
            get => this.O_Phone;
            set => this.O_Phone = value;
        }

        public CountryDTO Country
        {
            get => this.O_Country;
            set => this.O_Country = value;
        }
        #endregion
        #endregion



        #region To
        public DateTime ToCreationDateTime()
        {
            DateTime CreationDateTime;

            CreationDateTime = this.CreationDate.ToDateTime(time: this.CreationTime);

            return CreationDateTime;
        }

        public async Task<DateTime> ToCreationDateTimeAsync()
        {
            return await Task.FromResult<DateTime>(result: this.ToCreationDateTime());
        }
        #endregion
    }
}