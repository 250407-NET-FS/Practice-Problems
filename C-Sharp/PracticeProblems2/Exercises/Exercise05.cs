// ------------------------------
// EXERCISE 05: Type Conversion, Casting, Enums, and Implicit Typing
// ------------------------------

namespace PracticeProblems2.Exercises
{
    public enum Status
    {
        Active,
        Inactive,
        Pending
    }

    public class Account
    {
        public string Id { get; set; }
        public Status AccountStatus { get; set; }

        public virtual void Describe()
        {
            Console.WriteLine($"Account ID: {Id}, Status: {AccountStatus}");
        }
    }

    public class PremiumAccount : Account
    {
        public int PremiumLevel { get; set; } = 1;

        public override void Describe()
        {
            Console.WriteLine(
                $"[Premium] Account ID: {Id}, Status: {AccountStatus}, Level: {PremiumLevel}"
            );
        }

        public void PremiumFeature()
        {
            Console.WriteLine("Accessing premium features...");
        }
    }

    public class Exercise05
    {
        public static void Run()
        {
            Console.WriteLine("== Type Conversion, Casting, Enums, and Var ==\n");

            var basic = new Account { Id = "001", AccountStatus = Status.Active }; // inferred as Account
            var premium = new PremiumAccount
            {
                Id = "002",
                AccountStatus = Status.Pending,
                PremiumLevel = 3
            }; // inferred as PremiumAccount

            Account upcasted = premium; // upcasting
            PremiumAccount? downcasted = upcasted as PremiumAccount; // safe downcasting using 'as'

            if (downcasted != null)
            {
                downcasted.Describe();
                downcasted.PremiumFeature();
            }

            basic.Describe();
        }
    }
}
