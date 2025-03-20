using System;
using System.Transactions;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine //FOR NEW LINE
            ////Console.Write // FOR SAME LINE
            //Console.Write("YO!");
            //Console.WriteLine("Hello!");
            //Console.WriteLine("Newlineseee");
            Console.Beep();//BEEP SOUND
            ////THIS IS A COMMENT 
            ///*
            // * THIS IS A MULTI 
            // * LINE
            // * COMMENT
            // */
            //Console.WriteLine("YO\bCar");
            //Console.WriteLine("YO\nCar");

            ////OUTPUT TYPES
            //int x = 50;
            //int y = 88;
            //int z = x + y;
            //Console.WriteLine(z);
            //Console.WriteLine("total: " +z);
            //Console.WriteLine("total: " + z +"kgs");

            ////DIFF TYPES OF VARIABLES
            //int a =9;
            //double b=9.9;
            //char symbol = '@';
            //String animal = "Cat";
            //bool alive= true; //TRUE OR FALSE
            //Console.WriteLine(""+a+" "+b+" "+symbol+" "+alive+ " "+animal);
            //String Username = symbol + animal;
            //Console.WriteLine(Username);
            //const String dog = "Bird";
            //// dog = symbol + animal; //CANNOT BE CHANGED ONCE DECLARED AS CONST VARIABLE
            //Console.WriteLine(dog);

            //// LETS CONVERT A VARIABLE FROM DOUBLE TO INT
            //double num = 3.147;
            //int num1  = Convert.ToInt32 (num);
            //Console.WriteLine(num1);

            //////USER INPUT 
            ////Console.WriteLine("Enter your name ");
            ////String name1 = Console.ReadLine();
            ////Console.WriteLine(name1);
            //////LETS ASK AGE WITH AN EXCEPTION (JUST CAN ENTER AGE)
            ////Console.WriteLine("Enter your age ");
            ////int age = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine(age);

            ////LETS FINE A SQUARE OF A NO.
            //int c = 8;
            //double d = Math.Pow(c, 2);//2 MEANS C TO THE POWER 2
            //Console.WriteLine(d);

            //int e = -3;
            //double f = Math.Abs(e);//Abs MAKES NO. +VE
            //Console.WriteLine(f);

            ////LETS ROUND OFF A VALUE
            //double g = 9.3433443443;
            //double h = Math.Round(g);
            //Console.WriteLine(h);
            ////ROUND OFF AN INCREASE 
            //double i = Math.Ceiling(g);
            //Console.WriteLine(i);
            ////ROUND OFF AN DECREASE
            //double j = Math.Floor(g);
            //Console.WriteLine(j);
            //int n01 = 99;
            //int n02 = 101;
            //double max = Math.Max(n01, n02);
            //Console.WriteLine(max);

            //Random random = new Random();   
            //int ran = random.Next(1,7);
            //Console.WriteLine(ran);


            //String fullname = "Shreyas H K";
            //Console.WriteLine(fullname);
            //String firstname = fullname.Substring(0, 7);
            //String lastname = fullname.Substring(3,6);
            //Console.WriteLine(firstname);
            //Console.WriteLine(lastname);

            //Console.WriteLine("Please select Y or N: ");
            //String anss= Console.ReadLine();
            //anss = anss.ToUpper();
            //Console.WriteLine(anss);

            ////ARRAYS
            //String[] cars =
            //{
            //    "bmw",  "mustang", "mercedes" , "tesla"
            //};
            //Console.WriteLine(cars[0]);

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}   
            ////FOREACH
            //foreach(string i in cars)
            //{
            //    Console.WriteLine(i);
            //}
      //      hbd();

        }
    
    //static void hbd()
    //    {
    //        Console.WriteLine("HBDHBDHBDHBD");
    //    }
    }
}