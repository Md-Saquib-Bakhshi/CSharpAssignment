namespace BookManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookManager bookManager = new BookManager();
            BookServices bookServices = new BookServices(bookManager);
            bookServices.MainMenu();
        }
    }
}
