namespace projekt
{
    internal class Program
    {
        static void Menu()//menu, interaktiv enterrel lepsz be fel le nyilakkal
        {
            //menu, interaktiv enterrel lepsz be fel le nyilakkal
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" _   _            _       _                          _            \r\n| \\ | | _____   _| |_ ___| | ___ _ __     __ _ _   _| |_ ___  ___ \r\n|  \\| |/ _ \\ \\ / / __/ _ \\ |/ _ \\ '_ \\   / _` | | | | __/ _ \\/ __|\r\n| |\\  |  __/\\ V /| ||  __/ |  __/ | | | | (_| | |_| | || (_) \\__ \\\r\n|_|_\\_|\\___| \\_/  \\__\\___|_|\\___|_| |_|  \\__,_|\\__,_|\\__\\___/|___/\r\n  (_) __ _| |_ ___| | __                                          \r\n  | |/ _` | __/ _ \\ |/ /                                          \r\n  | | (_| | ||  __/   <                                           \r\n _/ |\\__,_|\\__\\___|_|\\_\\                                          \r\n|__/                                                              ");
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
                    Console.WriteLine(" _   _            _       _                          _            \r\n| \\ | | _____   _| |_ ___| | ___ _ __     __ _ _   _| |_ ___  ___ \r\n|  \\| |/ _ \\ \\ / / __/ _ \\ |/ _ \\ '_ \\   / _` | | | | __/ _ \\/ __|\r\n| |\\  |  __/\\ V /| ||  __/ |  __/ | | | | (_| | |_| | || (_) \\__ \\\r\n|_|_\\_|\\___| \\_/  \\__\\___|_|\\___|_| |_|  \\__,_|\\__,_|\\__\\___/|___/\r\n  (_) __ _| |_ ___| | __                                          \r\n  | |/ _` | __/ _ \\ |/ /                                          \r\n  | | (_| | ||  __/   <                                           \r\n _/ |\\__,_|\\__\\___|_|\\_\\                                          \r\n|__/                                                              ");
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
                    Console.WriteLine(" _   _            _       _                          _            \r\n| \\ | | _____   _| |_ ___| | ___ _ __     __ _ _   _| |_ ___  ___ \r\n|  \\| |/ _ \\ \\ / / __/ _ \\ |/ _ \\ '_ \\   / _` | | | | __/ _ \\/ __|\r\n| |\\  |  __/\\ V /| ||  __/ |  __/ | | | | (_| | |_| | || (_) \\__ \\\r\n|_|_\\_|\\___| \\_/  \\__\\___|_|\\___|_| |_|  \\__,_|\\__,_|\\__\\___/|___/\r\n  (_) __ _| |_ ___| | __                                          \r\n  | |/ _` | __/ _ \\ |/ /                                          \r\n  | | (_| | ||  __/   <                                           \r\n _/ |\\__,_|\\__\\___|_|\\_\\                                          \r\n|__/                                                              ");
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
                    Console.WriteLine(" _   _            _       _                          _            \r\n| \\ | | _____   _| |_ ___| | ___ _ __     __ _ _   _| |_ ___  ___ \r\n|  \\| |/ _ \\ \\ / / __/ _ \\ |/ _ \\ '_ \\   / _` | | | | __/ _ \\/ __|\r\n| |\\  |  __/\\ V /| ||  __/ |  __/ | | | | (_| | |_| | || (_) \\__ \\\r\n|_|_\\_|\\___| \\_/  \\__\\___|_|\\___|_| |_|  \\__,_|\\__,_|\\__\\___/|___/\r\n  (_) __ _| |_ ___| | __                                          \r\n  | |/ _` | __/ _ \\ |/ /                                          \r\n  | | (_| | ||  __/   <                                           \r\n _/ |\\__,_|\\__\\___|_|\\_\\                                          \r\n|__/                                                              ");
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
                    Console.WriteLine(" _   _            _       _                          _            \r\n| \\ | | _____   _| |_ ___| | ___ _ __     __ _ _   _| |_ ___  ___ \r\n|  \\| |/ _ \\ \\ / / __/ _ \\ |/ _ \\ '_ \\   / _` | | | | __/ _ \\/ __|\r\n| |\\  |  __/\\ V /| ||  __/ |  __/ | | | | (_| | |_| | || (_) \\__ \\\r\n|_|_\\_|\\___| \\_/  \\__\\___|_|\\___|_| |_|  \\__,_|\\__,_|\\__\\___/|___/\r\n  (_) __ _| |_ ___| | __                                          \r\n  | |/ _` | __/ _ \\ |/ /                                          \r\n  | | (_| | ||  __/   <                                           \r\n _/ |\\__,_|\\__\\___|_|\\_\\                                          \r\n|__/                                                              ");
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
                return;
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



        static void Main(string[] args)
        {
            //á, é, í, ó, ö, ő, ú, ü, ű (nincs magyar kiosztasom)
            Menu();
            ConsoleKeyInfo billentyu;

            billentyu = Console.ReadKey();
            

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(19, 25);
            Console.WriteLine("|");

            int x = 20;
            int y = 20;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("X");
            do
            {
                billentyu = Console.ReadKey(true);
                
                if (billentyu.Key != ConsoleKey.None)
                {
                    if (billentyu.Key == ConsoleKey.RightArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        if (x!=20 && x!=25)
                        {
                            x++;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("X");
                    }
                    if (billentyu.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        if (x >= 20 && x <= 25)
                        {
                            x--;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("X");
                    }
                    if (billentyu.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        if (y >= 20 && y <= 25)
                        {
                            y++;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("X");
                    }
                    if (billentyu.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        if (y >= 20 && y <= 25)
                        {
                            y--;
                        }   
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("X");
                    }
                }
            } while (billentyu.Key != ConsoleKey.Escape);



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

