using SortManagerController;

namespace SortManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
           
            while (controller.Running)
            {
                controller.SetUp();
                controller.GetSorter();
                if (!controller.Running) break;
                controller.GenerateUnsortedArray();
                controller.GetSotedArray();
                controller.CheckRetry();
            }
        }
    }
}