namespace IfAndElseNestings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //muutja nimega y on double e
            //komakohaga arv ja väärus on 9
            double y = 9.0;
            if (y == 9)
            {
                if (y == 11)
                {
                    Console.WriteLine("Vastus on 11");
                }
                else
                {
                    Console.WriteLine("Vastus on kõik peale 11");
                }
            }
            else if (y == 30)

            {
                Console.WriteLine("Vastus on 30");
            }
            else
            {
                Console.WriteLine("Mingi kahtlane number");
            }
        }
    }
}


