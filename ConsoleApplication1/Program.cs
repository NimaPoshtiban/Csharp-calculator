using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Calculator";
            //define an infinite loop for make sure That only user close the program
            while (true)
            {

                
                Console.WriteLine("Enter your function sign(/,*,-,+)");
                //Now I Use switch method
                string function = Convert.ToString(Console.ReadLine());
                switch (function)
                {//To make sure only we got int i use try method
                    case "/":
                        {
                            try
                            {
                                Console.WriteLine("Enter your First Number");
                                int a, b;
                                a = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter your Second Number");
                                b = Convert.ToInt32(Console.ReadLine());
                                int result = a / b;
                                Console.WriteLine("The Result Is" + " " + result);
                               
                                    }

                            catch
                            {
                                Console.WriteLine("Wrong Syntax");
                               
                            }
                            break;
                        }

                    case "*":
                        {
                            try
                            {
                                Console.WriteLine("Enter your First Number");
                                int a, b;
                                a = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter your Second Number");
                                b = Convert.ToInt32(Console.ReadLine());
                                int result = a * b;
                                Console.WriteLine("The Result Is" + " " + result);
                            }
                            catch 
                            {
                                Console.WriteLine("Wrong Syntax");
                            }
                            
                            break;
                        }

                    case "-":
                        {
                            try
                            {
                                Console.WriteLine("Enter your First Number");
                                int a, b;
                                a = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter your Second Number");
                                b = Convert.ToInt32(Console.ReadLine());
                                int result = a - b;
                                Console.WriteLine("The Result Is" + " " + result);
                            }
                            catch 
                            {
                                Console.WriteLine("Wrong Syntax");
                            }
                            break;
                        }

                    case "+":
                        {
                            try
                            {
                                Console.WriteLine("Enter your First Number");
                                int a, b;
                                a = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter your Second Number");
                                b = Convert.ToInt32(Console.ReadLine());
                                int result = a + b;
                                Console.WriteLine("The Result Is" + " " + result);
                            }
                            catch 
                            {
                                Console.WriteLine("Wrong Syntax");
                            }
                            
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong or Unsupported Function!");
                            break;
                        }
                }
               

            }
        }


    }
}

