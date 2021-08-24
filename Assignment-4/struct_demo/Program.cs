using System;

namespace struct_demo
{
    struct Mystructure
    {
        //public int i;
        //int i=10; it will give error in structures but it will run in the case of classes
        public string name;
        public int id; 
        
        public Mystructure(string n, int id)
        {
            name=n;
            this.id=id;
        }
        public void display()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(id);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
        Mystructure m1=new Mystructure("sukhdev",100);
        m1.display();
        //m1.i=10; 
        //if we are not initializing value of i then it will give error when we are not using the new keyword then need to initialize data member explicitly
        }
    }
}
