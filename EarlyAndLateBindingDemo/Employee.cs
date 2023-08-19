using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarlyAndLateBindingDemo
{
    public class Employee
    {
        //Instance Data members
        public string name;
        public int age;
        public int id;

        // we can create only one static constructor not more
        // A static constructor can not be parameterized constructor
        // A constructor has no return type
        // when we invoke default constructor it will initialize all the data members as 0 value and null value for string and object type 
        // we can use parameterised constructor to initialize each data members of the class
        // we can use private data members and we can initialize the value of private data members by using property that is get and set method 

        //static Employee()
        //{

        //}

        ////static Employee()
        //{

        //}

        //static Employee(int age, string name)
        //{

        //}

        //Default constructor
        public Employee()
        {

            Console.WriteLine("Default Constructor is called");
        }

        //parameterized constructor
        public  Employee(int id,int age, string name)
        {
            this.id = id;
            this.age = age;
            this.name = name;            
        }

        public Employee(int id, int age, string name,string testdata)
        {
            this.id = id;
            this.age = age;
            this.name = name;
        }


        //protected Employee(int a)
        //{

        //}

        //public Employee(string test1, string test2)
        //{

        //}
        //public Employee(float test2,decimal test4)
        //{

        //}


        public  void details(string name,int age,int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            Console.WriteLine("Myself : "+name);
            Console.WriteLine("Age : "+age);
        }
    }
}
