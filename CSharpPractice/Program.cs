using System;
using CSharpPractice.Math;

namespace CSharpPractice
{   

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

            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 4);
            Console.WriteLine(result);

            /////////Arrays//////////////
            //1st way of declaring array
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            //2nd way of declaring array
             int[] numbers1 = new int[3] {1,2,3};
            //////////

            ///////////ENUMS
            public enum ShippingMethod 
            {
                RegularAirMail = 1,
                RegisteredAirMail = 2,
                Express = 3 
            }

        ShippingMethod method = ShippingMethod.Express;


    }
    }

}
