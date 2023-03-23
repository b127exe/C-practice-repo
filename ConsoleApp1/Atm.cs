using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Atm
    {
        static void Main(string[] args)
        {

            int balance = 10000;
            int reservePin = 123;
            int count = 0;

            pinStart:
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t========================================");
            Console.WriteLine("\t\t\t\t\t\t" + @"   /\    ------- |\    /|");
            Console.WriteLine("\t\t\t\t\t\t" + @"  /  \      |    | \  / |");
            Console.WriteLine("\t\t\t\t\t\t" + @" /----\     |    |  \/  |");
            Console.WriteLine("\t\t\t\t\t\t" + @"/      \    |    |      |");
            Console.WriteLine("\t\t\t\t\t========================================");

            Console.Write("\n\t\t\t\t\tENTER PIN: ");
            int enterPin = int.Parse(Console.ReadLine());

            if( enterPin == reservePin )
            {
                Console.WriteLine("\n\t\t\t\t\t1) Balance Inquiry \t\t2) Fast Cash \n\n\t\t\t\t\t3) Cash WithDrawel \t\t4) PIN Change \n\n\t\t\t\t\t5) Exit");

                Console.Write("\n\t\t\t\t\tEnter Option: ");
                int option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    Console.WriteLine("\n\t\t\t\t\t========================================");
                    Console.WriteLine("\n\t\t\t\t\t\tBALANCE INQUIRY");
                    Console.WriteLine("\n\t\t\t\t\tAcc no:1348446 \n\n\t\t\t\t\tName: Bilal Khan \n\n\t\t\t\t\tTotal Balance: " + balance + "Rs");
                }
                else if (option == 2)
                {
                    Console.WriteLine("\n\t\t\t\t\t========================================");
                    Console.WriteLine("\n\t\t\t\t\t\tFAST CASH OPTIONS \n\n\t\t\t\t\t1) 500 \t\t\t\t2) 1000 \n\n\t\t\t\t\t3) 2000 \t\t\t4) 5000");
                    Console.Write("\n\t\t\t\t\tEnter Option: ");
                    int fastOp = int.Parse(Console.ReadLine());
                    if(fastOp <= balance)
                    {
                    if(fastOp == 1)
                    {
                        balance = balance - 500;
                            Console.WriteLine("\n\t\t\t\t\t========================================");
                            Console.WriteLine("\n\t\t\t\t\tFast Cash Successfull \n\n\t\t\t\t\tYour current balance is " + balance + "Rs");
                    }
                    else if(fastOp == 2) {
                            balance = balance - 1000;
                            Console.WriteLine("\n\t\t\t\t\t========================================");
                            Console.WriteLine("\n\t\t\t\t\tFast Cash Successfull \n\n\t\t\t\t\tYour current balance is " + balance + "Rs");
                        }
                    else if(fastOp == 3)
                        {
                            balance = balance - 2000;
                            Console.WriteLine("\n\t\t\t\t\t========================================");
                            Console.WriteLine("\n\t\t\t\t\tFast Cash Successfull \n\n\t\t\t\t\tYour current balance is " + balance + "Rs");
                        }
                    else if(fastOp == 4)
                        {
                            balance = balance - 5000;
                            Console.WriteLine("\n\t\t\t\t\t========================================");
                            Console.WriteLine("\n\t\t\t\t\tFast Cash Successfull \n\n\t\t\t\t\tYour current balance is " + balance + "Rs");
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t\t\t\tInvalid Option");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\tInsufficient Balance...");
                    }
                }
                else if(option == 3)
                {
                    Console.WriteLine("\n\t\t\t\t\t========================================");
                    Console.WriteLine("\n\t\t\t\t\t\tCASH WITHDRAWEL");

                    Console.Write("\n\t\t\t\t\tEnter Withdawel amount: ");
                    int withAmount = int.Parse(Console.ReadLine());

                    if(withAmount <= balance)
                    {
                        balance = withAmount - balance;
                        Console.WriteLine("\n\t\t\t\t\t========================================");
                        Console.WriteLine("\n\t\t\t\t\t{0}Rs Withdraw successfully! \n\n\t\t\t\t\tYour current balance is {1}Rs",withAmount,balance);
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\tThe amout you enter is insufficient...");
                    }
                }
                else if(option == 4)
                {
                changePIN:
                    Console.Clear();
                    Console.WriteLine("\n\t\t\t\t\t========================================");
                    Console.WriteLine("\n\t\t\t\t\t\tPIN CHANGE");

                    Console.Write("\n\t\t\t\t\tEnter Old PIN: ");
                    int oldPIN = int.Parse(Console.ReadLine());

                    if(oldPIN == reservePin)
                    {
                        Console.Write("\n\t\t\t\t\tEnter New PIN: ");
                        int newPIN = int.Parse(Console.ReadLine());

                        reservePin = newPIN;
                        Console.WriteLine("\n\t\t\t\t\t========================================");
                        Console.WriteLine("\n\t\t\t\t\tPIN successfully changed...\n\n\t\t\t\t\tYou are about logout in 5 seconds.");
                        Thread.Sleep(5000);
                        goto pinStart;
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\tOld PIN not match...");
                        Thread.Sleep(2000);
                        goto changePIN;
                    }
                }
                else if(option == 5)
                {
                    goto end;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t\t\tThe option you enter is unavailable...");

                    Console.Write("\n\t\t\t\t\tDo you want to continue... ( yes / no )");
                    string op = Console.ReadLine();
                    if(op == "yes")
                    {
                        goto pinStart;
                    }
                    else
                    {
                        goto end;
                    }
                }

            }
            else
            {
                count++;
                if(count == 3)
                {
                    goto end;
                }
                else
                {
                Console.WriteLine("\n\t\t\t\t\tIncorrect Pin");
                    Thread.Sleep(2000);
                goto pinStart;
                }
            }

            end:
            Console.WriteLine("\n\t\t\t\t\tPROGRAM END...");


            Console.ReadKey();
        }
    }
}
