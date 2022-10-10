using Model;

namespace SortManagerController;

public static class SortFactory
{
    public static ISortable ChooseSorter(int input)
    {
        switch (input)
        {
            case 1: return new BubbleSortModel();
            case 2: return new MergeSortModel();
            case 3: return new DotNetSort();
            default: throw new ArgumentException();

        }
    }
}