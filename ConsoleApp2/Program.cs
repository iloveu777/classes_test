using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Circle circle = new Circle(5);
            double area = circle.CalculateArea();
            Console.WriteLine(area);
            double circ = circle.CalcCirc();
            WriteLine(circ);*/

            /* Rectangle rectangle = new Rectangle(4, 3);
             double s = rectangle.CalculateArea();
             double p = rectangle.Perimetr();
             WriteLine($"площадь прямоугольника = {s:f2}, периметр = {p:f2}");*/
            WriteLine("какой вы хотите айди?");
            int x = int.Parse(ReadLine());
            BankAccount bankAccount = new BankAccount(x , 1000);
            Clear();
            M:
            Clear();
            WriteLine("Что вы хотите? \n1. пополнить баланс.\n2. снять со счета.\n3. проверить количество денег на счету");
            int choice = int.Parse(ReadLine());
            if (choice == 1)
            {
                Clear();
                WriteLine("Сколько вы хотите положить денег на счет? ");
                double dep = double.Parse(ReadLine());
                bankAccount.deposit(dep);
                bankAccount.PrintBalance();
                WriteLine("Чтобы вернуться в меню нажмите enter");
                ReadKey();
                goto M;
            }
            else if (choice == 2)
            {
                Clear();
                WriteLine("Сколько вы хотите снять денег со счета? ");
                double wd = double.Parse(ReadLine());
                bankAccount.Withdraw(wd);
                bankAccount.PrintBalance();
                WriteLine("Чтобы вернуться в меню нажмите enter");
                ReadKey();
                goto M;
            }
            else if (choice == 3)
            {
                Clear();
                Write($"На аккаунте с номером {x} на счету: ");
                bankAccount.PrintBalance();
                WriteLine("Чтобы вернуться в меню нажмите enter");
                ReadKey();
                goto M;
            }
            ReadKey();

        }
    }
}
