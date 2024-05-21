using System.Text;
namespace Go_A
{
    public class Kolachko
    {
        public class Variant4_1
        {
            public static void Main_1()
            {

                Console.Write("Enter elements of array: ");
                string[] input = Console.ReadLine().Split(' ');
                Console.Write("Enter the first index: ");
                int k = int.Parse(Console.ReadLine());
                Console.Write("Enter a second index: ");
                int t = int.Parse(Console.ReadLine());
                int[] array = AnnounceArray(input);
                DeleteElements(ref array, k, t);
                PrintArray(array);


            }

            public static int[] AnnounceArray(string[] Input)
            {
                int[] Arr = new int[Input.Length];
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = int.Parse(Input[i]);
                }

                return Arr;
            }
            public static void PrintArray(int[] arr)
            {
                foreach (var element in arr)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            public static int[] DeleteElements(ref int[] array, int k, int t)  // t = number of elements 
            {                                                         // k = started from the k-th element
                                                                      // size new array (if we have lenght of array which equals 10, we minus number of elements 
                int newSize = array.Length - t; // 7-3 = 4;

                int[] newArray = new int[newSize]; // The new array will equal 7

                for (int i = 0; i < k; i++)
                {
                    newArray[i] = array[i]; // This (for) uses for thing like make new array without space 
                }

                for (int i = k + t; i < array.Length; i++)
                {
                    newArray[i - t] = array[i]; // if newArray[4-3] = array[1] // 
                }

                array = newArray;
                return newArray;
            }
        }
        public class Variant4_3
        {
            public static void Main_4()
            {
                Console.Write("Enter count of jag array: ");
                int[][] jagArr = PrintJagArray.Input();
                jagArr.Resize();
            }

        }
    }
    public static class PrintJagArray
    {
        public static void Print(this int[][] jagArr)
        {
            foreach (var subArray in jagArr)
            {
                foreach (var element in subArray)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[][] Input()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagArr = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter count of elements for row from {i} to ... ");
                string[] input = Console.ReadLine().Split(' ');
                jagArr[i] = new int[input.Length];
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    jagArr[i][j] = int.Parse(input[j]);
                }
            }
            return jagArr;
        }

    }
    public static class DeleteRows
    {
        public static void Resize(this int[][] jagArr)
        {
            Console.Write("Enter the fisrt {k} position: ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a second {k} position: ");
            int k2 = int.Parse(Console.ReadLine());
            int remove = Remove(k1, k2);
            int[][] newArr = new int[jagArr.Length - remove][];
            int newIndex = 0;
            for (int i = 1; i < jagArr.Length; i++)
            {
                if (i < k1 || i > k2)
                {
                    newArr[newIndex] = jagArr[i];
                    newIndex++;
                }
            }

            jagArr = newArr;
            jagArr.Print();
        }

        private static int Remove(int k1, int k2)
        {
            return k2 - k1 + 1;
        }
    }
    public class Kharchenko
    {
        public class Programm
        {

            //12. Вставити К елементів, починаючи з номеру T.
            public static void Maineeee()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.Write("Як заповнити масив? 1 - вручну, будь-яке інше число - рандомно: ");
                int choice = int.Parse(Console.ReadLine());
                int[] arr;
                if (choice == 1)
                    arr = ManualFillArray();
                else
                {
                    arr = RandomFillArray();
                    Console.WriteLine("Створений массив: ");
                    Console.WriteLine(string.Join(", ", arr));
                }

                ParseElements(ref arr);
                Console.WriteLine(string.Join(", ", arr));
            }
            static int[] ManualFillArray()
            {
                string[] input = Console.ReadLine().Trim().Split();
                int[] arr = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                    arr[i] = int.Parse(input[i]);
                return arr;
            }
            static int[] RandomFillArray()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Random rd = new Random();
                Console.WriteLine("Довжина масиву: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                    arr[i] = rd.Next(-10, 10);
                return arr;
            }

            static void ParseElements(ref int[] arr)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("Номер Т: ");
                int t = int.Parse(Console.ReadLine());

                if (t < 0 || t > arr.Length)
                    Console.WriteLine("Неможливо вставити");
                else
                {
                    Console.WriteLine("Елементи, що потрібно вставити: ");
                    int[] insArr = ManualFillArray();
                    int k = insArr.Length;

                    int[] newArr = new int[arr.Length + k];

                    for (int i = 0; i < t; i++)
                        newArr[i] = arr[i];

                    for (int i = t; i < t + k; i++)
                        newArr[i] = insArr[i - t];

                    for (int i = t + k; i < newArr.Length; i++)
                        newArr[i] = arr[i - k];

                    arr = newArr;
                }
            }
        }

        public class Programa
        {
            //12. Додати рядок перед рядком, що містить максимальний елемент (якщо у різних місцях є кілька
            // елементів з однаковим максимальним значенням, то брати останній з них).

            public static void RandomFillJagArray(int[][] arr)
            {
                int n = arr.Length;
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    int length = rand.Next(1, 10);
                    arr[i] = new int[length];
                    for (int j = 0; j < length; j++)
                        arr[i][j] = rand.Next(0, 20);
                }
            }
            public static void ManualFillJagArray(int[][] arr)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                int n = arr.Length;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Вводьте елементи {0}-го рядка", i);
                    arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                }
            }
            public static int[] ManualFillArray()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("Введіть елементи масива: ");
                string[] input = Console.ReadLine().Trim().Split();
                int[] arr = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                    arr[i] = int.Parse(input[i]);
                return arr;
            }
            public static int GetIndexOfRowWithMaxElement(int[][] arr)
            {
                int maxRowIndex = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i].Max() >= arr[maxRowIndex].Max()) maxRowIndex = i;
                }
                return maxRowIndex;
            }

            public static void AddRow(ref int[][] arr)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                int index = GetIndexOfRowWithMaxElement(arr);
                Array.Resize(ref arr, arr.Length + 1);
                for (int i = arr.Length - 1; i > index; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[index] = ManualFillArray();
                Console.WriteLine("Вставлено рядок: {0}", index);
            }

            public static void PrintJaggedArray(int[][] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i} : ");
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            public static void Maineee()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("Кількість рядків: ");
                int n = int.Parse(Console.ReadLine());
                int[][] jagArr = new int[n][];

                Console.Write("Як заповнити масив? 1 - вручну, будь-яке інше число - рандомно: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                    ManualFillJagArray(jagArr);
                else
                    RandomFillJagArray(jagArr);

                Console.WriteLine("Масив перед вставкою");
                PrintJaggedArray(jagArr);
                AddRow(ref jagArr);
                Console.WriteLine("Масив після вставки");
                PrintJaggedArray(jagArr);
            }
        }
    }
}
