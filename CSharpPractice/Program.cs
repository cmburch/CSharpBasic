using System;

namespace CSharpPractice
{

    //creating a class
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
            byte number = 5;
            int count = 10;
            float totalPrice = 20.15f;
            char letter = 'H';
            string firstName = "Name";
            bool isWorking = true;

            Console.Write(number);

            //below is a format string
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);



            //type conversion 

            //implicit

            int b = 1;
            int i = b;

            //explicit

            //int i = 1;
            //byte b = i; //won't compile


            //example of casting
            float f = 1.0f;
            int x = (int)f;

            //NON - compatible types casting
            string s = "1";
            int y = Convert.ToInt32(s);
            int j = int.Parse(s);


            ////////////////////Increment
            ////postfix
            //int a = 1;
            //int b = a++;  //a = 2, b=1;

            ////pretfix
            //int a = 1;
            //int b = ++a;  //a = 2, b=2;


            //practice: create a new Person 

            var john = new Person();
            john.FirstName = "john";
            john.LastName = "hank";
            john.Introduce();
             
        }
    }

}
