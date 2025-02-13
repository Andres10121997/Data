using System.Linq;
using System.Threading.Tasks;
using System;

namespace Data
{
    internal static class Statistics
    {
        #region Constructor methods
        static Statistics()
        {
            
        }
        #endregion



        #region StandardDeviation
        internal static float StandardDeviation(float[] Values)
        {
            return Convert.ToSingle(value: Math.Sqrt(d: Variance(Values: Values)));
        }

        internal static async Task<float> StandardDeviationAsync(float[] Values)
        {
            return await Task.Run<float>(function: () => StandardDeviation(Values: Values));
        }

        internal static double StandardDeviation(double[] Values)
        {
            return Math.Sqrt(d: Variance(Values: Values));
        }

        internal static async Task<double> StandardDeviationAsync(double[] Values)
        {
            return await Task.Run<double>(function: () => StandardDeviation(Values: Values));
        }
        #endregion



        #region Variance
        internal static float Variance(float[] Values)
        {
            var average = Values.Average();
            var sumOfSquares = Values.Select(selector: value => Math.Pow(x: value - average, y: 2)).Sum();
            var variance = sumOfSquares / Values.Length;

            return Convert.ToSingle(value: variance);
        }

        internal static async Task<float> VarianceAsync(float[] Values)
        {
            return await Task.Run<float>(function: () => Variance(Values: Values));
        }

        internal static double Variance(double[] Values)
        {
            var average = Values.Average();
            var sumOfSquares = Values.Select(selector: value => Math.Pow(x: value - average, y: 2)).Sum();
            var variance = sumOfSquares / Values.Length;

            return variance;
        }

        internal static async Task<double> VarianceAsync(double[] Values)
        {
            return await Task.Run<double>(function: () => Variance(Values: Values));
        }
        #endregion
    }
}