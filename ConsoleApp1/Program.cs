namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MaxLINQ();

            //Shows The oldest person in the list.
        }

        static void MaxLINQ()
        {
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);

            Console.WriteLine("Kõige vanem inimene on " + oldestPerson + " aastane.");
        }
    
    }
}
