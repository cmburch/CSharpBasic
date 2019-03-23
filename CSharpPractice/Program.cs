using System;
using System.Collections.Generic;
using CSharpPractice.Math;

namespace CSharpPractice
{   

    class MainClass
    {

        public static void Main(string[] args)
        {
            //create a list and remove all of the un-unique values
            //List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            List<int> numbers1 = new List<int>() { 1, 3, 3, 4, 2, 1 };
            List<int> unique = new List<int>();

            foreach (var number1 in numbers1)
            {
                if (!unique.Contains(number1)) 
                {
                    unique.Add(number1);
                }
            }
            //return the unique array


            //creating new lIst
            var numbers = new List<int> { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});
            numbers.IndexOf(1);


            string fullname1 = "homer simpson";
            var name = fullname1.Split(' '); // return is a string array [homer,simpson] 
            Console.WriteLine(name[0]); //homer
            Console.WriteLine(name[1]); //simpson

            foreach (var item in numbers)
            {   
                Console.WriteLine(item);
            }

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
//create a reverse method
public static string ReverseName(string name)
    {
        //create an array of char from the name;
        var array = new char[name.Length];
        for (int i = name.Length; i > 0; i--)
        {
            array[name.Length - i] = name[i - 1];
        }
        var reversed = new string(array);
        return reversed;
    }


}

name = two //length = 3  i = 3

    //array[0] = 