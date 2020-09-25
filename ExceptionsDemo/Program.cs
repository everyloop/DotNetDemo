using System;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtherMethod();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Catched index out of range exception!");
            }
            catch (Exception ex)
            {                
                Console.WriteLine($"Catched exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Do some clean-up!");
            }
        }

        static void OtherMethod()
        {
            try
            {
                int i = 0;
                Console.WriteLine(100 / i);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catched divide by zero exception!");
                throw new DivideByZeroException("Hey, du har försökt dela med noll!");
            }
        }
    }
}
