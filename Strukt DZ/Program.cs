using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strukt_DZ
{
    public class MyClass
    {
        public string change;

        public MyClass()
        {
            
            Console.WriteLine(change);
        }
            

    }
     struct  MyStruct
    {
        public string change;

        public MyStruct(string change)
        {
            change = "не изменено";
        }
       
    }
    internal class Program
    {
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        Console.WriteLine(myClass.change);
        }
        public static void StruktTaker( ref MyStruct myStruct)
        {
            myStruct.change = "Изменено";
           
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyClass myClass = new MyClass(); 
            MyStruct myStruct = new MyStruct();

            myClass.change = "не изменено";
            Console.WriteLine(myClass.change);
            myStruct.change = "не изменено";
            Console.WriteLine(myStruct.change);
            ClassTaker(myClass);
            StruktTaker(ref myStruct);
            

            Console.ReadKey();
        }
    }
}
