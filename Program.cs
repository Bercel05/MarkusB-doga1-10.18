using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Kérem, adja meg a vásárlási összeget (Ft): ");
        double vasarlasiOsszeg = Convert.ToDouble(Console.ReadLine());

       
        Console.Write("Van-e törzsvásárlói kártyája? (igen/nem): ");
        string torzsvasarloiKartya = Console.ReadLine().Trim().ToLower();

       
        double fizetendoOsszeg = vasarlasiOsszeg;

       
        if (vasarlasiOsszeg < 10000)
        {
           
            fizetendoOsszeg = vasarlasiOsszeg;
        }
        else if (vasarlasiOsszeg >= 10000 && vasarlasiOsszeg <= 50000)
        {
            
            if (torzsvasarloiKartya == "igen")
            {
                fizetendoOsszeg *= 0.95;
            }
        }
        else
        {
            
            if (torzsvasarloiKartya == "igen")
            {
                fizetendoOsszeg *= 0.90; 
            }
            else
            {
                fizetendoOsszeg *= 0.95;
            }
        }

        Console.WriteLine($"Fizetendő összeg: {fizetendoOsszeg:0} Ft");
    }
}
