using Model;
using SortManagerView;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace SortManagerController;
public class Controller
{

    private View _view = new View();
    private int[] _unsorted;
    private ISortable _sorter;

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
        
        string length = Console.ReadLine();

        int size = ParseInput(length);

        if (size < 1 || size > 100) throw new ArgumentException();

        return size;
    }

    private int ParseInput(string? input)
    {
        bool success = int.TryParse(input, out int number);
        if (success) return number;
        else _view.DisplayInvalidInputMessage();

        return 0;
    }

    public void GetSorter()
    {
        _view.DisplaySortOptionScreen();
        string input = Console.ReadLine();

        int number = ParseInput(input);

        if (number > 0 && number < 4)
        {
            _sorter = SortFactory.ChooseSorter(number);
            
        }
    }

    public void GetSotedArray()
    {
        int[] sorted = _sorter.Sort(_unsorted);
        _view.DisplayHappyOutputScreen(ArrayToString(_unsorted), ArrayToString(sorted), 0.2);
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