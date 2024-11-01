using System.Diagnostics;

public class TryCatch
{
        static void TryCatchMain(string[] args)
        {
            int result = 0;

            Debug.WriteLine("Main method is running");

            try
            {
                Console.WriteLine("Please enter a number: ");

                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;
                result = num2 / num1;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("This always executes!");
            }

            

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
}
