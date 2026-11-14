using System.Runtime.InteropServices;

namespace projekt
{
    internal class Program
    {
        
        static void Jatek()
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


            int x = 63;/////jatekos pozi
            int y = 25;                 //jatekos pozi
            int r = vel.Next(1, 6);   // ezen a helyen nem lesz akadály
            int j = 0;                // az akadaly melyik sorba van
            int szamlalo = 0;
            bool jatek = true;
//--------------------------------------------------
            int r2 = vel.Next(1, 6);   // ezen a helyen nem lesz akadály
            int j2 = 5;                // az akadaly melyik sorba van
            int szamlalo2 = 0;
            //--------------------------------------------------
            //--------------------------------------------------
            int r3 = vel.Next(1, 6);   // ezen a helyen nem lesz akadály
            int j3 = 10;                // az akadaly melyik sorba van
            int szamlalo3 = 0;
            //--------------------------------------------------
            int r4 = vel.Next(1, 6);   // ezen a helyen nem lesz akadály
            int j4 = 15;                // az akadaly melyik sorba van
            int szamlalo4 = 0;
            //--------------------------------------------------
            int r5 = vel.Next(1, 6);   // ezen a helyen nem lesz akadály
            int j5 = 20;                // az akadaly melyik sorba van
            int szamlalo5 = 0;
//--------------------------------------------------
            do
            {
                
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
                bool egyszer = false;
                //-----------------------------------------------------
                if (egyszer=true)
                {

                szamlalo5++;
                if (szamlalo5 == 5)
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
                }

                egyszer = true;
//-----------------------------------------------------
                szamlalo4++;
                if (szamlalo4 == 5)
                {
                    szamlalo4 = 0;

                    for (int i = 61; i <= 65; i++)      // regit torli
                    {
                        Console.SetCursorPosition(i, j4);
                        Console.Write(" ");
                    }

                    j4++;
                    if (j4 > 29)                         // elolor
                    {
                        j4 = 5;
                        r4 = vel.Next(1, 6); //hol ne legyen akadaly
                    }

                    for (int i = 61; i <= 65; i++)      // uj sort kiirja
                    {
                        if (i != 60 + r4)
                        {
                            Console.SetCursorPosition(i, j4);
                            Console.Write("#");
                        }
                    }

                    if (j4 == y && x != 60 + r4)//ha  a jatekos egy helyen van egy akadallyal akkor meghal |||| akadaly sora == jatekos sora es az oszlop nem egyenlo a kihagyott resszel
                    {
                        jatek = false;
                    }
                }
                egyszer = true;
//-----------------------------------------------------
                szamlalo3++;
                if (szamlalo3 == 5)
                {
                    szamlalo3 = 0;

                    for (int i = 61; i <= 65; i++)      // regit torli
                    {
                        Console.SetCursorPosition(i, j3);
                        Console.Write(" ");
                    }

                    j3++;
                    if (j3 > 29)                         // elolor
                    {
                        j3 = 5;
                        r3 = vel.Next(1, 6); //hol ne legyen akadaly
                    }

                    for (int i = 61; i <= 65; i++)      // uj sort kiirja
                    {
                        if (i != 60 + r3)
                        {
                            Console.SetCursorPosition(i, j3);
                            Console.Write("#");
                        }
                    }

                    if (j3 == y && x != 60 + r3)//ha  a jatekos egy helyen van egy akadallyal akkor meghal |||| akadaly sora == jatekos sora es az oszlop nem egyenlo a kihagyott resszel
                    {
                        jatek = false;
                    }
                }

//---------------------------------------------------------------------------------------

                szamlalo2++;
                if (szamlalo2 == 5)
                {
                    szamlalo2 = 0;

                    for (int i = 61; i <= 65; i++)      // regit torli
                    {
                        Console.SetCursorPosition(i, j2);
                        Console.Write(" ");
                    }

                    j2++;
                    if (j2 > 29)                         // elolor
                    {
                        j2 = 5;
                        r2 = vel.Next(1, 6); //hol ne legyen akadaly
                    }

                    for (int i = 61; i <= 65; i++)      // uj sort kiirja
                    {
                        if (i != 60 + r2)
                        {
                            Console.SetCursorPosition(i, j2);
                            Console.Write("#");
                        }
                    }

                    if (j2 == y && x != 60 + r2)//ha  a jatekos egy helyen van egy akadallyal akkor meghal |||| akadaly sora == jatekos sora es az oszlop nem egyenlo a kihagyott resszel
                    {
                        jatek = false;
                    }
                }
//---------------------------------------------------------------------------------------
                //var egy kicsit
                szamlalo++;
                if (szamlalo == 5)
                {
                    szamlalo = 0;

                    for (int i = 61; i <= 65; i++)      // regit torli
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(" ");
                    }

                    j++;
                    if (j > 29)                         // elolor
                    {
                        j = 5; 
                        r = vel.Next(1, 6); //hol ne legyen akadaly
                    }

                    for (int i = 61; i <= 65; i++)      // uj sort kiirja
                    {
                        if (i != 60 + r)
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write("#");
                        }
                    }
                    
                    if (j == y && x != 60 + r)//ha  a jatekos egy helyen van egy akadallyal akkor meghal |||| akadaly sora == jatekos sora es az oszlop nem egyenlo a kihagyott resszel
                    {
                    jatek = false;
                    }
                }

                
                Console.SetCursorPosition(x, y);
                Console.Write("X");

