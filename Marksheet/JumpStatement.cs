using System;
using System.Collections.Generic;
using System.Text;

namespace Marksheet
{
    class JumpStatement
    {
        public void Break() 
        {
            Console.WriteLine("------Break Jump Statement-------");
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(i);
                if(i==5)
                {
                    break;
                }

            }
            Console.WriteLine("Loop terminate");
        }
        public void Continue()
        {
            Console.WriteLine("------Continue jump statement");
            Console.WriteLine("odd number is------");
            for (int i = 0; i < 10; i++)
            {
               
                if(i%2==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("loop terminate");
        }
        //---------------------------------goto----------
        public void GOTO()
        {
            Console.WriteLine("-----goto statement------");
            for (int i = 0; i <10; i++)
            {
                if(i==6)
                {
                    Console.WriteLine("goto level1");
                    goto level1;
                }
                Console.WriteLine(i);
            }
            level3:
            for (int i = 11; i < 20; i++)
            {
                if(i==15)
                {
                    Console.WriteLine("gotolevel2");
                    goto level2;
                }
                Console.WriteLine(i);
            }
            level1:
            for (int i = 6; i < 15; i++)
            {
                Console.WriteLine(i);
                if(i==9)
                {
                    Console.WriteLine("gotolevel3");
                    goto level3;
                }
               

            }
            level2:
            for (int i = 15; i < 25; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class hello
    {
        public void restarting()
        {
            string confim;
            do
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter secound number");
                int num2 = int.Parse(Console.ReadLine());
                int add = num1 + num2;
                Console.WriteLine(add);
                Console.WriteLine("Do you want to repeat your program? yes/no");
                confim = Console.ReadLine().ToLower();
            } while (confim== "yes");
            Console.WriteLine("out of the loop...");
            Console.ReadLine();
        }
        public void restatingcontinue()
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter secound number");
                int num2 = int.Parse(Console.ReadLine());
                int add = num1 + num2;
                Console.WriteLine(add);
                Console.WriteLine("Do you want to repeat your program? yes/no");
                string confim = Console.ReadLine().ToLower();
                if(confim=="yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        
    }
}
