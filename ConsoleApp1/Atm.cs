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
        public int fastCash(ref int balance, int amount)
        {
            balance = balance - amount;
            return balance;
        }
        static void Main(string[] args)
        {

            int balance = 10000;
            int reservePin = 123;
            int count = 0;

        pinStart:
            Console.Clear();
            
            Console.WriteLine("\r\n     ___       __          __    __       ___      .______    __  .______           ___   .___________..___  ___. \r\n    /   \\     |  |        |  |  |  |     /   \\     |   _  \\  |  | |   _  \\         /   \\  |           ||   \\/   | \r\n   /  ^  \\    |  |        |  |__|  |    /  ^  \\    |  |_)  | |  | |  |_)  |       /  ^  \\ `---|  |----`|  \\  /  | \r\n  /  /_\\  \\   |  |        |   __   |   /  /_\\  \\   |   _  <  |  | |   _  <       /  /_\\  \\    |  |     |  |\\/|  | \r\n /  _____  \\  |  `----.   |  |  |  |  /  _____  \\  |  |_)  | |  | |  |_)  |     /  _____  \\   |  |     |  |  |  | \r\n/__/     \\__\\ |_______|   |__|  |__| /__/     \\__\\ |______/  |__| |______/     /__/     \\__\\  |__|     |__|  |__| \r\n                                                                                                                  \r\n");
            Console.WriteLine("==================================================================================================================");

            Console.Write("\n\t\tENTER PIN: ");
            int enterPin = int.Parse(Console.ReadLine());

            if (enterPin == reservePin)
            {
            options:
                Console.Clear();
                Console.WriteLine("\t\n  ______   .______   .___________. __    ______   .__   __.      _______.\r\n /  __  \\  |   _  \\  |           ||  |  /  __  \\  |  \\ |  |     /       |\r\n|  |  |  | |  |_)  | `---|  |----`|  | |  |  |  | |   \\|  |    |   (----`\r\n|  |  |  | |   ___/      |  |     |  | |  |  |  | |  . `  |     \\   \\    \r\n|  `--'  | |  |          |  |     |  | |  `--'  | |  |\\   | .----)   |   \r\n \\______/  | _|          |__|     |__|  \\______/  |__| \\__| |_______/    \r\n                                                                         \r\n");
                Console.WriteLine("==================================================================================================================");

                Console.WriteLine("\n\t\t1) Balance Inquiry \t\t2) Fast Cash \n\n\t\t3) Cash WithDrawel \t\t4) PIN Change \n\n\t\t5) Exit");

                Console.Write("\n\t\tEnter Option: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("\n\t\t========================================");
                    Console.WriteLine("\n\t\tBALANCE INQUIRY");
                    Console.WriteLine("\n\t\tAcc no:1348446 \n\n\t\tName: Bilal Khan \n\n\t\tTotal Balance: " + balance + "Rs");
                    Console.Write("\n\t\tDo you want to continue... ( yes / no) ");
                    string cont = Console.ReadLine();
                    if (cont == "yes")
                    {
                        goto options;
                    }
                    else
                    {
                        goto end;
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("\n\t\t========================================");
                    Console.WriteLine("\n\t\t\tFAST CASH OPTIONS \n\n\t\t1) 500 \t\t\t\t2) 1000 \n\n\t\t3) 2000 \t\t\t4) 5000");
                    Console.Write("\n\t\tEnter Option: ");
                    int fastOp = int.Parse(Console.ReadLine());
                    if (fastOp <= balance)
                    {
                        var fastcash = new Atm();
                        if (fastOp == 1)
                        {
                            Console.WriteLine("\n\t\t========================================");
                            Console.WriteLine("\n\t\tFast Cash Successfull \n\n\t\tYour current balance is " + fastcash.fastCash(ref balance, 500) + "Rs");
                            Console.Write("\n\t\tDo you want to continue... ( yes / no) ");
                            string cont = Console.ReadLine();
                            if (cont == "yes")
                            {
                                goto options;
                            }
                            else
                            {
                                goto end;
                            }
                        }
                        else if (fastOp == 2)
                        {
                            Console.WriteLine("\n\t\t========================================");
                            Console.WriteLine("\n\t\tFast Cash Successfull \n\n\t\tYour current balance is " + fastcash.fastCash(ref balance, 1000) + "Rs");
                            Console.Write("\n\t\tDo you want to continue... ( yes / no) ");
                            string cont = Console.ReadLine();
                            if (cont == "yes")
                            {
                                goto options;
                            }
                            else
                            {
                                goto end;
                            }
                        }
                        else if (fastOp == 3)
                        {
                            Console.WriteLine("\n\t\t========================================");
                            Console.WriteLine("\n\t\tFast Cash Successfull \n\n\t\tYour current balance is " + fastcash.fastCash(ref balance, 2000) + "Rs");
                            Console.Write("\n\t\tDo you want to continue... ( yes / no) ");
                            string cont = Console.ReadLine();
                            if (cont == "yes")
                            {
                                goto options;
                            }
                            else
                            {
                                goto end;
                            }
                        }
                        else if (fastOp == 4)
                        {
                            Console.WriteLine("\n\t\t========================================");
                            Console.WriteLine("\n\t\tFast Cash Successfull \n\n\t\tYour current balance is " + fastcash.fastCash(ref balance, 5000) + "Rs");
                            Console.Write("\n\t\tDo you want to continue... ( yes / no) ");
                            string cont = Console.ReadLine();
                            if (cont == "yes")
                            {
                                goto options;
                            }
                            else
                            {
                                goto end;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\t\tInvalid Option");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\tInsufficient Balance...");
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("\n\t\t========================================");
                    Console.WriteLine("\n\t\t\tCASH WITHDRAWEL");

                    Console.Write("\n\t\tEnter Withdawel amount: ");
                    int withAmount = int.Parse(Console.ReadLine());

                    if (withAmount <= balance)
                    {
                        balance = balance - withAmount;
                        Console.WriteLine("\n\t\t========================================");
                        Console.WriteLine("\n\t\t{0}Rs Withdraw successfully! \n\n\t\tYour current balance is {1}Rs", withAmount, balance);
                        Console.WriteLine("\n\t\t========================================");    
                        Console.Write("\n\t\tDo you want to continue... ( yes / no) ");
                        string cont = Console.ReadLine();
                        if (cont == "yes")
                        {
                            goto options;
                        }
                        else
                        {
                            goto end;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\tThe amout you enter is insufficient...");
                        Console.Write("\n\t\t\t\t\tDo you want to continue... ( yes / no) ");
                        string cont = Console.ReadLine();
                        if (cont == "yes")
                        {
                            goto options;
                        }
                        else
                        {
                            goto end;
                        }
                    }
                }
                else if (option == 4)
                {
                changePIN:
                    Console.Clear();
                    Console.WriteLine("\r\n.______    __  .__   __.      ______  __    __       ___      .__   __.   _______  _______ \r\n|   _  \\  |  | |  \\ |  |     /      ||  |  |  |     /   \\     |  \\ |  |  /  _____||   ____|\r\n|  |_)  | |  | |   \\|  |    |  ,----'|  |__|  |    /  ^  \\    |   \\|  | |  |  __  |  |__   \r\n|   ___/  |  | |  . `  |    |  |     |   __   |   /  /_\\  \\   |  . `  | |  | |_ | |   __|  \r\n|  |      |  | |  |\\   |    |  `----.|  |  |  |  /  _____  \\  |  |\\   | |  |__| | |  |____ \r\n| _|      |__| |__| \\__|     \\______||__|  |__| /__/     \\__\\ |__| \\__|  \\______| |_______|\r\n                                                                                           \r\n");

                    Console.Write("\n\t\tEnter Old PIN: ");
                    int oldPIN = int.Parse(Console.ReadLine());

                    if (oldPIN == reservePin)
                    {
                        Console.Write("\n\t\tEnter New PIN: ");
                        int newPIN = int.Parse(Console.ReadLine());

                        reservePin = newPIN;
                        Console.WriteLine("\n\t\t========================================");
                        Console.WriteLine("\n\t\tPIN successfully changed...\n\n\t\tYou are about logout in 5 seconds.");
                        Thread.Sleep(5000);
                        goto pinStart;
                    }
                    else
                    {
                        Console.WriteLine("\n\t\tOld PIN not match...");
                        Thread.Sleep(2000);
                        goto changePIN;
                    }
                }
                else if (option == 5)
                {
                    goto end;
                }
                else
                {
                    Console.WriteLine("\n\t\tThe option you enter is unavailable...");

                    Console.Write("\n\t\tDo you want to continue... ( yes / no )");
                    string op = Console.ReadLine();
                    if (op == "yes")
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
                if (count == 3)
                {
                    goto end;
                }
                else
                {
                    Console.WriteLine("\n\t\tIncorrect Pin...");
                    Thread.Sleep(2000);
                    goto pinStart;
                }
            }

        end:
            Console.WriteLine("\n\t\tPROGRAM END...");


            Console.ReadKey();
        }
    }
}
