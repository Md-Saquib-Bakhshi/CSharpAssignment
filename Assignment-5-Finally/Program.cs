namespace Assignment_5_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            try
            {
                int i = 2;
                while (i >= 0)
                {
                    Console.Write("Guess number between 1 to 10: ");
                    if (!int.TryParse(Console.ReadLine(), out int number))
                    {
                        throw new FormatException("Invalid format must enter integer value.");
                    }
                    NumberValidator.NumberValidate(number);
                    if (randomNumber == number)
                    {
                        Console.WriteLine("You Won.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{i} more chance left.");
                        Console.WriteLine("Better luck next time.");
                    }
                    i--;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Exception: {ex.Message}");
            }
            //So if we miss any exception in that case execution will stop if program dont have finally to verify comment the below catch.
            catch (NumberException ex)
            {
                Console.WriteLine($"Number Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thanks for playing.");
            }
            //Console.WriteLine("Thanks for playing.");
        }
    }
}
