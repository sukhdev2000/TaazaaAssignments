using System;

namespace abstract_2
{
    abstract class person
    {
        public string name;
        public int age;
        public abstract void connection();
    }
    class student : person
    {
        public override void connection()
        {
            string name = this.name;
            int age = this.age;
            Console.WriteLine("Name of student is " + name);
            Console.WriteLine("Age of student is " + age);
        }
    }
    class faculty : person
    {
        public override void connection()
        {
            string name = this.name;
            int age = this.age;
            Console.WriteLine("Name of Faculty is " + name);
            Console.WriteLine("Age of Faculty is " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fac = new faculty();
            var stu = new student();
            stu.age = 25;
            stu.name = "Sukhdev";
            fac.age = 45;
            fac.name = "Sandeep Sir";
            stu.connection();
            fac.connection();
        }
    }
}
