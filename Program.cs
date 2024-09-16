namespace HW_2_Dedok_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task (every three tasks in one code): ");
            Console.ReadKey();
            Array_2 myArray_2 = new Array_2(10);
            myArray_2.Show();
            myArray_2.Show("Виведення масиву:");
            myArray_2.ShowEven();
            myArray_2.ShowOdd();

            Console.WriteLine("Кількість унікальних значень у масиві: " + myArray_2.CountDistinct());

            int valueToCompare = 50;
            Console.WriteLine($"Кількість елементів, рівних {valueToCompare}: " + myArray_2.EqualToValue(valueToCompare)); 

            Console.WriteLine("Максимум: " + myArray_2.Max());
            Console.WriteLine("Мінімум: " + myArray_2.Min());
            Console.WriteLine("Середнє арифметичне: " + myArray_2.Avg());

            int valueToSearch_1 = 50;
            Console.WriteLine($"Шукаємо значення {valueToSearch_1} у масиві: " + (myArray_2.Search(valueToSearch_1) ? "Знайдено" : "Не знайдено"));

            myArray_2.SortAsc();
            myArray_2.Show("Масив відсортований за зростанням:");

            myArray_2.SortDesc();
            myArray_2.Show("Масив відсортований за спаданням:");

            Console.WriteLine($"Кількість елементів менших за {valueToCompare}: {myArray_2.Less(valueToCompare)}");
            Console.WriteLine($"Кількість елементів більших за {valueToCompare}: {myArray_2.Greater(valueToCompare)}");

            Array_2 myArray_3 = new Array_2(10);
            int comparisonResult = myArray_2.CompareTo(myArray_3);
            Console.WriteLine("Порівняння двох масивів за максимальним елементом:");
            if (comparisonResult > 0)
            {
                Console.WriteLine("Перший масив має більший максимум.");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("Другий масив має більший максимум.");
            }
            else
            {
                Console.WriteLine("Максимуми обох масивів однакові.");
            }
            Console.ReadKey();
        }
    }
}
