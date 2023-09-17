

/*
Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura */

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a+b+c)/3);
        }
    }
}