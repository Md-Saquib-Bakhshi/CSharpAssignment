namespace Assignment_4_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            Console.Write("Enter string to checK: ");
            inputString = Console.ReadLine();
            Palindrome palindrome = new Palindrome(inputString);
            palindrome.IsPalindrome();
            Console.WriteLine(palindrome.ToString());
        }
    }
}
