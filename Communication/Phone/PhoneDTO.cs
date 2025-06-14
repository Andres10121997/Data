﻿using System;

namespace Data.Communication.Phone
{
    public sealed class PhoneDTO
    {
        #region Variables
        private string V_PhoneNumber;
        private PhoneTypeEnum V_PhoneType;
        #endregion

        #region Enum
        public enum PhoneTypeEnum : byte
        {
            None,
            Personal,
            Work
        }
        #endregion



        #region Constructor Method
        public PhoneDTO()
            : base()
        {
            this.V_PhoneNumber = string.Empty;
            this.V_PhoneType = PhoneTypeEnum.None;
        }

        public PhoneDTO(string PhoneNumber,
                         PhoneTypeEnum PhoneType)
            : base()
        {
            #region Exception
            ArgumentNullException.ThrowIfNullOrEmpty(argument: PhoneNumber);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: PhoneNumber);
            ArgumentOutOfRangeException.ThrowIfZero(value: PhoneNumber.Length);
            #endregion

            #region Variables
            this.V_PhoneNumber = PhoneNumber.Trim();
            this.V_PhoneType = PhoneType;
            #endregion
        }
        #endregion



        #region Getters and Setters
        #region Variables
        public string PhoneNumber
        {
            get => this.V_PhoneNumber.Trim();
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(argument: value);
                ArgumentNullException.ThrowIfNullOrWhiteSpace(argument: value);
                ArgumentOutOfRangeException.ThrowIfZero<int>(value: value.Length);

                this.V_PhoneNumber = value.Trim();
            }
        }

        public PhoneTypeEnum PhoneType
        {
            get => this.V_PhoneType;
            set => this.V_PhoneType = value;
        }
        #endregion
        #endregion
    }
}