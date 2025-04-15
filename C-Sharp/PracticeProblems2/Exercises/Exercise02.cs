// ------------------------------
// EXERCISE 02: Modifiers, IDisposable, and Using
// ------------------------------

using System;
using System.IO;

namespace PracticeProblems2.Exercises
{
    // TODO: Implement IDisposable correctly to clean up the StreamWriter
    // TODO: Use public/protected/private access modifiers meaningfully
    // TODO: Add a method to write a header and a private method to log the message

    public class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        private bool _disposed = false;

        public FileLogger(string filePath)
        {
            // TODO: Initialize the StreamWriter
        }

        protected void WriteHeader()
        {
            // TODO: Write a header line to the file
        }

        private void InternalLog(string message)
        {
            // TODO: Write the message to the file with a timestamp
        }

        public void Log(string message)
        {
            // TODO: Call WriteHeader and InternalLog
        }

        public void Dispose()
        {
            // TODO: Dispose the writer and mark _disposed = true
        }
    }

    public class Exercise02
    {
        public static void Run()
        {
            Console.WriteLine("== Modifiers, IDisposable, and Using ==\n");

            // TODO: Use the FileLogger with a using statement
        }
    }
}
