using System;
using System.Threading.Tasks;

namespace Data
{
    public static class Utils
    {
        #region Enums
        public enum EmailTypeEnum
        {
            Personal,
            Work,
            University,
            School
        }

        public enum SexEnum
        {
            Female,
            Male
        }
        #endregion



        #region Constructor Method
        static Utils()
        {
            
        }
        #endregion



        #region Messages
        public static void ErrorMessages(Exception ex,
                                         Type OType)
        {
            Console.Error.WriteLine("");
            Console.Error.WriteLine("---");
            Console.Error.WriteLine($"{OType}");
            Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
            Console.Error.WriteLine($"Error Message: {ex.Message}");
            Console.Error.WriteLine($"Complete Error: {ex}");
            Console.Error.WriteLine("---");
            Console.Error.WriteLine("");
        }

        public static async Task ErrorMessagesAsync(Exception ex,
                                                    Type OType)
        {
            await Task.Run(action: () => ErrorMessages(ex, OType));
        }
        #endregion
    }
}