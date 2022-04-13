using System;
using System.Collections.Generic;
using System.Text;

namespace Marksheet
{
    class MarkSheet
    {
        public void marksheet()
        {
            try
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your roll no");
                string roll = Console.ReadLine();
                Console.WriteLine("Enter your class");
                string Class = Console.ReadLine();
                Console.WriteLine("Enter Hindi Marks");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Math Marks");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter English Marks");
                int e = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter phyisces Marks");
                int p = int.Parse(Console.ReadLine());
                Console.Read();

                int obt = h + m + e + p;
                int per = obt * 100 / 400;
                Console.WriteLine("-------MARKSHEET------");
                Console.WriteLine("Your name is :{0}", name);
                Console.WriteLine("Your roll is :{0}", roll);
                Console.WriteLine("Your class is :{0}", Class);
                Console.WriteLine("Your Obtain marks:{0}", obt);
                Console.WriteLine(" Your Present is: {0}", per);
                //---------supply-------
                //int obt = h + m + e + p;
                int supply = 0;
                if (h < 33)
                {
                    supply++;
                    Console.WriteLine("You have supply in Hindi !");

                }
                if (m < 33)
                {
                    supply++;
                    Console.WriteLine("You have supply in Maths !");
                }
                if (e < 33)
                {
                    supply++;
                    Console.WriteLine("You have supply in English !");
                }
                if (p < 33)
                {
                    supply++;
                    Console.WriteLine("You have supply in Physices !");
                }
                if(supply!=0)
                {
                    Console.WriteLine("you are fail in {0} subjects", supply);
                }
               

                //----------------if else if Remarks---------------
                if (supply == 0)
                {
                    if (per >= 80)
                    {
                        Console.WriteLine("Remarks: Excellent");
                    }
                    else if (per >= 70)
                    {
                        Console.WriteLine("Remarks: Very good");
                    }
                    else if (per >= 60)
                    {
                        Console.WriteLine("Remarks: good");

                    }
                    else if (per >= 50)
                    {
                        Console.WriteLine("Remarks: Fair");

                    }
                    else if (per >= 33)
                    {
                        Console.WriteLine("Remarks:poor");
                    }
                    else
                    {
                        Console.WriteLine("Remarks : Need lot of improvement");
                    }

                }
                else
                {
                    Console.WriteLine("Remarks: Bring your parents tomorrow");
                }

                // ----if else if grade--------------------
                if (per >= 80)
                {
                    Console.WriteLine("Grade: +A");
                }
                else if (per >= 70)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (per >= 60)
                {
                    Console.WriteLine("Grade: B");

                }
                else if (per >= 50)
                {
                    Console.WriteLine("Grade: C");

                }
                else if (per >= 33)
                {
                    Console.WriteLine("Grade: D");
                }
                else if (per >= 33)
                {
                    Console.WriteLine("Grade: E");
                }
                else
                {
                    Console.WriteLine("Grade: F (fail)");
                }

                Console.ReadLine();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }

    
}
