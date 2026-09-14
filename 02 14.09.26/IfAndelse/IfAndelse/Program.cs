namespace IfAndelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siseta enda nimi!");
            Console.WriteLine("https://meet.google.com/mqx-qqdo-ncp?pli=1&authuser=2");
            //siin on muutja nimega nime,
            //mis on tüübiga string
            //loeb andmeid konsoolist ja salvestab
            //need muutja nime sisse
            string name = Console.ReadLine();

            //if ja else kontrollib, kas muutja
            //name on tühi või mitte
            //kui muutja name on tühi, siis väljastab konsoolile
            //teksti "Tere,tundmatu! ERROR ja teeb 4 piiksu
            if (name != "")
            {
                Console.WriteLine("Tere, " + name);
                
            }
            else
            {
                Console.WriteLine("Tere, tundmatu!ERROR");
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);



            }
;

        }
    }
}
