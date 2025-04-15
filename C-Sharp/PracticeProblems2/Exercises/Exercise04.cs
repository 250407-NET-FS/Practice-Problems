// ------------------------------
// EXERCISE 04: Factory Method and Exception Handling
// ------------------------------

namespace PracticeProblems2.Exercises
{
    // Abstract product class
    public abstract class Product
    {
        public string Name { get; set; }
        public abstract void Describe();
    }

    public class Book : Product
    {
        public Book()
        {
            Name = "Generic Book";
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a book: {Name}");
        }
    }

    public class Toy : Product
    {
        public Toy()
        {
            Name = "Generic Toy";
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a toy: {Name}");
        }
    }

    public static class ProductFactory
    {
        public static Product CreateProduct(string type)
        {
            if (type == "book")
                return new Book();
            if (type == "toy")
                return new Toy();
            throw new ArgumentException("Unknown product type");
        }
    }

    public class Exercise04
    {
        public static void Run()
        {
            Console.WriteLine("== Factory Method and Exception Handling ==\n");

            try
            {
                string type = "book"; // Simulate input
                Product product = ProductFactory.CreateProduct(type);
                product.Describe();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Factory method example complete.\n");
            }
        }
    }
}
