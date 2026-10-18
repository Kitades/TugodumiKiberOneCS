using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    public class Human
    {
        public int Height = 170;
        public int Age = 25;
        public string Name = "Иван";

    }

    public class Child: Human
    {
        new public int Age = 5;
        new public int Height = 100;
        public void SetHeight(int x)
        {
            if((x > 100) & (x < 170))
            {
                Height = x;
            }
        }
        public void SetAge(int x)
        {
            if ((x > 0) & (x < 16))
            {
                Age = x;
            }
        }

        public void Print()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Рост: " + Height);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child ivan = new Child();
            ivan.Print();
            ivan.SetHeight(140);
            ivan.SetAge(40);
            ivan.Print();
            ivan.SetAge(3);
            ivan.SetHeight(180);
            ivan.Print();

        }
    }
}