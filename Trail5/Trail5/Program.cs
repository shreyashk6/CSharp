using System;
namespace Trail5
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Beep();
            ////STATIC 
            //Car car1 = new Car("GRRR");
            //Car car2 = new Car("PRRR");
            //Car car3 = new Car("TRRR");
            //Console.WriteLine();
            //Console.WriteLine("Number of Cars:"+Car.numberofcars);//for non static: +car1.numberofcars
            ////Console.WriteLine("Number of Cars:" + car2.numberofcars);//for non static
            //Car.Race();

            //OVERLOADING CONSTRUCTORS
            pizza p1 = new pizza("Thin", "Tomato", "Mozzarella", "Pepperoni");
            pizza p2 = new pizza("naa", "noh", "naah");
        }
    }
    ////Static
    //class Car
    //{

    //    //string model;
    //    //public static int numberofcars;//add keyword static to make it class level
    //    //public Car(String model)
    //    //{
    //    //    this.model = model;
    //    //    numberofcars++;
    //    //}
    //    //public static void Race()
    //    //{
    //    //    Console.WriteLine("Racing");
    //    //}
    //}


    //OVERLOADING CONSTRUCTORS
    class pizza
    {
        string bread;
        string sauce;
        string cheese;
        string toppings;
        public pizza(string bread, string sauce, string cheese, string toppings)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.toppings = toppings;
            Console.WriteLine($"Making a pizza with {bread} crust, {sauce} sauce, {cheese} cheese, and {toppings} toppings.");
            Console.WriteLine("Parameter 1 is working");
        }
        public pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            Console.WriteLine($"Making a pizza with {bread} crust, {sauce} sauce and {cheese} cheese");
            Console.WriteLine("Parameter 2 is working");
        }
        public pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
            Console.WriteLine($"Making a pizza with {bread} crust and {sauce} sauce");
            Console.WriteLine("Parameter 3 is working");
        }
        public pizza(string bread)
        {
            this.bread = bread;
            Console.WriteLine($"Making a pizza with {bread} crust");
            Console.WriteLine("Parameter 4 is working");
        }

    }


}