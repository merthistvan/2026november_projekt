using System.Runtime.InteropServices;

namespace projekt
{
    internal class Program
    {
        //------------------------------------------------------------------------------------------
        static string Skinek()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
            Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
            Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
            Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
            Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
            //-------------------------------------
            ConsoleKeyInfo billentyu;
            int szam = 0;
            do
            {
                billentyu = Console.ReadKey(true);
                if (szam == 0 && billentyu.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 1;
                }
                else if (szam == 1 && billentyu.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 2;
                }
                else if (szam == 2 && billentyu.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 3;
                }
                else if (szam == 3 && billentyu.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 4;
                }
                else if (szam == 4 && billentyu.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 5;
                }
                else if (szam == 5 && billentyu.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 4;
                }
                else if (szam == 4 && billentyu.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 3;
                }
                else if (szam == 3 && billentyu.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 2;
                }
                else if (szam == 2 && billentyu.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 1;
                }
                else if (szam == 1 && billentyu.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tAlap kocsi: [ X ] (2002-es Suzuki Swift 1.0 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tSzuperkocsi: [ Đ ] (1998-as Volkswagen Golf IV 1.4 benzines, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tHiper Szuperkocsi: [ @ ] (2007-es Peugeot 307 2.0 HDi dízel, 136 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tLegendás kocsi: [ ß ] (2005-ös Skoda Fabia RS 1.9 TDI dízel, 130 lóerős, ötajtós, ferdehátú kivitelben.)");
                    Console.WriteLine("\tMisztikus kocsi: [ & ] (2006-os Audi A4 Avant 2.0 TDI dízel, 140 lóerős, kombi kivitelben.)");
                    Console.WriteLine("\tLathatatlan kocsi: [ . ]  (csak a legmenobb jatekosoknak) (Csepel bicikli)");
                    szam = 0;
                }

            } while (billentyu.Key != ConsoleKey.Enter);

            string[] kocsik = { "X", "Đ", "@", "ß", "&", "." };
            return kocsik[szam];
        }
        //-------------------------------------------------------------------------------------------------
        static void Jatek(string kivalasztott)
        {
            ConsoleKeyInfo billentyu;
            Random vel = new Random();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            for (int i = Console.BufferHeight - 1; i > 0; i--)
            {
                Console.SetCursorPosition(59, i);
                Console.WriteLine("||");
                Console.SetCursorPosition(66, i);
                Console.WriteLine("||");
            }

            int pontok = 0;
            Console.SetCursorPosition(75, 15);
            Console.Write($"Pontok: {pontok}");

            int x = 63;/////jatekos pozi
            int y = 25;                 //jatekos pozi
            int r = vel.Next(1, 6);   // ezen a helyen nem lesz akadály
            int j = 0;                // az akadaly melyik sorba van
            int szamlalo = 0;
            bool jatek = true;
            //--------------------------------------------------
            int r2 = vel.Next(1, 6);
            int j2 = 5;
            int szamlalo2 = 0;
            //--------------------------------------------------
            int r3 = vel.Next(1, 6);
            int j3 = 10;
            int szamlalo3 = 0;
            //--------------------------------------------------
            int r4 = vel.Next(1, 6);
            int j4 = 15;
            int szamlalo4 = 0;
            //--------------------------------------------------
            int r5 = vel.Next(1, 6);
            int j5 = 20;
            int szamlalo5 = 0;
            //--------------------------------------------------
            do
            {
                int gyors = 5;
                if (pontok >= 10)
                {
                    gyors = 4;
                }
                if (pontok >= 25)
                {
                    gyors = 3;
                }
                if (pontok >= 50)
                {
                    gyors = 2;
                }
                //-----------------------------------------------
                if (Console.KeyAvailable)
                {
                    billentyu = Console.ReadKey(true);

                    if (billentyu.Key == ConsoleKey.RightArrow && x < 65)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        x++;
                    }
                    if (billentyu.Key == ConsoleKey.LeftArrow && x > 61)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        x--;
                    }
                    if (billentyu.Key == ConsoleKey.Escape)
                    {
                        jatek = false;
                    }
                }
                //-----------------------------------------------------
                szamlalo5++;
                if (szamlalo5 == gyors)
                {
                    szamlalo5 = 0;
                    for (int i = 61; i <= 65; i++)      // regit torli
                    {
                        Console.SetCursorPosition(i, j5);
                        Console.Write(" ");
                    }

                    j5++;
                    if (j5 > 29)                         // elolor
                    {
                        j5 = 5;
                        r5 = vel.Next(1, 6); //hol ne legyen akadaly
                        pontok++;
                        Console.SetCursorPosition(75, 15);
                        Console.Write($"Pontok: {pontok}");
                    }

                    for (int i = 61; i <= 65; i++)      // uj sort kiirja
                    {
                        if (i != 60 + r5)
                        {
                            Console.SetCursorPosition(i, j5);
                            Console.Write("#");
                        }
                    }

                    if (j5 == y && x != 60 + r5)//ha  a jatekos egy helyen van egy akadallyal akkor meghal |||| akadaly sora == jatekos sora es az oszlop nem egyenlo a kihagyott resszel
                    {
                        jatek = false;
                    }
                }
                //-----------------------------------------------------
                szamlalo4++;
                if (szamlalo4 == gyors)
                {
                    szamlalo4 = 0;
                    for (int i = 61; i <= 65; i++)
                    {
                        Console.SetCursorPosition(i, j4);
                        Console.Write(" ");
                    }

                    j4++;
                    if (j4 > 29)
                    {
                        j4 = 5;
                        r4 = vel.Next(1, 6);
                        pontok++;
                        Console.SetCursorPosition(75, 15);
                        Console.Write($"Pontok: {pontok}");
                    }

                    for (int i = 61; i <= 65; i++)
                    {
                        if (i != 60 + r4)
                        {
                            Console.SetCursorPosition(i, j4);
                            Console.Write("#");
                        }
                    }

                    if (j4 == y && x != 60 + r4)
                    {
                        jatek = false;
                    }
                }
                //-----------------------------------------------------
                szamlalo3++;
                if (szamlalo3 == gyors)
                {
                    szamlalo3 = 0;
                    for (int i = 61; i <= 65; i++)
                    {
                        Console.SetCursorPosition(i, j3);
                        Console.Write(" ");
                    }

                    j3++;
                    if (j3 > 29)
                    {
                        j3 = 5;
                        r3 = vel.Next(1, 6);
                        pontok++;
                        Console.SetCursorPosition(75, 15);
                        Console.Write($"Pontok: {pontok}");
                    }

                    for (int i = 61; i <= 65; i++)
                    {
                        if (i != 60 + r3)
                        {
                            Console.SetCursorPosition(i, j3);
                            Console.Write("#");
                        }
                    }

                    if (j3 == y && x != 60 + r3)
                    {
                        jatek = false;
                    }
                }
                //--------------------------------------------
                szamlalo2++;
                if (szamlalo2 == gyors)
                {
                    szamlalo2 = 0;
                    for (int i = 61; i <= 65; i++)
                    {
                        Console.SetCursorPosition(i, j2);
                        Console.Write(" ");
                    }

                    j2++;
                    if (j2 > 29)
                    {
                        j2 = 5;
                        r2 = vel.Next(1, 6);
                        pontok++;
                        Console.SetCursorPosition(75, 15);
                        Console.Write($"Pontok: {pontok}");
                    }

                    for (int i = 61; i <= 65; i++)
                    {
                        if (i != 60 + r2)
                        {
                            Console.SetCursorPosition(i, j2);
                            Console.Write("#");
                        }
                    }

                    if (j2 == y && x != 60 + r2)
                    {
                        jatek = false;
                    }
                }
                //--------------------------------------------
                szamlalo++;
                if (szamlalo == gyors)
                {
                    szamlalo = 0;
                    for (int i = 61; i <= 65; i++)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(" ");
                    }

                    j++;
                    if (j > 29)
                    {
                        j = 5;
                        r = vel.Next(1, 6);
                        pontok++;
                        Console.SetCursorPosition(75, 15);
                        Console.Write($"Pontok: {pontok}");
                    }

                    for (int i = 61; i <= 65; i++)
                    {
                        if (i != 60 + r)
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write("#");
                        }
                    }

                    if (j == y && x != 60 + r)
                    {
                        jatek = false;
                    }
                }
                //-----------------------------------------------------

