namespace HW_2_Dedok_interfaces
{
    public interface IOutput_2
    {
        void Show();
        void Show(string info);
    }
    public interface IMath_1
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
    public class Array_2 : IOutput_2, IMath_1, ISort, ICalc, IOutput2, ICalc2, IComparable<Array_2>
    {
        private int[] __array;

        public Array_2(int size)
        {
            __array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < __array.Length; i++)
            {
                __array[i] = rand.Next(1, 101);
            }
        }
        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in __array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
        public int Max()
        {
            return __array.Max();
        }

        public int Min()
        {
            return __array.Min();
        }

        public float Avg()
        {
            return (float)__array.Average();
        }

        public bool Search(int valueToSearch)
        {
            return __array.Contains(valueToSearch);
        }
        public void SortAsc()
        {
            Array.Sort(__array);
        }

        public void SortDesc()
        {
            Array.Sort(__array);
            Array.Reverse(__array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
        public int Less(int valueToCompare)
        {
            return __array.Count(element => element < valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return __array.Count(element => element > valueToCompare);
        }

        // IOutput2 interface methods
        public void ShowEven()
        {
            Console.WriteLine("Парні значення масиву:");
            foreach (int element in __array.Where(x => x % 2 == 0))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні значення масиву:");
            foreach (int element in __array.Where(x => x % 2 != 0))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        public int CountDistinct()
        {
            return __array.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return __array.Count(x => x == valueToCompare);
        }
        public int CompareTo(Array_2 other)
        {
            return this.Max().CompareTo(other.Max());
        }
    }
}