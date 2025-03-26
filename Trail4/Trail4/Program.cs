using System;
namespace Trail4
{
    class Program
    {
        static void Main()
        {
            Console.Beep();
            //String name = "John";
            //String age = "25";
            //Console.WriteLine($"Hello {name} , you are {age} years old. Right?");
            ////Lets add space
            //Console.WriteLine($"Hello{name,10},you are{age,-10}years old. Right?");
            ////SINGLE DIMESSIONAL ARRAY
            //int[] arr = [5, 2, 5, 77, 9];
            ////PRINTING ALL ARRAYS
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            ////LETS GO TO MULTIDIMENTIONAL ARRAY
            //int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            ////PRINTING ALL ARRAYS
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //USING DIFF CLASS FROM OUTSIDE
            Messagess.Hello();
            Messagess.Bye();

            Cat cat1 = new Cat();
            cat1.name = "Tom";
            cat1.age = 5;
            cat1.Meow();
            cat1.introduce();

            Cat cat2 = new Cat();
            cat2.name = "Oggy";
            cat2.age = 3;
            cat2.Meow();
            cat2.introduce();
        }
    }
    class Cat()
    {
        public string name;
        public int age;

        public void introduce()
        {
            Console.WriteLine($"My name is {name} and I am {age} years old");
        }

        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
}