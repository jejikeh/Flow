using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TinyLog
{
    public static class Log
    {
        public static string Output(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
        {
            return $"{sourceLineNumber} line {sourceFilePath}\n[{DateTime.Now.TimeOfDay}][{memberName}]: {message}";
        }
        
        public static string Output<T>(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
        {
            return $"[{typeof(T)}]: {message}";
        }

        public static void Info(string message,
                                [CallerMemberName] string memberName = "",
                                [CallerFilePath] string sourceFilePath = "",
                                [CallerLineNumber] int sourceLineNumber = 0)
        {
            var startedColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Output(message, memberName, sourceFilePath, sourceLineNumber));

            Console.ForegroundColor = startedColor;
        }

        public static void Warn(string message,
                                [CallerMemberName] string memberName = "",
                                [CallerFilePath] string sourceFilePath = "",
                                [CallerLineNumber] int sourceLineNumber = 0)
        {
            var startedColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(Output(message, memberName, sourceFilePath, sourceLineNumber));

            Console.ForegroundColor = startedColor;
        }

        public static void Error(string message,
                                [CallerMemberName] string memberName = "",
                                [CallerFilePath] string sourceFilePath = "",
                                [CallerLineNumber] int sourceLineNumber = 0)
        {
            var startedColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Output(message, memberName, sourceFilePath, sourceLineNumber));

            Console.ForegroundColor = startedColor;
        }
    }
}