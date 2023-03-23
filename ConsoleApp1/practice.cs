using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class practice
    {

        /* Function Types
         * 1) with argument and no return
         * 2) no argument and with return
         * 3) no  argument and no return
         * 4) with argument and with return
         */
        
        // no argument and no return
        public void myFunc1()
        {
            Console.WriteLine("This is function with no argument and no return");
        }

        // with argument and with return
        public int myFunc2(int a, int b)
        {
            return a + b;
        }

        // with argument and no return
        public void myFunc3(string name)
        {
            Console.WriteLine("Mr. " + name);
        }

        // no argument and with return
        public int myFunc4()
        {
            int i = 10;
            int j = 14;
            
            return i + j;
        }

        // measure grade method

        public char takeGrade(int per)
        {
            char grade;

            if(per >= 90 && per <= 100)
            {
                grade = 'A';
            }
            else if(per >= 80 && per <= 90)
            {
                grade = 'B';
            }
            else if(per >= 70 && per <= 80)
            {
                grade = 'C';
            }
            else if(per >= 50 && per <= 70)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            return grade;
        }

        static void sample()
        {
            Console.WriteLine("Hello World");
        }

        static void Main(string[] args)
        {
            //sample();

            //int math = 80;
            //int english = 60;
            //int urdu = 100;

            //int obt = math + english + urdu;
            //int per = (obt * 100) / 300;

            //var bilal = new practice();
            //Console.WriteLine("Your grade is "+bilal.takeGrade(per));

            // 4 types of methods 

            //    var p4 = new practice();
            //    Console.WriteLine(p4.myFunc4());

            //var p3 =  new practice();
            //p3.myFunc3("Bilal Khan");

            //var p1 = new practice();
            //p1.myFunc1();


            //Console.Write("Enter first value: ");
            //int f = int.Parse(Console.ReadLine());
            //Console.Write("Enter second value: ");
            //int s = int.Parse(Console.ReadLine());

            //var p2 = new practice();
            //Console.WriteLine(p2.myFunc2(f,s));


            //Array Practice

            //int[] array = new int[4] {
            // 45,
            // 67,
            // 32,
            // 12
            //};


            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //Console.Write("Enter length: ");
            //int len = Convert.ToInt32(Console.ReadLine());

            //int[] nums = new int[len];

            //for(int i = 0; i < len; i++)
            //{
            //    Console.Write("Enter Array Values {0}: ",i+1);
            //    nums[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("===============================");

            //foreach (int i  in nums)
            //{

            //    Console.WriteLine(i);
            //}

            //string[,] names = new string[3, 2];
            //names[0, 0] = "Bilal";
            //names[0, 1] = "Ali";
            //names[1, 0] = "Sara";
            //names[1, 1] = "Ayesha";
            //names[2, 0] = "Haris";
            //names[2, 1] = "Zain";

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(names[i, j]);
            //    }
            //}

            //int[] num = {12, 23, 56, 17};

            //foreach (int i in num)
            //{
            //   Console.WriteLine(i);
            //}

            //int pin;

            //do
            //{
            //    Console.Write("Enter Pin: ");
            //    pin = int.Parse(Console.ReadLine());
            //} while (pin != 123);

            //Console.WriteLine("Pin Successfully connect!");

            //Console.WriteLine(@"   /\    ======= |\    /|");
            //Console.WriteLine(@"  /  \      |    | \  / |");
            //Console.WriteLine(@" /----\     |    |  \/  |");  
            //Console.WriteLine(@"/      \    |    |      |");


            Console.ReadKey();  
        }
    }
}
