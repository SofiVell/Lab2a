using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть ділене (перше ціле число):");
        int dividend = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть дільник (друге ціле число):");
        int divisor = Convert.ToInt32(Console.ReadLine());

        if (divisor != 0)
        {
            int quotient = dividend / divisor;   
            int remainder = dividend % divisor;  

            Console.WriteLine($"Результат ділення: {dividend} / {divisor} = {quotient}");
            Console.WriteLine($"Залишок від ділення: {remainder}");
        }
        else
        {
            Console.WriteLine("Помилка: ділення на 0 неможливе!");
        }
    }
}