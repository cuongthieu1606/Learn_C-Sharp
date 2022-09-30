using System;

namespace HelloWorld
{

    class Animal
    {
        public double Height;
        public double Width;

        public void Info()
        {
            Console.WriteLine($"Height: {Height}, Width: {Width}");
        }
    }


    class Cat
    {
        public double Height;
        public double Width;


        // Constructor khong co tham so
        public Cat()
        {
            Height = 10;
            Width = 800;
        }


        // Constructor co tham so 
        public Cat(int h, int w)
        {
            Height = h;
            Width = w;
        }

        public void InfoCat()
        {
            Console.WriteLine($"Cat  --->  Height: {Height}, Width: {Width}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.Height = 30;
            Dog.Width = 50;

            Dog.Info();


            // Dung tham so mac dinh cua Cat()
            Cat BlackCat = new Cat();
            BlackCat.InfoCat();

            // Dung tham so truyen vao cua Cat()
            Cat WhiteCat = new Cat(20, 900);
            WhiteCat.InfoCat();

        }
    }
}

