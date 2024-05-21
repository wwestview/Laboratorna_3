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
        // add code here....
    }
}
