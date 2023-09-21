using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegates
{


    public delegate void cal(int a, int b);
    internal class Program
    {
        public  static void  Addtion(int num1,int num2)
        {
            int result = num1 + num2; 
            Console.WriteLine("Addtion of  two numbers:"+result);
        }
        public static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("multiply of  two numbers:" + result);
        }
        public static void Divison(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("Divison of  two numbers:" + result);
        }
        static void Main(string[] args)
        {
            cal obj = new cal(Addtion);
            //obj(56, 67);
            //obj = Multiply;
            //obj(56, 7);
            // muticasting method
            obj += Multiply;
            
            obj += Divison;
            obj(150, 100);
            Console.WriteLine();

            

            
        }

    }
}
