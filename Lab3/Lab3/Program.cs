using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
            if(x==y && y == z)
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if(x==y || y==z || z == x)
            {
                Console.WriteLine("The triangle is isoscles");
            }
            else
            {
                Console.WriteLine("The triangle is scalene");
            }
        }
    }

    public class Account
    {
        private string accName = "Fazla imam dip";
        private string accid = "19403541";
        private int balance = 0;

        public string AccName
        {
            get {
                return accName;
            }
            set{
                accName = Console.ReadLine();
            }
        }
        public string Acid
        {
            get {
                return accid;
            }
            set {
                accid = Console.ReadLine();
            }
        }

        public int Balance
        {
            get{
                return balance;
            }
            set{
                balance = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void WithDraw(int amount)
        {
            balance -= amount;
        }
    }

    public class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = Console.ReadLine();
            }

        }
        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = Console.ReadLine();
            }

        }
        public int CourseCredit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                courseCredit = Convert.ToInt32(Console.ReadLine());
            }

        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name   : " + courseName);
            Console.WriteLine("Course code   : " + courseCode);
            Console.WriteLine("Course credit : " + courseCredit);

        }
    }

}
