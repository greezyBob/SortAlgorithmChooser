using Model;
using SortManagerView;
using System.Text;

namespace SortManagerController;
public class Controller
{

    private View _view = new View();
    private int[] _unsorted;
    private ISortable _sorter;
    public bool Running { get; set; } = true;

    public void GenerateUnsortedArray()
    {
        int length = GetLengthOfArray();

        int[] arr = new int[length];
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            int rndNumber = rnd.Next(1, 100);
            arr[i] = rndNumber;
        }

        _unsorted = arr;
    }

    public void SetUp()
    {
        _view.Setup();
    }

    private int GetLengthOfArray()
    {
        _view.DisplayArrayLengthScreen();

        int size = ParseInput(_view.Input);

        while (size < 1 || size > 100)
        {
            _view.DisplayInvalidLengthMessage();
            size = ParseInput(_view.Input);
        }

        return size;
    }

    private int ParseInput(string? input)
    {
        bool success = int.TryParse(input, out int number);
        
        return success ? number : 0;
    }

    public void GetSorter()
    {
        _view.DisplaySortOptionScreen();

        int number = ParseInput(_view.Input);

        while (number <= 0 || number > 4)
        {
            _view.DisplayInvalidSortMessage();
            number = ParseInput(_view.Input);
        }

        if (number == 4) Running = false;
        else _sorter = SortFactory.ChooseSorter(number);
    }

    public void GetSotedArray()
    {
        // copy unsorted due to Array.Sort mutation
        int[] unsorted = new int[_unsorted.Length];
        _unsorted.CopyTo(unsorted, 0);

        var timeBefore = DateTime.Now;
        int[] sorted = _sorter.Sort(_unsorted);
        TimeSpan timeSpan = DateTime.Now - timeBefore;
        _view.DisplayHappyOutputScreen(ArrayToString(unsorted), ArrayToString(sorted), timeSpan.TotalSeconds);
    }

    public void CheckRetry()
    {
        int number = ParseInput(_view.Input);

        while(number < 1 || number > 2)
        {
            _view.DisplayInvalidRetryMessage();
            number = ParseInput(_view.Input);
        }

        Running = number == 2 ? false : true;
    }

    public string ArrayToString(int[] array)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[ ");
        foreach (int n in array)
        {
            sb.Append($"{n}, ");
        }
        sb.Append("]");

        return sb.ToString();
    }

}