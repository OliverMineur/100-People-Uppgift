namespace _100_People_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> peopleList = new List<People>();
            DateTime time = new DateTime(2003,9,11);
            peopleList.Add(new People("Hello", "Hampus", time));
            Console.ReadLine();
        }
    }
}
