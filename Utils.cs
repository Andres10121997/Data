using System;
using System.Threading.Tasks;

namespace Data
{
    internal static class Utils
    {
        public static void ErrorMessages(Type OType,
                                         Exception OException)
        {
            Console.Error.WriteLine("");
            Console.Error.WriteLine("---");
            Console.Error.WriteLine($"{OType}");
            Console.Error.WriteLine($"Error message: {OException.Message}");
            Console.Error.WriteLine($"Stack trace: {OException.StackTrace}");
            Console.Error.WriteLine($"Complete error: {OException}");
            Console.Error.WriteLine("---");
            Console.Error.WriteLine("");
        }

        public static async Task ErrorMessagesAsync(Type OType,
                                                    Exception OException)
        {
            await Task.Run(action: () => ErrorMessages(OType, OException));
        }
    }
}