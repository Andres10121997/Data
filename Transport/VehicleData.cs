using System;

namespace Data.Transport
{
    public sealed class VehicleData
    {
        #region Variables
        private byte V_NumberOfDoors;
        private byte V_NumberOfWheels;
        private ushort V_OverallLength; // Longitud general
        private ushort V_OverallWidth; // Anchura general
        private ushort V_OverallHeight; // Altura general
        #endregion



        #region Constructor methods
        public VehicleData()
            : base()
        {
            this.NumberOfDoors = byte.MinValue;
            this.NumberOfWheels = byte.MinValue;
            this.OverallLength = ushort.MinValue;
            this.OverallWidth = ushort.MinValue;
            this.OverallHeight = ushort.MinValue;
        }

        public VehicleData(byte NumberOfDoors,
                           byte NumberOfWheels,
                           ushort OverallLength,
                           ushort OverallWidth,
                           ushort OverallHeight)
            : base()
        {
            #region Variables
            this.NumberOfDoors = NumberOfDoors;
            this.NumberOfWheels = NumberOfWheels;
            this.OverallLength = OverallLength;
            this.OverallWidth = OverallWidth;
            this.OverallHeight = OverallHeight;
            #endregion
        }
        #endregion



        #region Getters and Setters
        public byte NumberOfDoors
        {
            get => this.V_NumberOfDoors;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<byte>(value: value);

                this.V_NumberOfDoors = value;
            }
        }

        public byte NumberOfWheels
        {
            get => this.V_NumberOfWheels;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<byte>(value: value);

                this.V_NumberOfWheels = value;
            }
        }

        public ushort OverallLength
        {
            get => this.V_OverallLength;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<ushort>(value: value);

                this.V_OverallLength = value;
            }
        }

        public ushort OverallWidth
        {
            get => V_OverallWidth;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<ushort>(value: value);

                this.V_OverallWidth = value;
            }
        }

        public ushort OverallHeight
        {
            get => this.V_OverallHeight;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero<ushort>(value: value);

                this.V_OverallHeight = value;
            }
        }
        #endregion
    }
}