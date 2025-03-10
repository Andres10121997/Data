using System;
using System.Linq;

namespace Data.Mathematics.Geometry.TwoDimensions
{
    public class PolygonData
    {
        #region Variables
        private byte NumberOfEdges { get; set; } // Cantidad de Aristas.
        #endregion

        #region Arrays
        private ushort[] LengthOfEdges { get; set; }
        #endregion



        #region ConstructorMethods
        public PolygonData()
            : base()
        {
            this.NumberOfEdges = byte.MinValue;
            this.LengthOfEdges = Array.Empty<ushort>();
        }

        public PolygonData(byte NumberOfEdges,
                           ushort[] LengthOfEdges)
            : base()
        {
            this.NumberOfEdges = NumberOfEdges;
            this.LengthOfEdges = LengthOfEdges;
        }
        #endregion



        #region DestroyerMethod
        ~PolygonData()
        {

        }
        #endregion



        #region Getters and Setters
        public byte GetNumberOfEdges()
        {
            return this.NumberOfEdges;
        }

        public void SetNumberOfEdges(byte NumberOfEdges)
        {
            if (NumberOfEdges < 3)
            {
                throw new ArgumentException(message: "The number of edges of the polygon cannot be less than 3.",
                                            paramName: nameof(LengthOfEdges));
            }
            
            this.NumberOfEdges = NumberOfEdges;
        }

        public ushort[] GetLengthOfEdges()
        {
            return this.LengthOfEdges;
        }

        public void SetLengthOfEdges(ushort[] LengthOfEdges)
        {
            if (LengthOfEdges.Contains<ushort>(value: 0))
            {
                throw new ArgumentException(message: "The edge length cannot be 0.",
                                            paramName: nameof(LengthOfEdges));
            }

            this.LengthOfEdges = LengthOfEdges;
        }
        #endregion
    }
}