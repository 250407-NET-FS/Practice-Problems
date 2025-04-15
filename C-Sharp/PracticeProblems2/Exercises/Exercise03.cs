// ------------------------------
// EXERCISE 03: Dependency Injection and Singletons
// ------------------------------

namespace PracticeProblems2.Exercises
{
    // TODO: Define an interface IMessageService with SendMessage(string message)

    // TODO: Implement SingletonMessageService as a singleton (thread-safe)
    // - Use a private static instance and locking
    // - Implement SendMessage to print a message prefixed with [Singleton]

    // TODO: Create a MessageClient class
    // - Accept IMessageService through constructor (constructor injection)
    // - Add a method Notify that calls SendMessage

    public class Exercise03
    {
        public static void Run()
        {
            Console.WriteLine("== Dependency Injection and Singleton ==\n");

            // TODO: Get an instance of SingletonMessageService
            // TODO: Inject it into a MessageClient and call Notify
        }
    }
}
