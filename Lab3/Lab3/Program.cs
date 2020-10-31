using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Student
    {
        String name;
        String id;
        String department;
        float cgpa;
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("ID   : " + this.id);
            Console.WriteLine("Dept : " + this.department);
            Console.WriteLine("CGPA : " + this.cgpa);
        }

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = Console.ReadLine();
            }
        }

        public String Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = Console.ReadLine();
            }
        }
        public String Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = Console.ReadLine();
            }
        }

        public float Cgpa
        {
            get
            {
                return this.cgpa;
            }
            set
            {
                this.cgpa = (float)Convert.ToDouble(Console.ReadLine());
            }
        }

    }

    class Triangle
    {
        int x;
        int y;
        int z;

        public void ShowInfo()
        {
            Console.WriteLine("x : " + this.x);
            Console.WriteLine("y : " + this.y);
            Console.WriteLine("z : " + this.z);
        }

        public void TestTriangle()
        {
            if (x==y && y == z)
            {
                Console.WriteLine();
            }
        }
    }
}
