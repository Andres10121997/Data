using System;
using System.Linq;

namespace Data.Mathematics.Geometry.TwoDimensions
{
    public sealed class PolygonData
    {
        #region Variables
        private byte V_NumberOfEdges; // Cantidad de Aristas.
        #endregion

        #region Arrays
        private ushort[] A_LengthOfEdges { get; set; }
        #endregion



        #region Constructor Methods
        public PolygonData()
            : base()
        {
            this.V_NumberOfEdges = byte.MinValue;
            this.A_LengthOfEdges = Array.Empty<ushort>();
        }

        public PolygonData(byte NumberOfEdges,
                           ushort[] LengthOfEdges)
            : base()
        {
            this.V_NumberOfEdges = NumberOfEdges;
            this.A_LengthOfEdges = LengthOfEdges;
        }
        #endregion



        #region Getters and Setters
        public byte NumberOfEdges
        {
            get => this.V_NumberOfEdges;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(
                    value: value,
                    other: 3
                );
                
                this.V_NumberOfEdges = value;
            }
        }

        public ushort[] LengthOfEdges
        {
            get => this.A_LengthOfEdges;
            set
            {
                if (value.Contains<ushort>(value: 0))
                {
                    throw new ArgumentException(message: "The edge length cannot be 0.");
                }
                
                this.A_LengthOfEdges = value;
            }
        }
        #endregion
    }
}