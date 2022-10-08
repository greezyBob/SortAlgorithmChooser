using SortManagerController;

namespace SortManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            
            controller.SetUp();
            controller.GetSorter();
            controller.GenerateUnsortedArray();
            controller.GetSotedArray();
        }
    }
}