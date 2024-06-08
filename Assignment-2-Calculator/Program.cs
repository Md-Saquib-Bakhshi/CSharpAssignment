namespace Assignment_2_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            int firstNumber;
            int secondNumber;
            Calculator calculator = new Calculator();
            while (true)
            {
                Console.Write("\nEnter\n 1 for AddNumber\n 2 for SubtractNumber\n 3 for MultiplyNumber\n 4 for DivideNumber\n 5 for exit: ");
                ch = int.Parse(Console.ReadLine());
                switch(ch){
                    case 1:
                        Console.Write("Enter FirstNumber: ");
                        firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter SecondNumber: ");
                        secondNumber = int.Parse(Console.ReadLine());
                        Console.Write("Addition is: "+calculator.AddNumber(firstNumber, secondNumber));
                        break;
                    case 2:
                        Console.Write("Enter FirstNumber: ");
                        firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter SecondNumber: ");
                        secondNumber = int.Parse(Console.ReadLine());
                        Console.Write("Substraction is: "+calculator.SubtractNumber(firstNumber, secondNumber));
                        break;
                    case 3:
                        Console.Write("Enter FirstNumber: ");
                        firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter SecondNumber: ");
                        secondNumber = int.Parse(Console.ReadLine());
                        Console.Write("Multiplication is: "+calculator.MultiplyNumber(firstNumber, secondNumber));
                        break;
                    case 4:
                        Console.Write("Enter FirstNumber: ");
                        firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter SecondNumber: ");
                        secondNumber = int.Parse(Console.ReadLine());
                        Console.Write("Division is: "+calculator.DivideNumber(firstNumber, secondNumber));
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("!!!Invalid Input!!!");
                        break;
                        
                }
            }

        }
    }
}