                Console.SetCursorPosition(x, y);
                Console.Write(kivalasztott);

                System.Threading.Thread.Sleep(50);
            } while (jatek == true);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("Ratyi vagy!");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("Pontjaid szama: " + pontok);

            System.Threading.Thread.Sleep(2000);
            Menu();
        }
        //------------------------------------------------------------------------------------------
        static void Menu(string kivalasztott = "X")//menu, interaktiv enterrel lepsz be fel le nyilakkal
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string logo = " _   _            _       _                          _            \r\n| \\ | | _____   _| |_ ___| | ___ _ __     __ _ _   _| |_ ___  ___ \r\n|  \\| |/ _ \\ \\ / / __/ _ \\ |/ _ \\ '_ \\   / _` | | | | __/ _ \\/ __|\r\n| |\\  |  __/\\ V /| ||  __/ |  __/ | | | | (_| | |_| | || (_) \\__ \\\r\n|_|_\\_|\\___| \\_/  \\__\\___|_|\\___|_| |_|  \\__,_|\\__,_|\\__\\___/|___/\r\n  (_) __ _| |_ ___| | __                                          \r\n  | |/ _` | __/ _ \\ |/ /                                          \r\n  | | (_| | ||  __/   <                                           \r\n _/ |\\__,_|\\__\\___|_|\\_\\                                          \r\n|__/                                                              ";
            //---------------------------------------------------------
            Console.WriteLine(logo);
            System.Threading.Thread.Sleep(1000); //késleltetés
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\tJáték");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tSkinek");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tKilépés");

            ConsoleKeyInfo billentyu;
            int szam = 0;

            do
            {
                billentyu = Console.ReadKey(true);
                if (szam == 0 && billentyu.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.WriteLine(logo);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tJáték");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tSkinek");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tKilépés");
                    szam = 1;
                }
                else if (szam == 1 && billentyu.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.WriteLine(logo);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tJáték");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tSkinek");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tKilépés");
                    szam = 2;
                }
                else if (szam == 1 && billentyu.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.WriteLine(logo);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tJáték");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tSkinek");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tKilépés");
                    szam = 0;
                }
                else if (szam == 2 && billentyu.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(logo);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tJáték");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tSkinek");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\tKilépés");
                    szam = 1;
                }

            } while (billentyu.Key != ConsoleKey.Enter);

            //---------------------------------------------------------

            if (billentyu.Key == ConsoleKey.Enter && szam == 0)
            {
                Jatek(kivalasztott);
            }
            if (billentyu.Key == ConsoleKey.Enter && szam == 1)
            {
                string Skin = Skinek();
                Menu(Skin);
            }
            if (billentyu.Key == ConsoleKey.Enter && szam == 2)
            {

                Console.Clear();
                ConsoleColor[] szinek =
                {
                    ConsoleColor.Cyan,
                    ConsoleColor.Green,
                    ConsoleColor.Yellow,
                    ConsoleColor.Red
                };
                string[] uzenetek =
                {
                    "Biztos hogy ki akarsz lépni? (Enter/ESC)",
                    "De biztos vagy benne?? (Enter/ESC)",
                    "De utána nem fogsz tudni visszalépni! Biztos ki akarsz lépni??? (Enter/ESC)",
                    "Utolsó esély!!! (Enter/ESC)"
                };

                for (int i = 0; i < uzenetek.Length; i++)
                {
                    Console.ForegroundColor = szinek[i];
                    Console.WriteLine(uzenetek[i]);
                    while (true)
                    {
                        billentyu = Console.ReadKey(true);
                        if (billentyu.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                        if (billentyu.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Menu();
                            break;
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Hát jó. :(");
                System.Threading.Thread.Sleep(500);
                //zsibbad az agyam ezutan
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        static void Main()
        {
            //á, é, í, ó, ö, ő, ú, ü, ű (nincs magyar kiosztasom)
            Console.BackgroundColor = ConsoleColor.Black;
            Menu();
        }
    }
}