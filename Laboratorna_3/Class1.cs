using Go_A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    public class TupM
    {
       public static void Main()
        {
            int choice;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("Для виконання завдань Колачка  натисніть '1' ");
                Console.WriteLine("Для виконання завдань Харченка  натисніть '2' ");
                Console.WriteLine("Для виходу з програми натисніть '0' ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Виконую варіант Колачка: ");
                        Console.WriteLine("--------------------------");
                        Kolachko.Variant4_1.Main_1();
                        Console.WriteLine("--------------------------");
                        Kolachko.Variant4_3.Main_4();
                        Console.WriteLine("--------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Виконую варінт Харченка: ");
                        Kharchenko.Programm.Maineeee();
                        Kharchenko.Programa.Maineee();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 0.", choice);
                        break;
                }
            } while (choice != 0);

        }
    }
}
