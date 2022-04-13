using System;
using System.Collections.Generic;
using System.Text;

namespace Marksheet
{
    class loop
    {
        public void forloop()
        {
            for(int i=0;i<=10;i++)  //counter variable
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For Loop terminates");
        }
        public void fortable()
        {
            Console.WriteLine("Enter Number");
            int number=int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(number+"X"+i+"="+number*i);
              
            }
            Console.ReadLine();
        }
        public void whileTable()
        {
            
            Console.WriteLine("enter number for while loop");
            int number=int.Parse(Console.ReadLine());
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine(number+"X"+i+"="+number*i);
                i++;
            }
        }
        public void doWhile()
        {
            Console.WriteLine("enter number for doWhile");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                i++;
                Console.WriteLine(number+"X"+i+"="+number*i);
               
            } while (i<10);
           
        }
        public void nestedloop()
        {
            for (int i = 0; i <=5; i++)
            {
                int k = 5;
                k -= i;
                for (int j=0; j <=k; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
