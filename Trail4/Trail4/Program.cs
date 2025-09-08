using System;
using System.Diagnostics;
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
            //Messagess.Hello();
            //Messagess.Bye();

            //Cat cat1 = new Cat("Oggy", 2);
            //cat1.introduce();
            //cat1.Meow();
            //Cat cat2 = new Cat("Jack", 3);
            //cat2.introduce();
            //cat2.Meow();
            //Console.WriteLine("Enter the name of the car, model, year and color Respectively!");
            //String nameofcar = Console.ReadLine();
            //String modelofcar = Console.ReadLine();
            //String yearofcar = Console.ReadLine();
            //String colorofcar = Console.ReadLine();

            //    Console.WriteLine("Enter the number of cars");
            //    int numberofcars =  Convert.ToInt32(Console.ReadLine());
            //    for(int  i = 0;i<numberofcars; i++) 
            //    {
            //        Console.WriteLine("Enter the name of the car, model, year and color Respectively!");
            //        String nameofcar = Console.ReadLine();
            //        String modelofcar = Console.ReadLine();
            //        String yearofcar = Console.ReadLine();
            //        String colorofcar = Console.ReadLine();
            //        Car car = new Car(nameofcar, modelofcar, Convert.ToInt32(yearofcar), colorofcar);
            //        car.Drive();

            //    }
            //}
            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();


            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();
            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();
            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            bike.go();


            //USE ABSTRACT KEYS TO LOCK A CLASS EXAMPLE:
            //Vechile yatch = new Vechile(); //now i created  a new vechile from Vechile and it works
            //but go  to "class vechile" and add abstract keyword beside class and anymore its not possible.

        }
    }
    //class Cat
    //{
    //    public String name;
    //    public int age;

    //    public Cat(String name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    public void introduce()
    //    {
    //        Console.WriteLine($"My name is {name} and I am {age} years old");
    //    }

    //    public void Meow()
    //    {
    //        Console.WriteLine("Meow");
    //    }
    //}

    //class Car
    //{
    //    String name;
    //    String model;
    //    int year;
    //    String color;

    //    public Car(String nameofcar, String modelofcar, int yearofcar, String colorofcar)
    //    {
    //        this.name = nameofcar;
    //        this.model = modelofcar;
    //        this.year = yearofcar;
    //        this.color = colorofcar;

    //        //Drive();
    //    }
    //    public void Drive()
    //    {
    //        Console.WriteLine("Driving "+name+ " in " +year+ ". Color: "+color+" "+model );
    //    }


    abstract class Vechile  //ADD ABSTRACT HERE 
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("Speeding up...");
        }
    }
    class Car : Vechile
    {
        public int wheels = 4;
    }

    class Bike : Vechile
    {
        public int wheels = 2;
    }
    class Boat : Vechile
    {
        public int wheels = 0;
    }

}