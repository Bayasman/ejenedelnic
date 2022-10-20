
using System;
using еженедельник;

namespace ConsoleApp3
{
    namespace ConsoleApp3
    {
        internal class Program
        {
            static void Main()
            {

                int position = 1;

                DateTime date = DateTime.Today;
                List<axaxaxaxaxa> zametki = Menu();
                Console.SetCursorPosition(0, position);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    else if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.LeftArrow)
                    {
                        date = changingday(key, date);
                    }

                    Console.Clear();


                    Console.WriteLine(date);
                    foreach (axaxaxaxaxa zametka in zametki)
                    {
                        if (zametka.Time == date)
                        {

                            Console.WriteLine(" " + zametka.name);
                        }
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        for (int i = 0; i < zametki.Count; i++)
                        {
                            if (zametki[i].Time == date)
                            {
                                Console.WriteLine(zametki[i].Description);
                            }
                        }
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                }
            }
            static DateTime changingday(ConsoleKeyInfo key, DateTime date)
            {
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        date = date.AddDays(-1);
                        break;
                    case ConsoleKey.RightArrow:
                        date = date.AddDays(1);
                        break;
                }

                return date;
            }


            static List<axaxaxaxaxa> Menu()
            {
                DateTime dateTime = DateTime.Today;

                axaxaxaxaxa zametka1 = new axaxaxaxaxa();
                zametka1.name = "  пойти  на пары";
                zametka1.Description = "  просидеть 5 пар";
                zametka1.Time = dateTime;

                axaxaxaxaxa zametka2 = new axaxaxaxaxa();
                zametka2.name = "  играть в майн на парах";
                zametka2.Description = "  Целых 5 часов";
                zametka2.Time = dateTime.AddDays(+3);

                axaxaxaxaxa zametka3 = new axaxaxaxaxa();
                zametka3.name = "  Посидеть на парах";
                zametka3.Description = " делать домашку на все парах из за того что играл в майн на парах  ";
                zametka3.Time = dateTime.AddDays(+4);

                axaxaxaxaxa zametka4 = new axaxaxaxaxa();
                zametka4.name = "  поиграть в волейбол ";
                zametka4.Description = " собраться с друзьями  ";
                zametka4.Time = dateTime.AddDays(+5);

                axaxaxaxaxa zametka5 = new axaxaxaxaxa();
                zametka5.name = "  идти на роботу ";
                zametka5.Description = "  и купить шаурму за точто хорошо потрудился ";
                zametka5.Time = dateTime.AddDays(+2);


                List<axaxaxaxaxa> zametki = new List<axaxaxaxaxa>();
                zametki.Add(zametka1);
                zametki.Add(zametka2);
                zametki.Add(zametka3);
                zametki.Add(zametka4);
                zametki.Add(zametka5);



                return zametki;


            }
        }


    }
}