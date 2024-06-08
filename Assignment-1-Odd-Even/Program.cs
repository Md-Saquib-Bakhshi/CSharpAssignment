namespace Assignment_1_Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            OddEven oddEven = new OddEven();
            Console.Write("Enter the target value upto odd or even you wants to print: ");
            oddEven.TargetValue = int.Parse(Console.ReadLine());
            oddEven.OddEvenIdentifier();
            while (true)
            {
                Console.Write("\nEnter\n 1 for OddOutputs\n 2 for EvenOutputs\n 3 for Exit: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        oddEven.GetOddList();
                        break;
                    case 2:
                        oddEven.GetEvenList();
                        break;
                    case 3:
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
