namespace EnBuyukSayiBasamagi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbercount,
                TheBiggestNumber=int.MinValue,
                basamak=0,
                Temp=int.MaxValue;
            Console.WriteLine("Hello, How many numbers do you want to enter. Enter numbers only ");
            numbercount=int.Parse(Console.ReadLine());
            int[] numbers = new int[numbercount];
            for (int i=0;i<numbercount;i++)
            {
                Console.WriteLine($"Enter the {i+1}. number");
                numbers[i] = int.Parse(Console.ReadLine());
                if (TheBiggestNumber <= numbers[i])
                {
                    TheBiggestNumber = numbers[i];
                }
            }
            Console.WriteLine($"The largest number you entered:{TheBiggestNumber}");
            Temp = TheBiggestNumber;
            while (true)
            {
                if (Temp>9)
                {
                    Temp = Temp / 10;
                    basamak++;
                }
                else
                {
                    basamak++;
                    break;
                }
            }
            Console.WriteLine($"\n number of digits:{basamak}");
        }
    }
}