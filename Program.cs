using System;

namespace Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Имеем одномерный массив arr: ");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            foreach (var mas in arr)
            {
                Console.Write(mas + " ");
            }

            Console.Write("\nПроведем сортитовку по возрастанию: ");
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine("\nВычислим сумму чисел массива arr.");
            int sum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Сумма чисел = {0}",sum);

            Console.ReadKey();
        }
    }
}
