using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerDataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe 
            {
                //Declare variable
                int randomVariable = 100;

                //Boxing --> convert value type to reference type

                //Value we are storing in stack and reference we are storing in heap

                int val = 10;
                object obj = val;

                Console.WriteLine(obj);

                //UnBoxing --> convert reference type to value type

                int num = 1000;
                object obj2 = num; //boxing -- implicit conversion
                int i = (int)obj2; //unboxing -- explicit conversion



                //store variable address in some pointer

                int* pointer = &randomVariable;

                Console.WriteLine("Value  : "+randomVariable);

                Console.WriteLine("Address : ",(int)pointer);
                Console.ReadLine();
            
            }
           

        }
    }
}
