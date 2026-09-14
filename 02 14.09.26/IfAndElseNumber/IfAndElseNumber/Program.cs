namespace IfAndElseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //peate katsuma if and else lauseid,
            //et kontrollida, kas kasutaja vanus
            //on suurem kui 18 või väiksem kui 18

            string sisend = Console.ReadLine();
            int vanus = int.Parse(sisend);

            if(vanus > 18)
                 {
                Console.WriteLine("Sinu vanus on suurem kui 18");
            }
            else if (vanus < 18)
            {
                Console.WriteLine("Sinu vanus on väiksem kui 18");
            }
            else
            {
                Console.WriteLine("Sinu vanus on täpselt 18");
            }
        }
    }
}


