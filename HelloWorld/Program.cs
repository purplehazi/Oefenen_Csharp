using HelloWorld;
using static System.Runtime.InteropServices.JavaScript.JSType;


/*
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //int x = 30;

            //int x = 10; int y = 20; int z = 30;

            int x = 10, 
                y = 20,
                z = 30;

            int age = 30;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 3000000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.000000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 5000.5M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            age = 31;
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}





namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            char letter = 'j'; // single quote for char  

            Console.Write("Your name is ");
            Console.Write(name);
            Console.WriteLine();
            Console.WriteLine(letter);
            Console.ReadLine();
        }
    }
}




namespace HelloWorld3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ageText = "30";
            int age = Convert.ToInt32(ageText);
            Console.WriteLine(age);

            string numberText = "3000000000";
            long bigNumber = Convert.ToInt64(numberText);
            Console.WriteLine(bigNumber);

            string negativeText = "-55.2";
            double negative = Convert.ToDouble(negativeText);
            Console.WriteLine(negative);

            string precisionText = "5.000001";
            float precision = Convert.ToSingle(precisionText);
            Console.WriteLine(precision);

            string moneyText = "14.99";
            decimal money = Convert.ToDecimal(moneyText);
            Console.WriteLine(money);

            Console.ReadLine();

        }
    }
}


namespace HelloWorld4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool value = true;

            bool isMale = true;
            Console.WriteLine(isMale);

            isMale = false;
            Console.WriteLine(isMale);
            Console.ReadLine();
        }
    }
}
*/

namespace HelloWorld5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exc_1.Excercise1(args);

            int age = 30;

            age++; // age = age + 1 // age += 1
            age /= 10; //2.3 -> 2, dus je kan double gebruiken ipv int
            Console.WriteLine(age);
            

            string name = "John";
            name += " usually stinks a lot";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}


