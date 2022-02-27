using System;
namespace Rechner
{
    
    public class Program
    {
        public static string NewLine { get; }
        public static int rechen_methode;
        public static void Main(string[] args)
        {
            bool rechner_laeuft = true;
            Console.WriteLine("(1) Dezimal zu Dual{0}(2) Dual zu Dezimal{0}(3) Dezimal zu Heximal{0}(4) Heximal zu Dezimal{0}(5) Dual zu Heximal{0}(6) Heximal zu Dual{0}Bitte gib die Zahl in den Klammern ein.{0}Um das Programm zu beenden, drücke q.",
                    Environment.NewLine);
            
            while (rechner_laeuft == true)
            {   
                Console.WriteLine("Was möchtest du rechnen?");
                string eingabe_start = Console.ReadLine();
                quitbutton(eingabe_start);
                switch (rechen_methode)
                {
                    case 1:
                        //Dezimal zu Dual
                        inttostring(2);                        
                        break;
                    case 2:
                        //Dual zu Dezimal
                        stringtoint(2);                       
                        break;
                    case 3:
                        //Dezimal zu Heximal
                        inttostring(16);                     
                        break;
                    case 4:
                        //Heximal zu Dezimal
                        stringtoint(16);
                        break;
                    case 5:
                        //Dual zu Hex
                        BinärzuHex();
                        break;
                    case 6:
                        //Hex zu Dual
                        HexzuBinär();
                        break;
                }
            }
        }
        //Rechnung für case 2 und case 4
        static void stringtoint(int x)
        {
            try
            {
                Console.WriteLine("Bitte gib deine Nummer ein: ");
                string eingabe_string = Console.ReadLine();
                int ausgabe = Convert.ToInt32(eingabe_string, x);
                Console.WriteLine(ausgabe);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException )
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein");
            }
        }
        //Rechnung für case 1 und 3
        static void inttostring(int x)
        {
            try
            {
                Console.WriteLine("Bitte gib deine Nummer ein: ");
                int eingabe = Convert.ToInt32(Console.ReadLine());
                string Dual_ausgabe = Convert.ToString(eingabe, x);
                Console.WriteLine(Dual_ausgabe);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException )
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein");
            }
        }
        //für case 5 Dualzahlen zu Heximalzahlen
        static void BinärzuHex()
        {
            try
            {
                Console.WriteLine("Bitte gib deine Nummer ein: ");
                string dual = Console.ReadLine();
                int dez = Convert.ToInt32(dual, 2);
                string ausgabe = Convert.ToString(dez, 16);
                Console.WriteLine(ausgabe);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException )
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein");
            }
        }
        //für case 6 Heximalzahlen zu Dualzahlen
        static void HexzuBinär()
        {
            try
            {
                Console.WriteLine("Bitte gib deine Nummer ein: ");
                string hex = Console.ReadLine();
                int dez = Convert.ToInt32(hex, 16);
                string dual = Convert.ToString(dez, 2);
                Console.WriteLine(dual);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException )
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein");
            }
        }

        //quit button
        public static void quitbutton(string eingabe_start_methode)
        {
            if (eingabe_start_methode == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                //error catch für den Fall, das ein ungültger Character verwendet wird
                try
                {
                    rechen_methode = Convert.ToInt32(eingabe_start_methode);
                    if(rechen_methode >= 7)
                    {
                        Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                        return;
                    }

                    if (rechen_methode == 0)
                    {
                        Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                        return;
                    }
                }
                catch
                {
                    Console.WriteLine("Bitte geben Sie eine/n gültige/n Zahl/Buchstabe ein.");
                }
            }
        }
        //error fixes
        public static implicit operator bool(Program v)
        {
            throw new NotImplementedException();
        }
        
    }
}