                System.Threading.Thread.Sleep(50);
            } while (jatek==true);
            Console.Clear();
            Console.SetCursorPosition(55, 15);
            Console.WriteLine("Vége a játéknak!");
        }
        static void Menu()//menu, interaktiv enterrel lepsz be fel le nyilakkal
        {
            //menu, interaktiv enterrel lepsz be fel le nyilakkal
            Console.ForegroundColor = ConsoleColor.White;
            const string logo = " _   _            _       _                          _            \r\n| \\ | | _____   _| |_ ___| | ___ _ __     __ _ _   _| |_ ___  ___ \r\n|  \\| |/ _ \\ \\ / / __/ _ \\ |/ _ \\ '_ \\   / _` | | | | __/ _ \\/ __|\r\n| |\\  |  __/\\ V /| ||  __/ |  __/ | | | | (_| | |_| | || (_) \\__ \\\r\n|_|_\\_|\\___| \\_/  \\__\\___|_|\\___|_| |_|  \\__,_|\\__,_|\\__\\___/|___/\r\n  (_) __ _| |_ ___| | __                                          \r\n  | |/ _` | __/ _ \\ |/ /                                          \r\n  | | (_| | ||  __/   <                                           \r\n _/ |\\__,_|\\__\\___|_|\\_\\                                          \r\n|__/                                                              ";
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
            if (billentyu.Key == ConsoleKey.Enter && szam == 0)
            {
                Jatek();
            }
            if (billentyu.Key == ConsoleKey.Enter && szam == 1)
            {
                Console.WriteLine("Skinek");
            }
            if (billentyu.Key == ConsoleKey.Enter && szam == 2)
            {
                //do
                //{


                //Console.Clear();
                //Console.ForegroundColor = ConsoleColor.Cyan;
                //Console.WriteLine("Biztos hogy ki akarsz lépni? (Enter/ESC)");
                //billentyu = Console.ReadKey(true);
                //if (billentyu.Key == ConsoleKey.Enter)
                //{
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.WriteLine("De biztos vagy benne?? (Enter/ESC)");
                //    billentyu = Console.ReadKey(true);
                //    if (billentyu.Key == ConsoleKey.Enter)
                //    {
                //        Console.ForegroundColor = ConsoleColor.Yellow;
                //        Console.WriteLine("De utána nem fogsz tudni visszalépni! Biztos ki akarsz lépni??? (Enter/ESC)");
                //        billentyu = Console.ReadKey(true);
                //        if (billentyu.Key == ConsoleKey.Enter)
                //        {
                //            Console.ForegroundColor = ConsoleColor.Red;
                //            Console.WriteLine("Utolsó esély!!! (Enter/ESC)");
                //            billentyu = Console.ReadKey(true);
                //            if (billentyu.Key == ConsoleKey.Enter)
                //            {
                //                Console.ForegroundColor = ConsoleColor.Gray;
                //                Console.WriteLine("Hát jó. :(");
                //                System.Threading.Thread.Sleep(500);
                //                    break;
                //            }
                //            else if (billentyu.Key == ConsoleKey.Escape)
                //            {
                //                Console.Clear();
                //                Menu();

                //            }
                //        }
                //        else if (billentyu.Key == ConsoleKey.Escape)
                //        {
                //            Console.Clear();
                //            Menu();
                //        }
                //    }
                //    else if (billentyu.Key == ConsoleKey.Escape)
                //    {   Console.Clear();
                //        Menu();
                //    }
                //}
                //else if (billentyu.Key == ConsoleKey.Escape)
                //{
                //    Console.Clear();
                //    Menu();
                //}
                //} while (billentyu.Key!=ConsoleKey.Enter && billentyu.Key!=ConsoleKey.Escape); //ez igy nem jo mert akarhol nyounk valami mast az enteren vagy a escen kivul akkor az elejere visszalep ahelyett hogy nem tortenne semmi
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



        static void Main()
        {
            //á, é, í, ó, ö, ő, ú, ü, ű (nincs magyar kiosztasom)
            Console.BackgroundColor = ConsoleColor.Black;
            Menu();


            



            //ihasz ur cucca

            //Console.WriteLine("Egyebek");

            //System.Threading.Thread.Sleep(3000); //késleltetés

            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("Hello");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("Szia");
            //Console.WriteLine("Pá");

            //Console.WriteLine("a s d w");

            //ConsoleKeyInfo be;
            //be = Console.ReadKey();
            //char c = be.KeyChar;

            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            //Console.SetCursorPosition(30, 10);
            //Console.WriteLine(c);
            //Console.SetCursorPosition(0, 0);
            //Console.WriteLine(c);
            //Console.WriteLine(c);


            //Console.Clear();
            //int x = 20;
            //int y = 20;
            //Console.SetCursorPosition(x, y);
            //Console.WriteLine("X");
            //do
            //{
            //    be = Console.ReadKey();
            //    c = be.KeyChar;
            //    if (c.ToString() != "")
            //    {
            //        if (c == 'd')
            //        {
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine(" ");
            //            x++;
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine("X");
            //        }
            //        if (c == 'a')
            //        {
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine(" ");
            //            x--;
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine("X");
            //        }
            //        if (c == 's')
            //        {
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine(" ");
            //            y++;
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine("X");
            //        }
            //        if (c == 'w')
            //        {
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine(" ");
            //            y--;
            //            Console.SetCursorPosition(x, y);
            //            Console.WriteLine("X");
            //        }
            //    }
            //} while (c.ToString() != "");















        }


    }
    }

