namespace _100_People_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> peopleList = new List<People>();
            for (int i = 0; i < 100; i++)
            {
                peopleList.Add(new People());
            }
            var listSort = peopleList.OrderByDescending(x => x.TS);
            foreach (People people in listSort)
            {
                Console.WriteLine($"{people.FirstName} {people.LastName} är {people.TS.Days / 365} år gammal");
            }
            Console.ReadLine();
        }
    }
}
