using System.Linq;
using System.Threading.Tasks;
using System;

namespace Data.Mathematics
{
    public class Statistics
    {
        #region Constructor methods
        public Statistics()
            : base()
        {
            
        }
        #endregion



        #region StandardDeviation
        public float StandardDeviation(float[] Values)
        {
            return Convert.ToSingle(value: Math.Sqrt(d: this.Variance(Values: Values)));
        }

        public async Task<float> StandardDeviationAsync(float[] Values)
        {
            return await Task.Run<float>(function: () => this.StandardDeviation(Values: Values));
        }

        public double StandardDeviation(double[] Values)
        {
            return Math.Sqrt(d: this.Variance(Values: Values));
        }

        public async Task<double> StandardDeviationAsync(double[] Values)
        {
            return await Task.Run<double>(function: () => this.StandardDeviation(Values: Values));
        }
        #endregion



        #region Variance
        public float Variance(float[] Values)
        {
            var average = Values.Average();
            var sumOfSquares = Values.Select(selector: value => Math.Pow(x: value - average, y: 2)).Sum();
            var variance = sumOfSquares / Values.Length;

            return Convert.ToSingle(value: variance);
        }

        public async Task<float> VarianceAsync(float[] Values)
        {
            return await Task.Run<float>(function: () => this.Variance(Values: Values));
        }

        public double Variance(double[] Values)
        {
            var average = Values.Average();
            var sumOfSquares = Values.Select(selector: value => Math.Pow(x: value - average, y: 2)).Sum();
            var variance = sumOfSquares / Values.Length;

            return variance;
        }

        public async Task<double> VarianceAsync(double[] Values)
        {
            return await Task.Run<double>(function: () => this.Variance(Values: Values));
        }
        #endregion
    }
}