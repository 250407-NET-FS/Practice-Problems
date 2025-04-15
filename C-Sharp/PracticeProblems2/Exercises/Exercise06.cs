// ------------------------------
// EXERCISE 06: LINQ, Lambda Expressions, and Generics
// ------------------------------

using System.Collections.Generic;
using System.Linq;

namespace PracticeProblems2.Exercises
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }

    public class Repository<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);

        public void Remove(T item) => _items.Remove(item);

        public List<T> GetAll() => _items;

        public List<T> Find(System.Func<T, bool> predicate)
        {
            return _items.Where(predicate).ToList();
        }
    }

    public class Exercise06
    {
        public static void Run()
        {
            Console.WriteLine("== LINQ, Lambdas, and Generics ==\n");

            var peopleRepo = new Repository<Person>();
            peopleRepo.Add(new Person { Name = "Alice", Age = 30 });
            peopleRepo.Add(new Person { Name = "Bob", Age = 25 });
            peopleRepo.Add(new Person { Name = "Carol", Age = 40 });

            // Find all people over 30
            var over30 = peopleRepo.Find(p => p.Age > 30);

            foreach (var person in over30)
            {
                Console.WriteLine(person);
            }
        }
    }
}
