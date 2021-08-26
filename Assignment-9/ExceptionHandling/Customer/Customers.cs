using System;
namespace ExceptionHandling
{
    public class Customers
    {
        int result;
        public Customers()
        {
            result=0;
        }
        public void getData(int x, int y)
        {
            try
        {
            result=x/y;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception has handled");
        }
        finally
        {
            Console.WriteLine("Result :{0}",result);
        }
        } 
    }
}