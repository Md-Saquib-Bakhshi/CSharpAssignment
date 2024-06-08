namespace Assignment_3_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Temperature temp = new Temperature();
            while (true)
            {
                Console.Write("\nEnter\n 1 for Fahrenheit_To_Celsius\n 2 for Celsius_To_Fahrenheit\n 3 for Exit: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter fahrenheit: ");
                        temp.TemperatureValue = double.Parse(Console.ReadLine());
                        Console.Write(temp.Fahrenheit_To_Celsius(temp.TemperatureValue) + " celcius");
                        break;
                    case 2:
                        Console.Write("Enter celsius: ");
                        temp.TemperatureValue = double.Parse(Console.ReadLine());
                        Console.Write(temp.Celsius_To_Fahrenheit(temp.TemperatureValue) + " fahrenheit");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("!!!Invalid Choice!!!");
                        break;
                }
            }
        }
    }
}
