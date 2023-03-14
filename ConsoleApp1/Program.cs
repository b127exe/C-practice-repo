using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULATOR WORK

            //Console.WriteLine("----------CALCULATOR----------");

            //Console.Write("Enter first Number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second Number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Pick up the choice (+ , - , * , /)");
            //string signs = Console.ReadLine();

            //switch (signs)
            //{
            //    case "+":
            //        Console.WriteLine("The result of addition is " + (num1 + num2));
            //        break;
            //    case "-":
            //        Console.WriteLine("The result of substraction is " + (num1 - num2));
            //        break;
            //    case "*":
            //        Console.WriteLine("The result of multiplication is " + (num1 * num2));
            //        break;
            //    case "/":
            //        Console.WriteLine("The result of division is " + (num1 / num2));
            //        break;
            //    default:
            //        Console.WriteLine("Wrong Syntax");
            //        break;
            //}

            //MARKS WORK

            //double eng, urdu, math;

            //Console.Write("Enter English Marks: ");
            //eng = int.Parse(Console.ReadLine());
            //Console.Write("Enter Math Marks: ");
            //math = int.Parse(Console.ReadLine());
            //Console.Write("Enter Urdu Marks: ");
            //urdu = int.Parse(Console.ReadLine());

            //Console.WriteLine("==========RESULT==========");
            //int total = 300;
            //double obtained = eng + math + urdu;
            //double res = obtained / total;

            //Console.WriteLine("Obtained Marks: " + obtained);
            //Console.WriteLine("Total Marks: " + total);
            //Console.WriteLine("Percentage is {0}%\n",Math.Round(res*100));


            // Hotel system

            // pakistani 
            int biryaniPrice = 300;
            int nihariPrice = 290;
            int pulaoPrice = 350;
            int naanPrice = 30;

            // japanese 
            int sushiPrice = 500;
            int ramenPrice = 470;
            int takoyakiPrice = 600;
            int unagiPrice = 500;

            // italian
            int pastaPrice = 300;
            int risottoPrice = 1200;
            int cuisinePrice = 1000;
            int seafoodPrice = 900;

            Console.WriteLine("\t\t\t\t\t===============Rosetti Resturent===============");

            Console.Write("\n\t\t\t\t\tEnter the amount you have: ");
            int yourAmount = int.Parse(Console.ReadLine()); 

            if(yourAmount >= 2500)
            {
                Console.WriteLine("\n\t\t\t\t\t1) Pakistani 2) Japanese 3) Italian");

                Console.Write("\n\t\t\t\t\tChoose Option: ");
                int chooseCountry = int.Parse(Console.ReadLine());

                if(chooseCountry == 1)
                {
                    Console.WriteLine("\n\t\t\t\t\t1) Biryani 2) Nihari 3) Pulao 4) Naan");

                    Console.Write("\n\t\t\t\t\tChoose Option: ");
                    int chooseOp1 = int.Parse(Console.ReadLine());

                    if(chooseOp1 == 1)
                    {

                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (biryaniPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tBiryani price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", biryaniPrice,quantity1,yourAmount,biryaniPrice*quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if(chooseOp1 == 2)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (nihariPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tNihari price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", nihariPrice, quantity1, yourAmount, nihariPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if(chooseOp1 == 3)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (pulaoPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tPulao price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", pulaoPrice, quantity1, yourAmount, pulaoPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if(chooseOp1 == 4)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (naanPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tNaan price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", naanPrice, quantity1, yourAmount, naanPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tUnknown Category! \n\n\t\t\t\t\tPress any key to exit... ");
                    }

                }
                else if (chooseCountry == 2)
                {
                    Console.WriteLine("\n\t\t\t\t\t1) Sushi 2) Ramen 3) Takoyaki 4) Unagi");

                    Console.Write("\n\t\t\t\t\tChoose Option: ");
                    int chooseOp1 = int.Parse(Console.ReadLine());

                    if (chooseOp1 == 1)
                    {

                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (sushiPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tSushi price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", sushiPrice, quantity1, yourAmount, sushiPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if (chooseOp1 == 2)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (ramenPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tRamen price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", ramenPrice, quantity1, yourAmount, ramenPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if (chooseOp1 == 4)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (unagiPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tUnagi price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", unagiPrice, quantity1, yourAmount, unagiPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if (chooseOp1 == 3)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (takoyakiPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tTakoyaki price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", takoyakiPrice, quantity1, yourAmount, takoyakiPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tUnknown Category! \n\n\t\t\t\t\tPress any key to exit... ");
                    }
                }
                else if (chooseCountry == 3)
                {
                    Console.WriteLine("\n\t\t\t\t\t1) Pasta 2) Risotto 3) Cuisine 4) Seafood");

                    Console.Write("\n\t\t\t\t\tChoose Option: ");
                    int chooseOp1 = int.Parse(Console.ReadLine());

                    if (chooseOp1 == 1)
                    {

                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (pastaPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tPasta price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", pastaPrice, quantity1, yourAmount, pastaPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if (chooseOp1 == 2)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (risottoPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tRisotto price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", risottoPrice, quantity1, yourAmount, risottoPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if (chooseOp1 == 4)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (seafoodPrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tSeafood price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", seafoodPrice, quantity1, yourAmount, seafoodPrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else if (chooseOp1 == 3)
                    {
                        Console.Write("\n\t\t\t\t\tEnter Quantity: ");
                        int quantity1 = int.Parse(Console.ReadLine());

                        yourAmount = yourAmount - (cuisinePrice * quantity1);
                        Console.WriteLine("\n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tBilling Receipt \n\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\tCuisine price: {0}Rs \n\n\t\t\t\t\tQuanity: {1} \n\n\t\t\t\t\tBalance amount: {2}Rs \n\n\t\t\t\t\tTotal payable amount: {3}Rs", cuisinePrice, quantity1, yourAmount, cuisinePrice * quantity1);
                        Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tUnknown Category! \n\n\t\t\t\t\tPress any key to exit... ");
                    }
                }
                else
                {
                    Console.WriteLine("\n\t\t\t\t\t----------------------------------------------- \n\n\t\t\t\t\t\t\tUnknown Country! \n\n\t\t\t\t\tPress any key to exit... ");
                }
            }
            else
            {
                Console.WriteLine("\n\n\t\t\t\t\tThe amount you enter is insufficient!");
            }

            Console.ReadKey();
        }
    }
}
