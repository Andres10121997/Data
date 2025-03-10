using System;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Mathematics
{
    public class Statistics
    {
        #region ConstructorMethods
        public Statistics()
            : base()
        {
            
        }
        #endregion



        #region DestroyerMethod
        ~Statistics()
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
            try
            {
                return await Task.Run<float>(function: () => this.StandardDeviation(Values: Values));
            }
            catch (ArgumentNullException ane)
            {
                await Utils.ErrorMessagesAsync(ex: ane, OType: this.GetType());

                throw;
            }
        }

        public double StandardDeviation(double[] Values)
        {
            return Math.Sqrt(d: this.Variance(Values: Values));
        }

        public async Task<double> StandardDeviationAsync(double[] Values)
        {
            try
            {
                return await Task.Run<double>(function: () => this.StandardDeviation(Values: Values));
            }
            catch (ArgumentNullException ane)
            {
                await Utils.ErrorMessagesAsync(ex: ane, OType: this.GetType());
                
                throw;
            }
        }
        #endregion



        #region Variance
        public float Variance(float[] Values)
        {
            float average = Values.Average();
            double sumOfSquares = Values.Select(selector: value => Math.Pow(x: value - average, y: 2)).Sum();
            double variance = sumOfSquares / Values.Length;

            return Convert.ToSingle(value: variance);
        }

        public async Task<float> VarianceAsync(float[] Values)
        {
            try
            {
                return await Task.Run<float>(function: () => this.Variance(Values: Values));
            }
            catch (ArgumentNullException ane)
            {
                await Utils.ErrorMessagesAsync(ex: ane, OType: this.GetType());
                
                throw;
            }
        }

        public double Variance(double[] Values)
        {
            double average = Values.Average();
            double sumOfSquares = Values.Select(selector: value => Math.Pow(x: value - average, y: 2)).Sum();
            double variance = sumOfSquares / Values.Length;

            return variance;
        }

        public async Task<double> VarianceAsync(double[] Values)
        {
            try
            {
                return await Task.Run<double>(function: () => this.Variance(Values: Values));
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